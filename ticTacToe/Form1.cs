using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Firebase.Auth;

namespace ticTacToe
{
    public partial class landingPage : Form
    {
        public landingPage()
        {
            InitializeComponent();
            textboxes = new TextBox[] { tbPW, tbPW_SignUpPN, tbConfirmPW, tbNewPW, tbConfirmNewPW };
        }

        private DataAccess db = new DataAccess();
        private int currentUserId = -1; // Biến lưu trạng thái UserID hiện tại (-1 nghĩa là chưa đăng nhập)
        private string currentForgotEmail = ""; // Biến lưu Email đang chờ xác nhận trong quá trình quên mật khẩu

        // Biến mới cho quên mật khẩu
        private string storedVerificationCode; // Lưu mã xác minh đã gửi
        private DateTime codeExpirationTime; // Thời gian hết hạn mã
        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnLanding.Visible = false;
            pnLogin.Visible = true;
            pnLogin.BringToFront();

            this.AcceptButton = btnLoginPnl; // thích thì nhấn enter cho nhanh
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnLanding.Visible = false;
            pnLogin.Visible = false;
            pnSignUp.Visible = true;
            pnLogin.BringToFront();

            this.AcceptButton = btnSignUp_SignUpPn; // giống ở trên
        }

        
        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lklbSignUpLoginPnl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Gán trạng thái đã truy cập liên kết
            lklbLogin_SignUpPn.LinkVisited = true;
            pnLogin.Visible = false;
            pnSignUp.Visible = true;
            pnSignUp.BringToFront();
        }

        private void lklbLogin_SignUpPn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnSignUp.Visible = false;
            pnLogin.Visible = true;
            pnLogin.BringToFront();
        }

        private void lklbNewPW_linkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnLogin.Visible = false;
            pnForgotPW.Visible = true;
            pnForgotPW.BringToFront();
        }

        private void lklbBackToLogin_linkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnForgotPW.Visible = false;
            pnLogin.Visible = true;
            pnLogin.BringToFront();
        }

        private void pnForgotPW_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnSendCode_ForgotPn_Click(object sender, EventArgs e)
        {
            string email = tbEmailForgot.Text;

            if (db.EmailExists(email))
            {
                // lưu Email đang chờ xác nhận
                currentForgotEmail = email;

                // tạo mã lưu trữ (khi nào có api smtp thì update chỗ này, bây giờ chỉ mô phỏng để đảm bảo logic về bảo mật -> làm cho ngầu th chứ k có tác dụng)
                storedVerificationCode = DataAccess.GenerateVerificationCode();
                // mã hết hạn sau 5 phút
                codeExpirationTime = DateTime.Now.AddMinutes(5);

                MessageBox.Show(
                    $"Mã xác nhận đã được gửi tới: {email}.\n(Mô phỏng: Mã của bạn là: {storedVerificationCode})",
                    "Gửi Mã Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                pnForgotPW.Visible = false;
                pnVerifyCode.Visible = true;
            }
            else
            {
                MessageBox.Show("Email này không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmVC_Click(object sender, EventArgs e)
        {
            string userInputCode = tbVerificationCode.Text;

            // kiểm tra Mã Hết hạn
            if (DateTime.Now > codeExpirationTime)
            {
                MessageBox.Show("Mã xác nhận đã hết hạn. Vui lòng bấm 'Gửi lại mã' để nhận mã mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // kiểm tra Mã Khớp
            if (userInputCode == storedVerificationCode)
            {
                MessageBox.Show("Xác nhận thành công. Vui lòng đặt lại mật khẩu mới.", "Thành công");

                pnVerifyCode.Visible = false;
                pnResetPW.Visible = true;
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_ResetPWPn_Click(object sender, EventArgs e)
        {
            string newPassword = tbNewPW.Text;
            string confirmPassword = tbConfirmNewPW.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mật khẩu mới và Xác nhận Mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp.", "Lỗi");
                return;
            }

            // nhớ cập nhật database
            if (db.UpdatePassword(currentForgotEmail, newPassword)) // Sử dụng Email đã lưu
            {
                MessageBox.Show("Đặt lại mật khẩu thành công! Vui lòng đăng nhập lại.", "Thành công");

                pnResetPW.Visible = false;
                pnLogin.Visible = true;
                pnLogin.BringToFront();
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống: Cập nhật mật khẩu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_SignUpPn_Click(object sender, EventArgs e)
        {
            string username = tbUsernameSignUpPn.Text;
            string email = tbEmailSignUpPn.Text;
            string password = tbPW_SignUpPN.Text; // Mật khẩu
            string confirmPassword = tbConfirmPW.Text; // Xác nhận Mật khẩu

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và Xác nhận Mật khẩu không khớp. Vui lòng nhập lại.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db.RegisterUser(username, email, password))
            {
                MessageBox.Show("Đăng ký thành công! Vui lòng đăng nhập.");
                pnSignUp.Visible = false;
                pnLogin.Visible = true;
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại. Tên người dùng hoặc Email đã tồn tại.", "Lỗi");
            }
        }

        private void btnLoginPnl_Click(object sender, EventArgs e)
        {
            string identifier = tbUsernameOrE.Text; // Tên đăng nhập/Email
            string password = tbPW.Text;            // Mật khẩu

            if (string.IsNullOrEmpty(identifier) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên đăng nhập/Email và Mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int userId = db.CheckLogin(identifier, password);

            if (userId > 0)
            {
                // lấy username từ database
                string loggedInUsername = db.GetUsernameById(userId);

                // kiểm tra phòng trường hợp lỗi DB
                if (loggedInUsername == null)
                {
                    MessageBox.Show("Lỗi hệ thống: Không lấy được tên người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"Đăng nhập thành công! Chào mừng {loggedInUsername}. (UserID: {userId.ToString("D4")})", "Thành công");

                LobbyForm menuForm = new LobbyForm(userId, loggedInUsername);

                this.Hide();
                menuForm.Show();
            }
            else
            {
                MessageBox.Show("the username/email or password is incorrect. please try again", "login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(cbShowPW, tbPW);
        }

        private void lklbResendCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(currentForgotEmail))
            {
                MessageBox.Show("Không tìm thấy yêu cầu đổi mật khẩu. Vui lòng quay lại bước nhập Email.", "Lỗi");
                return;
            }

            // tạo mã mới và đặt timer (tôi bị ngựa)
            storedVerificationCode = DataAccess.GenerateVerificationCode();
            codeExpirationTime = DateTime.Now.AddMinutes(5); 

            MessageBox.Show(
                $"Mã xác nhận mới đã được tạo cho: {currentForgotEmail}.\n(Mô phỏng: Mã mới là: {storedVerificationCode})",
                "Gửi lại Mã Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            tbVerificationCode.Clear();
        }
        private TextBox[] textboxes;

        private void cbShowPW_ResetPW_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(cbShowPW_ResetPW, tbNewPW, tbConfirmNewPW);
        }

        private void TogglePasswordVisibility(CheckBox checkbox, params TextBox[] textboxes)
        {
            char passwordChar = checkbox.Checked ? '\0' : '*';

            foreach (var tb in textboxes)
            {
                tb.PasswordChar = passwordChar;
            }
        }

        private void cbShowPW_SignUp_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordVisibility(cbShowPW_SignUp, tbPW_SignUpPN, tbConfirmPW);
        }

        private void lblEmail_ForgotPWPn_Click(object sender, EventArgs e)
        {

        }

        private void tbNewPW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
