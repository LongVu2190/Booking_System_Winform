namespace ProjectWinform
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.USER = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.PASSWORD_AGAIN = new System.Windows.Forms.TextBox();
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.AGE = new System.Windows.Forms.TextBox();
            this.PHONE_NUMBER = new System.Windows.Forms.TextBox();
            this.SIGNUP_BUTTON = new System.Windows.Forms.Button();
            this.OUT_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USER
            // 
            this.USER.Font = new System.Drawing.Font("#HLV Ample", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USER.Location = new System.Drawing.Point(206, 20);
            this.USER.Margin = new System.Windows.Forms.Padding(4);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(213, 30);
            this.USER.TabIndex = 11;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Font = new System.Drawing.Font("#HLV Ample", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(206, 67);
            this.PASSWORD.Margin = new System.Windows.Forms.Padding(4);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '*';
            this.PASSWORD.Size = new System.Drawing.Size(213, 30);
            this.PASSWORD.TabIndex = 12;
            // 
            // PASSWORD_AGAIN
            // 
            this.PASSWORD_AGAIN.Font = new System.Drawing.Font("#HLV Ample", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD_AGAIN.Location = new System.Drawing.Point(206, 115);
            this.PASSWORD_AGAIN.Margin = new System.Windows.Forms.Padding(4);
            this.PASSWORD_AGAIN.Name = "PASSWORD_AGAIN";
            this.PASSWORD_AGAIN.PasswordChar = '*';
            this.PASSWORD_AGAIN.Size = new System.Drawing.Size(213, 30);
            this.PASSWORD_AGAIN.TabIndex = 13;
            // 
            // USERNAME
            // 
            this.USERNAME.Font = new System.Drawing.Font("#HLV Ample", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.Location = new System.Drawing.Point(206, 164);
            this.USERNAME.Margin = new System.Windows.Forms.Padding(4);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(213, 30);
            this.USERNAME.TabIndex = 14;
            // 
            // AGE
            // 
            this.AGE.Font = new System.Drawing.Font("#HLV Ample", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGE.Location = new System.Drawing.Point(206, 213);
            this.AGE.Margin = new System.Windows.Forms.Padding(4);
            this.AGE.Name = "AGE";
            this.AGE.Size = new System.Drawing.Size(213, 30);
            this.AGE.TabIndex = 15;
            // 
            // PHONE_NUMBER
            // 
            this.PHONE_NUMBER.Font = new System.Drawing.Font("#HLV Ample", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHONE_NUMBER.Location = new System.Drawing.Point(206, 261);
            this.PHONE_NUMBER.Margin = new System.Windows.Forms.Padding(4);
            this.PHONE_NUMBER.Name = "PHONE_NUMBER";
            this.PHONE_NUMBER.Size = new System.Drawing.Size(213, 30);
            this.PHONE_NUMBER.TabIndex = 16;
            this.PHONE_NUMBER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PHONE_NUMBER_KeyDown);
            // 
            // SIGNUP_BUTTON
            // 
            this.SIGNUP_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.SIGNUP_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.SIGNUP_BUTTON.ForeColor = System.Drawing.Color.White;
            this.SIGNUP_BUTTON.Location = new System.Drawing.Point(267, 316);
            this.SIGNUP_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.SIGNUP_BUTTON.Name = "SIGNUP_BUTTON";
            this.SIGNUP_BUTTON.Size = new System.Drawing.Size(139, 59);
            this.SIGNUP_BUTTON.TabIndex = 17;
            this.SIGNUP_BUTTON.Text = "ĐĂNG KÍ";
            this.SIGNUP_BUTTON.UseVisualStyleBackColor = false;
            this.SIGNUP_BUTTON.Click += new System.EventHandler(this.SIGNUP_BUTTON_Click);
            // 
            // OUT_BUTTON
            // 
            this.OUT_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.OUT_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.OUT_BUTTON.ForeColor = System.Drawing.Color.White;
            this.OUT_BUTTON.Location = new System.Drawing.Point(44, 316);
            this.OUT_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.OUT_BUTTON.Name = "OUT_BUTTON";
            this.OUT_BUTTON.Size = new System.Drawing.Size(139, 59);
            this.OUT_BUTTON.TabIndex = 18;
            this.OUT_BUTTON.Text = "THOÁT";
            this.OUT_BUTTON.UseVisualStyleBackColor = false;
            this.OUT_BUTTON.Click += new System.EventHandler(this.OUT_BUTTON_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.OUT_BUTTON);
            this.Controls.Add(this.SIGNUP_BUTTON);
            this.Controls.Add(this.PHONE_NUMBER);
            this.Controls.Add(this.AGE);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.PASSWORD_AGAIN);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.USER);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÍ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox USER;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.TextBox PASSWORD_AGAIN;
        private System.Windows.Forms.TextBox USERNAME;
        private System.Windows.Forms.TextBox AGE;
        private System.Windows.Forms.TextBox PHONE_NUMBER;
        private System.Windows.Forms.Button SIGNUP_BUTTON;
        private System.Windows.Forms.Button OUT_BUTTON;
    }
}