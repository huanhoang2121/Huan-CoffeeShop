namespace CoffeeShopHue
{
    partial class FrmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.LPassWord = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.LUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 98);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnLogin);
            this.panel4.Controls.Add(this.BtnExit);
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 37);
            this.panel4.TabIndex = 5;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(147, 3);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(119, 30);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(272, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(120, 30);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPassWord);
            this.panel3.Controls.Add(this.LPassWord);
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 37);
            this.panel3.TabIndex = 3;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(131, 0);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(261, 20);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.Text = "123";
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // LPassWord
            // 
            this.LPassWord.AutoSize = true;
            this.LPassWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPassWord.Location = new System.Drawing.Point(3, -1);
            this.LPassWord.Name = "LPassWord";
            this.LPassWord.Size = new System.Drawing.Size(84, 19);
            this.LPassWord.TabIndex = 0;
            this.LPassWord.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.LUserName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 23);
            this.panel2.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(128, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(261, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Admin";
            // 
            // LUserName
            // 
            this.LUserName.AutoSize = true;
            this.LUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUserName.Location = new System.Drawing.Point(0, 0);
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(130, 19);
            this.LUserName.TabIndex = 0;
            this.LUserName.Text = "Tên đăng nhập:";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(422, 122);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label LUserName;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label LPassWord;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panel4;
    }
}