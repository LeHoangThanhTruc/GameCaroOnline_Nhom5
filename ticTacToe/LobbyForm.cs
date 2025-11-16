using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class LobbyForm : Form
    {
        // lưu trữ tham chiếu đến landingPage để hiển thị lại khi đăng xuất
        private int currentUserId;
        private string currentUsername;
        private DataAccess db = new DataAccess();
        public LobbyForm(int userId, string username)
        {
            InitializeComponent();
            this.currentUserId = userId;
            this.currentUsername = username;
            LoadLobbyProfileData();

        }

        private void LoadAvatar(PictureBox pb, string path)
        {
            // đặt ảnh mặt định TH lỗi
            string defaultPath = Path.Combine(Application.StartupPath, "Resources", "Avatars", "default.png");

            try
            {
                // kết hợp đường dẫn đầy đủ
                string fullPath = Path.Combine(Application.StartupPath, "Resources", "Avatars", path);

                // kiểm tra file có tồn tại không
                if (File.Exists(fullPath))
                {
                    // tải ảnh từ file
                    using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        pb.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    // nếu không tìm thấy file, tải ảnh mặc định (default.png)
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
                pb.Image = null;
            }
        }

        private void LoadLobbyProfileData()
        {
            ProfileData data = db.GetProfile(currentUserId);

            if (data == null) return;
            LoadAvatar(pbAvatar_Lobby, data.AvatarPath);

            this.currentUsername = data.Username;
        }

        private void btnLogOut_LobbyForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"are you sure you want to log out from {currentUsername} ?", "confirm log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
                landingPage landingPageForm = new landingPage();
                landingPageForm.Show();
            }
            else { } // No thì không làm gì cả
        }

        private void pbAvatar_Lobby_Click(object sender, EventArgs e)
        {
            int currentUserId = this.currentUserId;

            ProfileForm profileForm = new ProfileForm(currentUserId);
            if (profileForm.ShowDialog() == DialogResult.OK)
            {
                LoadLobbyProfileData(); 
            }
        }
    }
}
