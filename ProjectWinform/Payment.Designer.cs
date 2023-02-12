namespace ProjectWinform
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.USER = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.LOGIN_BANK_BUTTON = new System.Windows.Forms.Button();
            this.PAYMENT_BUTTON = new System.Windows.Forms.Button();
            this.USER_LABEL = new System.Windows.Forms.Label();
            this.USERNAME_LABEL = new System.Windows.Forms.Label();
            this.PHONE_NUMBER_LABEL = new System.Windows.Forms.Label();
            this.BALANCE_LABEL = new System.Windows.Forms.Label();
            this.PAID_MOVIES = new System.Windows.Forms.DataGridView();
            this.NOT_PAID_MOVIES = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PAID_MOVIES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOT_PAID_MOVIES)).BeginInit();
            this.SuspendLayout();
            // 
            // USER
            // 
            this.USER.Font = new System.Drawing.Font("#HLV Ample", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USER.Location = new System.Drawing.Point(447, 307);
            this.USER.Margin = new System.Windows.Forms.Padding(4);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(213, 30);
            this.USER.TabIndex = 12;
            // 
            // PASSWORD
            // 
            this.PASSWORD.Font = new System.Drawing.Font("#HLV Ample", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(447, 378);
            this.PASSWORD.Margin = new System.Windows.Forms.Padding(4);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '*';
            this.PASSWORD.Size = new System.Drawing.Size(213, 30);
            this.PASSWORD.TabIndex = 13;
            this.PASSWORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PASSWORD_KeyDown);
            // 
            // LOGIN_BANK_BUTTON
            // 
            this.LOGIN_BANK_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.LOGIN_BANK_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.LOGIN_BANK_BUTTON.ForeColor = System.Drawing.Color.White;
            this.LOGIN_BANK_BUTTON.Location = new System.Drawing.Point(672, 281);
            this.LOGIN_BANK_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.LOGIN_BANK_BUTTON.Name = "LOGIN_BANK_BUTTON";
            this.LOGIN_BANK_BUTTON.Size = new System.Drawing.Size(139, 59);
            this.LOGIN_BANK_BUTTON.TabIndex = 19;
            this.LOGIN_BANK_BUTTON.Text = "ĐĂNG NHẬP";
            this.LOGIN_BANK_BUTTON.UseVisualStyleBackColor = false;
            this.LOGIN_BANK_BUTTON.Click += new System.EventHandler(this.LOGIN_BANK_BUTTON_Click);
            // 
            // PAYMENT_BUTTON
            // 
            this.PAYMENT_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.PAYMENT_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.PAYMENT_BUTTON.ForeColor = System.Drawing.Color.White;
            this.PAYMENT_BUTTON.Location = new System.Drawing.Point(672, 351);
            this.PAYMENT_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.PAYMENT_BUTTON.Name = "PAYMENT_BUTTON";
            this.PAYMENT_BUTTON.Size = new System.Drawing.Size(139, 59);
            this.PAYMENT_BUTTON.TabIndex = 20;
            this.PAYMENT_BUTTON.Text = "THANH TOÁN";
            this.PAYMENT_BUTTON.UseVisualStyleBackColor = false;
            this.PAYMENT_BUTTON.Click += new System.EventHandler(this.PAYMENT_BUTTON_Click);
            // 
            // USER_LABEL
            // 
            this.USER_LABEL.BackColor = System.Drawing.Color.Transparent;
            this.USER_LABEL.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 15F, System.Drawing.FontStyle.Bold);
            this.USER_LABEL.ForeColor = System.Drawing.Color.White;
            this.USER_LABEL.Location = new System.Drawing.Point(216, 283);
            this.USER_LABEL.Name = "USER_LABEL";
            this.USER_LABEL.Size = new System.Drawing.Size(163, 22);
            this.USER_LABEL.TabIndex = 21;
            // 
            // USERNAME_LABEL
            // 
            this.USERNAME_LABEL.BackColor = System.Drawing.Color.Transparent;
            this.USERNAME_LABEL.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 15F, System.Drawing.FontStyle.Bold);
            this.USERNAME_LABEL.ForeColor = System.Drawing.Color.White;
            this.USERNAME_LABEL.Location = new System.Drawing.Point(216, 317);
            this.USERNAME_LABEL.Name = "USERNAME_LABEL";
            this.USERNAME_LABEL.Size = new System.Drawing.Size(163, 22);
            this.USERNAME_LABEL.TabIndex = 22;
            // 
            // PHONE_NUMBER_LABEL
            // 
            this.PHONE_NUMBER_LABEL.BackColor = System.Drawing.Color.Transparent;
            this.PHONE_NUMBER_LABEL.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 15F, System.Drawing.FontStyle.Bold);
            this.PHONE_NUMBER_LABEL.ForeColor = System.Drawing.Color.White;
            this.PHONE_NUMBER_LABEL.Location = new System.Drawing.Point(216, 352);
            this.PHONE_NUMBER_LABEL.Name = "PHONE_NUMBER_LABEL";
            this.PHONE_NUMBER_LABEL.Size = new System.Drawing.Size(163, 22);
            this.PHONE_NUMBER_LABEL.TabIndex = 23;
            // 
            // BALANCE_LABEL
            // 
            this.BALANCE_LABEL.BackColor = System.Drawing.Color.Transparent;
            this.BALANCE_LABEL.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 15F, System.Drawing.FontStyle.Bold);
            this.BALANCE_LABEL.ForeColor = System.Drawing.Color.White;
            this.BALANCE_LABEL.Location = new System.Drawing.Point(216, 387);
            this.BALANCE_LABEL.Name = "BALANCE_LABEL";
            this.BALANCE_LABEL.Size = new System.Drawing.Size(163, 22);
            this.BALANCE_LABEL.TabIndex = 24;
            // 
            // PAID_MOVIES
            // 
            this.PAID_MOVIES.AllowUserToAddRows = false;
            this.PAID_MOVIES.AllowUserToDeleteRows = false;
            this.PAID_MOVIES.AllowUserToOrderColumns = true;
            this.PAID_MOVIES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PAID_MOVIES.BackgroundColor = System.Drawing.SystemColors.Window;
            this.PAID_MOVIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("#HLV Ample", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PAID_MOVIES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PAID_MOVIES.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("#HLV Ample", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PAID_MOVIES.DefaultCellStyle = dataGridViewCellStyle2;
            this.PAID_MOVIES.GridColor = System.Drawing.Color.RoyalBlue;
            this.PAID_MOVIES.Location = new System.Drawing.Point(22, 52);
            this.PAID_MOVIES.Name = "PAID_MOVIES";
            this.PAID_MOVIES.ReadOnly = true;
            this.PAID_MOVIES.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PAID_MOVIES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("#HLV Ample", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PAID_MOVIES.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PAID_MOVIES.RowTemplate.Height = 30;
            this.PAID_MOVIES.Size = new System.Drawing.Size(388, 215);
            this.PAID_MOVIES.TabIndex = 25;
            this.PAID_MOVIES.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.PAID_MOVIES_RowPostPaint);
            // 
            // NOT_PAID_MOVIES
            // 
            this.NOT_PAID_MOVIES.AllowUserToAddRows = false;
            this.NOT_PAID_MOVIES.AllowUserToDeleteRows = false;
            this.NOT_PAID_MOVIES.AllowUserToOrderColumns = true;
            this.NOT_PAID_MOVIES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NOT_PAID_MOVIES.BackgroundColor = System.Drawing.SystemColors.Window;
            this.NOT_PAID_MOVIES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("#HLV Ample", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NOT_PAID_MOVIES.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.NOT_PAID_MOVIES.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("#HLV Ample", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NOT_PAID_MOVIES.DefaultCellStyle = dataGridViewCellStyle5;
            this.NOT_PAID_MOVIES.GridColor = System.Drawing.Color.RoyalBlue;
            this.NOT_PAID_MOVIES.Location = new System.Drawing.Point(422, 52);
            this.NOT_PAID_MOVIES.Name = "NOT_PAID_MOVIES";
            this.NOT_PAID_MOVIES.ReadOnly = true;
            this.NOT_PAID_MOVIES.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NOT_PAID_MOVIES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("#HLV Ample", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NOT_PAID_MOVIES.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.NOT_PAID_MOVIES.RowTemplate.Height = 30;
            this.NOT_PAID_MOVIES.Size = new System.Drawing.Size(388, 215);
            this.NOT_PAID_MOVIES.TabIndex = 26;
            this.NOT_PAID_MOVIES.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.NOT_PAID_MOVIES_RowPostPaint);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 432);
            this.Controls.Add(this.NOT_PAID_MOVIES);
            this.Controls.Add(this.PAID_MOVIES);
            this.Controls.Add(this.BALANCE_LABEL);
            this.Controls.Add(this.PHONE_NUMBER_LABEL);
            this.Controls.Add(this.USERNAME_LABEL);
            this.Controls.Add(this.USER_LABEL);
            this.Controls.Add(this.PAYMENT_BUTTON);
            this.Controls.Add(this.LOGIN_BANK_BUTTON);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.USER);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "THANH TOÁN";
            ((System.ComponentModel.ISupportInitialize)(this.PAID_MOVIES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOT_PAID_MOVIES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox USER;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Button LOGIN_BANK_BUTTON;
        private System.Windows.Forms.Button PAYMENT_BUTTON;
        private System.Windows.Forms.Label USER_LABEL;
        private System.Windows.Forms.Label USERNAME_LABEL;
        private System.Windows.Forms.Label PHONE_NUMBER_LABEL;
        private System.Windows.Forms.Label BALANCE_LABEL;
        private System.Windows.Forms.DataGridView PAID_MOVIES;
        private System.Windows.Forms.DataGridView NOT_PAID_MOVIES;
    }
}