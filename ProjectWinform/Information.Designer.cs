namespace ProjectWinform
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.USER_NAME_LABEL = new System.Windows.Forms.Label();
            this.USER_LABEL = new System.Windows.Forms.Label();
            this.AGE_LABEL = new System.Windows.Forms.Label();
            this.PHONE_NUMBER_LABEL = new System.Windows.Forms.Label();
            this.CHOOSE_BUTTON = new System.Windows.Forms.Button();
            this.TOTAL_COST = new System.Windows.Forms.Button();
            this.MOVIES_SHOW = new System.Windows.Forms.DataGridView();
            this.ALL_BUTTON = new System.Windows.Forms.Button();
            this.ACTION_BUTTON = new System.Windows.Forms.Button();
            this.CARTOON_BUTTON = new System.Windows.Forms.Button();
            this.HORROR_BUTTON = new System.Windows.Forms.Button();
            this.ROMANCE_BUTTON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MOVIES_SHOW)).BeginInit();
            this.SuspendLayout();
            // 
            // USER_NAME_LABEL
            // 
            this.USER_NAME_LABEL.BackColor = System.Drawing.Color.Transparent;
            this.USER_NAME_LABEL.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 15F, System.Drawing.FontStyle.Bold);
            this.USER_NAME_LABEL.ForeColor = System.Drawing.Color.White;
            this.USER_NAME_LABEL.Location = new System.Drawing.Point(183, 125);
            this.USER_NAME_LABEL.Name = "USER_NAME_LABEL";
            this.USER_NAME_LABEL.Size = new System.Drawing.Size(163, 22);
            this.USER_NAME_LABEL.TabIndex = 5;
            this.USER_NAME_LABEL.Text = "TÊN KHÁCH HÀNG";
            // 
            // USER_LABEL
            // 
            this.USER_LABEL.BackColor = System.Drawing.Color.Transparent;
            this.USER_LABEL.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 15F, System.Drawing.FontStyle.Bold);
            this.USER_LABEL.ForeColor = System.Drawing.Color.White;
            this.USER_LABEL.Location = new System.Drawing.Point(183, 90);
            this.USER_LABEL.Name = "USER_LABEL";
            this.USER_LABEL.Size = new System.Drawing.Size(163, 22);
            this.USER_LABEL.TabIndex = 6;
            this.USER_LABEL.Text = "TÀI KHOẢN";
            // 
            // AGE_LABEL
            // 
            this.AGE_LABEL.BackColor = System.Drawing.Color.Transparent;
            this.AGE_LABEL.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 15F, System.Drawing.FontStyle.Bold);
            this.AGE_LABEL.ForeColor = System.Drawing.Color.White;
            this.AGE_LABEL.Location = new System.Drawing.Point(183, 163);
            this.AGE_LABEL.Name = "AGE_LABEL";
            this.AGE_LABEL.Size = new System.Drawing.Size(163, 22);
            this.AGE_LABEL.TabIndex = 7;
            this.AGE_LABEL.Text = "TUỔI";
            // 
            // PHONE_NUMBER_LABEL
            // 
            this.PHONE_NUMBER_LABEL.BackColor = System.Drawing.Color.Transparent;
            this.PHONE_NUMBER_LABEL.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 15F, System.Drawing.FontStyle.Bold);
            this.PHONE_NUMBER_LABEL.ForeColor = System.Drawing.Color.White;
            this.PHONE_NUMBER_LABEL.Location = new System.Drawing.Point(183, 200);
            this.PHONE_NUMBER_LABEL.Name = "PHONE_NUMBER_LABEL";
            this.PHONE_NUMBER_LABEL.Size = new System.Drawing.Size(163, 22);
            this.PHONE_NUMBER_LABEL.TabIndex = 8;
            this.PHONE_NUMBER_LABEL.Text = "SỐ ĐIỆN THOẠI";
            // 
            // CHOOSE_BUTTON
            // 
            this.CHOOSE_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.CHOOSE_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHOOSE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.CHOOSE_BUTTON.Location = new System.Drawing.Point(187, 256);
            this.CHOOSE_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.CHOOSE_BUTTON.Name = "CHOOSE_BUTTON";
            this.CHOOSE_BUTTON.Size = new System.Drawing.Size(136, 81);
            this.CHOOSE_BUTTON.TabIndex = 10;
            this.CHOOSE_BUTTON.Text = "CHỌN\r\nPHIM";
            this.CHOOSE_BUTTON.UseVisualStyleBackColor = false;
            this.CHOOSE_BUTTON.Click += new System.EventHandler(this.CHOOSE_BUTTON_Click);
            // 
            // TOTAL_COST
            // 
            this.TOTAL_COST.BackColor = System.Drawing.Color.MidnightBlue;
            this.TOTAL_COST.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOTAL_COST.ForeColor = System.Drawing.Color.White;
            this.TOTAL_COST.Location = new System.Drawing.Point(31, 256);
            this.TOTAL_COST.Margin = new System.Windows.Forms.Padding(0);
            this.TOTAL_COST.Name = "TOTAL_COST";
            this.TOTAL_COST.Size = new System.Drawing.Size(136, 81);
            this.TOTAL_COST.TabIndex = 11;
            this.TOTAL_COST.Text = "THANH\r\nTOÁN";
            this.TOTAL_COST.UseVisualStyleBackColor = false;
            this.TOTAL_COST.Click += new System.EventHandler(this.TOTAL_COST_Click);
            // 
            // MOVIES_SHOW
            // 
            this.MOVIES_SHOW.AllowUserToAddRows = false;
            this.MOVIES_SHOW.AllowUserToDeleteRows = false;
            this.MOVIES_SHOW.AllowUserToOrderColumns = true;
            this.MOVIES_SHOW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MOVIES_SHOW.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MOVIES_SHOW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("#HLV Ample", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MOVIES_SHOW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MOVIES_SHOW.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("#HLV Ample", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MOVIES_SHOW.DefaultCellStyle = dataGridViewCellStyle2;
            this.MOVIES_SHOW.GridColor = System.Drawing.Color.RoyalBlue;
            this.MOVIES_SHOW.Location = new System.Drawing.Point(369, 65);
            this.MOVIES_SHOW.Name = "MOVIES_SHOW";
            this.MOVIES_SHOW.ReadOnly = true;
            this.MOVIES_SHOW.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MOVIES_SHOW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("#HLV Ample", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MOVIES_SHOW.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MOVIES_SHOW.RowTemplate.Height = 30;
            this.MOVIES_SHOW.Size = new System.Drawing.Size(650, 300);
            this.MOVIES_SHOW.TabIndex = 12;
            this.MOVIES_SHOW.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.MOVIES_SHOW_RowPostPaint);
            // 
            // ALL_BUTTON
            // 
            this.ALL_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.ALL_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.ALL_BUTTON.ForeColor = System.Drawing.Color.White;
            this.ALL_BUTTON.Location = new System.Drawing.Point(369, 14);
            this.ALL_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.ALL_BUTTON.Name = "ALL_BUTTON";
            this.ALL_BUTTON.Size = new System.Drawing.Size(123, 36);
            this.ALL_BUTTON.TabIndex = 16;
            this.ALL_BUTTON.Text = "TẤT CẢ";
            this.ALL_BUTTON.UseVisualStyleBackColor = false;
            this.ALL_BUTTON.Click += new System.EventHandler(this.ALL_BUTTON_Click);
            // 
            // ACTION_BUTTON
            // 
            this.ACTION_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.ACTION_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.ACTION_BUTTON.ForeColor = System.Drawing.Color.White;
            this.ACTION_BUTTON.Location = new System.Drawing.Point(502, 14);
            this.ACTION_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.ACTION_BUTTON.Name = "ACTION_BUTTON";
            this.ACTION_BUTTON.Size = new System.Drawing.Size(123, 36);
            this.ACTION_BUTTON.TabIndex = 17;
            this.ACTION_BUTTON.Text = "HÀNH ĐỘNG";
            this.ACTION_BUTTON.UseVisualStyleBackColor = false;
            this.ACTION_BUTTON.Click += new System.EventHandler(this.ACTION_BUTTON_Click);
            // 
            // CARTOON_BUTTON
            // 
            this.CARTOON_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.CARTOON_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.CARTOON_BUTTON.ForeColor = System.Drawing.Color.White;
            this.CARTOON_BUTTON.Location = new System.Drawing.Point(635, 14);
            this.CARTOON_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.CARTOON_BUTTON.Name = "CARTOON_BUTTON";
            this.CARTOON_BUTTON.Size = new System.Drawing.Size(123, 36);
            this.CARTOON_BUTTON.TabIndex = 18;
            this.CARTOON_BUTTON.Text = "HOẠT HÌNH";
            this.CARTOON_BUTTON.UseVisualStyleBackColor = false;
            this.CARTOON_BUTTON.Click += new System.EventHandler(this.CARTOON_BUTTON_Click);
            // 
            // HORROR_BUTTON
            // 
            this.HORROR_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.HORROR_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.HORROR_BUTTON.ForeColor = System.Drawing.Color.White;
            this.HORROR_BUTTON.Location = new System.Drawing.Point(766, 14);
            this.HORROR_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.HORROR_BUTTON.Name = "HORROR_BUTTON";
            this.HORROR_BUTTON.Size = new System.Drawing.Size(123, 36);
            this.HORROR_BUTTON.TabIndex = 19;
            this.HORROR_BUTTON.Text = "KINH DỊ";
            this.HORROR_BUTTON.UseVisualStyleBackColor = false;
            this.HORROR_BUTTON.Click += new System.EventHandler(this.HORROR_BUTTON_Click);
            // 
            // ROMANCE_BUTTON
            // 
            this.ROMANCE_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.ROMANCE_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.ROMANCE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.ROMANCE_BUTTON.Location = new System.Drawing.Point(896, 14);
            this.ROMANCE_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.ROMANCE_BUTTON.Name = "ROMANCE_BUTTON";
            this.ROMANCE_BUTTON.Size = new System.Drawing.Size(123, 36);
            this.ROMANCE_BUTTON.TabIndex = 20;
            this.ROMANCE_BUTTON.Text = "LÃNG MẠN";
            this.ROMANCE_BUTTON.UseVisualStyleBackColor = false;
            this.ROMANCE_BUTTON.Click += new System.EventHandler(this.ROMANCE_BUTTON_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1034, 381);
            this.Controls.Add(this.ROMANCE_BUTTON);
            this.Controls.Add(this.HORROR_BUTTON);
            this.Controls.Add(this.CARTOON_BUTTON);
            this.Controls.Add(this.ACTION_BUTTON);
            this.Controls.Add(this.ALL_BUTTON);
            this.Controls.Add(this.MOVIES_SHOW);
            this.Controls.Add(this.TOTAL_COST);
            this.Controls.Add(this.CHOOSE_BUTTON);
            this.Controls.Add(this.PHONE_NUMBER_LABEL);
            this.Controls.Add(this.AGE_LABEL);
            this.Controls.Add(this.USER_LABEL);
            this.Controls.Add(this.USER_NAME_LABEL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN PHIM";
            ((System.ComponentModel.ISupportInitialize)(this.MOVIES_SHOW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
        private System.Windows.Forms.Label USER_NAME_LABEL;
        private System.Windows.Forms.Label USER_LABEL;
        private System.Windows.Forms.Label AGE_LABEL;
        private System.Windows.Forms.Label PHONE_NUMBER_LABEL;
        private System.Windows.Forms.Button CHOOSE_BUTTON;
        private System.Windows.Forms.Button TOTAL_COST;
        private System.Windows.Forms.DataGridView MOVIES_SHOW;
        private System.Windows.Forms.Button ALL_BUTTON;
        private System.Windows.Forms.Button ACTION_BUTTON;
        private System.Windows.Forms.Button CARTOON_BUTTON;
        private System.Windows.Forms.Button HORROR_BUTTON;
        private System.Windows.Forms.Button ROMANCE_BUTTON;
    }
}