namespace ticTacToe
{
    partial class LobbyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogOut_LobbyForm = new System.Windows.Forms.Button();
            this.pbAvatar_Lobby = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar_Lobby)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut_LobbyForm
            // 
            this.btnLogOut_LobbyForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut_LobbyForm.Location = new System.Drawing.Point(12, 441);
            this.btnLogOut_LobbyForm.Name = "btnLogOut_LobbyForm";
            this.btnLogOut_LobbyForm.Size = new System.Drawing.Size(81, 28);
            this.btnLogOut_LobbyForm.TabIndex = 0;
            this.btnLogOut_LobbyForm.Text = "log out";
            this.btnLogOut_LobbyForm.UseVisualStyleBackColor = true;
            this.btnLogOut_LobbyForm.Click += new System.EventHandler(this.btnLogOut_LobbyForm_Click);
            // 
            // pbAvatar_Lobby
            // 
            this.pbAvatar_Lobby.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbAvatar_Lobby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatar_Lobby.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAvatar_Lobby.Location = new System.Drawing.Point(12, 12);
            this.pbAvatar_Lobby.Name = "pbAvatar_Lobby";
            this.pbAvatar_Lobby.Size = new System.Drawing.Size(96, 96);
            this.pbAvatar_Lobby.TabIndex = 1;
            this.pbAvatar_Lobby.TabStop = false;
            this.pbAvatar_Lobby.Click += new System.EventHandler(this.pbAvatar_Lobby_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "play now";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "play w/ a friend";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(694, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "bot mode";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(696, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "ranking board";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 481);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbAvatar_Lobby);
            this.Controls.Add(this.btnLogOut_LobbyForm);
            this.Name = "LobbyForm";
            this.Text = "LobbyForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar_Lobby)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut_LobbyForm;
        private System.Windows.Forms.PictureBox pbAvatar_Lobby;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}