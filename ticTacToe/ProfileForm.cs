using System;
using System.Drawing;
using System.IO;   
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ticTacToe
{


    public partial class ProfileForm : Form
    {
        private int currentUserId;
        private DataAccess db = new DataAccess();
        private string newAvatarFilePath = null; // Đường dẫn avatar mới nếu người dùng thay đổi
        private string currentAvatarPath = "default.png"; // Đường dẫn avatar hiện tại

        public ProfileForm(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
            pnEdit.Visible = false;
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            ProfileData data = db.GetProfile(currentUserId);

            if (data == null)
            {
                MessageBox.Show("Lỗi: Không thể tải thông tin người dùng.");
                return;
            }

            string rankTextDisplay = data.EloScore == 0 ? "rank: unrankable" : "rank top x (giả định)";
            string eloText = data.ShowElo ? $"ELO: {data.EloScore}" : "ELO: hidden";

            LoadAvatar(pbAvatar_ProfileForm_DisplayPn, data.AvatarPath);
            LoadAvatar(pbEditAvatar, data.AvatarPath);
            // Lưu lại đường dẫn hiện tại cho chức năng Cancel
            currentAvatarPath = data.AvatarPath;


            // Cập nhật pnDisplay
            lblUsername_ProfileForm_DisplayPn.Text = data.Username;
            lblEmail_ProfileForm_DisplayPn.Text = data.Email;
            tbBioDisplay.Text = data.Bio;
            lblElo_ProfileForm_DisplayPn.Text = eloText;
            lblRankDisplay_ProfileForm_DisplayPn.Text = rankTextDisplay;


            // Cập nhật pnEdit
            tbEditUsername.Text = data.Username;
            tbEditBio.Text = data.Bio;
            cbShowElo.Checked = data.ShowElo;

            lblEditElo.Text = data.ShowElo ? $"ELO: {data.EloScore}" : "ELO: hidden";
            lblEditRank.Text = rankTextDisplay;
        }

        private void LoadAvatar(PictureBox pb, string path)
        {
            // Đặt ảnh mặc định trong trường hợp lỗi
            string defaultPath = Path.Combine(Application.StartupPath, "Resources", "Avatars", "default.png");

            try
            {
                string fullPath = Path.Combine(Application.StartupPath, "Resources", "Avatars", path);

                if (File.Exists(fullPath))
                {
                    // Tải ảnh từ file
                    using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        pb.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    // Nếu không tìm thấy file, tải ảnh mặc định (default.png)
                    if (File.Exists(defaultPath))
                    {
                        using (var stream = new FileStream(defaultPath, FileMode.Open, FileAccess.Read))
                        {
                            pb.Image = Image.FromStream(stream);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Xử lý lỗi nếu việc tải ảnh thất bại 
                pb.Image = null;
                // MessageBox.Show("Lỗi tải ảnh: " + ex.Message); (debug thì dùng k thì thôi)
            }
        }

        private void pnEdit_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            pnDisplay_ProfileForm.Visible = false;
            pnEdit.Visible = true;
            pnEdit.BringToFront(); 

            // đồng bộ dữ liệu trên pnEdit 
            LoadProfileData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnEdit.Visible = false;
            pnDisplay_ProfileForm.Visible = true;

            // reset lại ảnh cũ (tôi bị ngựa)
            newAvatarFilePath = null; 
                                      
            LoadAvatar(pbEditAvatar, currentAvatarPath);
        }

        // không đổi avt đời không nể
        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFile.Title = "Chọn ảnh đại diện mới"; 

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // tải ảnh tạm thời để xem trước (k ai hỏi tôi tự làm)
                    pbEditAvatar.Image = new System.Drawing.Bitmap(openFile.FileName);
                    newAvatarFilePath = openFile.FileName; //lưu đường dẫn file mới (tạm thời)
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newUsername = tbEditUsername.Text;
            string newBio = tbEditBio.Text;
            bool showElo = cbShowElo.Checked;
            string avatarPathToSave = currentAvatarPath; // Mặc định là ảnh cũ

            if (string.IsNullOrEmpty(newUsername))
            {
                MessageBox.Show("Tên người dùng không được để trống.", "Cảnh báo");
                return;
            }

            // Xử lý lưu avatar nếu người dùng có chọn ảnh mới
            if (newAvatarFilePath != null)
            {
                if (newAvatarFilePath != null)
                {
                    try
                    {
                        // khúc này xử lý ảnh cho khớp với picturebox thôi (tôi bị ngựa)
                        Image originalImage = Image.FromFile(newAvatarFilePath);
                        int targetSize = 96;
                        Image resizedImage = new Bitmap(targetSize, targetSize);

                        using (Graphics graphics = Graphics.FromImage(resizedImage))
                        {
                            // sau này muốn cài đặt quality thì thêm ở đây
                            graphics.DrawImage(originalImage, 0, 0, targetSize, targetSize);
                        }

                        string fileName = $"User_{currentUserId}_{DateTime.Now.Ticks}.png";
                        string destinationPath = Path.Combine(Application.StartupPath, "Resources", "Avatars", fileName);

                        resizedImage.Save(destinationPath, originalImage.RawFormat); // Lưu ảnh đã resize

                        originalImage.Dispose();
                        resizedImage.Dispose();

                        avatarPathToSave = fileName;
                        currentAvatarPath = fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xử lý hoặc lưu ảnh: " + ex.Message, "Lỗi File");
                        return;
                    }
                }
            }

            // nhớ cập nhật DB
            if (db.UpdateProfile(currentUserId, newUsername, newBio, avatarPathToSave, showElo))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thành công");

                newAvatarFilePath = null; // Reset đường dẫn tạm

                LoadProfileData(); // tải dữ liệu mới nhất từ DB lên Form

                pnEdit.Visible = false;
                pnDisplay_ProfileForm.Visible = true;
                pnDisplay_ProfileForm.BringToFront(); 

                // diaglog để biết có thành công hay không 
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể cập nhật thông tin (Kiểm tra kết nối DB hoặc tên người dùng có thể đã bị trùng).", "Lỗi DB");
            }
        }

        private void pbEditAvatar_Click(object sender, EventArgs e)
        {

        }
    }

    public class ProfileData
    {
        public string AvatarPath { get; set; }
        public int EloScore { get; set; }
        public bool ShowElo { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
    }
}