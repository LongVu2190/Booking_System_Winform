namespace ProjectWinform
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.USER = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.SIGNIN_BUTTON = new System.Windows.Forms.Button();
            this.SIGNUP_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USER
            // 
            this.USER.Font = new System.Drawing.Font("#HLV Ample", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USER.Location = new System.Drawing.Point(403, 43);
            this.USER.Margin = new System.Windows.Forms.Padding(4);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(140, 28);
            this.USER.TabIndex = 0;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Font = new System.Drawing.Font("#HLV Ample", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(403, 107);
            this.PASSWORD.Margin = new System.Windows.Forms.Padding(4);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '*';
            this.PASSWORD.Size = new System.Drawing.Size(140, 28);
            this.PASSWORD.TabIndex = 1;
            this.PASSWORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PASSWORD_KeyDown);
            // 
            // SIGNIN_BUTTON
            // 
            this.SIGNIN_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.SIGNIN_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.SIGNIN_BUTTON.ForeColor = System.Drawing.Color.White;
            this.SIGNIN_BUTTON.Location = new System.Drawing.Point(403, 150);
            this.SIGNIN_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.SIGNIN_BUTTON.Name = "SIGNIN_BUTTON";
            this.SIGNIN_BUTTON.Size = new System.Drawing.Size(140, 36);
            this.SIGNIN_BUTTON.TabIndex = 9;
            this.SIGNIN_BUTTON.Text = "ĐĂNG NHẬP";
            this.SIGNIN_BUTTON.UseVisualStyleBackColor = false;
            this.SIGNIN_BUTTON.Click += new System.EventHandler(this.SIGNIN_BUTTON_Click);
            // 
            // SIGNUP_BUTTON
            // 
            this.SIGNUP_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.SIGNUP_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.SIGNUP_BUTTON.ForeColor = System.Drawing.Color.White;
            this.SIGNUP_BUTTON.Location = new System.Drawing.Point(402, 192);
            this.SIGNUP_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.SIGNUP_BUTTON.Name = "SIGNUP_BUTTON";
            this.SIGNUP_BUTTON.Size = new System.Drawing.Size(141, 36);
            this.SIGNUP_BUTTON.TabIndex = 10;
            this.SIGNUP_BUTTON.Text = "ĐĂNG KÍ";
            this.SIGNUP_BUTTON.UseVisualStyleBackColor = false;
            this.SIGNUP_BUTTON.Click += new System.EventHandler(this.SIGNUP_BUTTON_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.SIGNUP_BUTTON);
            this.Controls.Add(this.SIGNIN_BUTTON);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.USER);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐẶT VÉ XEM PHIM by HLV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox USER;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Button SIGNIN_BUTTON;
        private System.Windows.Forms.Button SIGNUP_BUTTON;
    }
}