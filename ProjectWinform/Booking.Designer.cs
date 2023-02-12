using System.Drawing;

namespace ProjectWinform
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.CHOOSE_ID = new System.Windows.Forms.TextBox();
            this.CONFIRM_BUTTON = new System.Windows.Forms.Button();
            this.MOVIE_NAME = new System.Windows.Forms.Label();
            this.TAG_NAME = new System.Windows.Forms.Label();
            this.MONEY_COST = new System.Windows.Forms.Label();
            this.MOVIE_DURATION = new System.Windows.Forms.Label();
            this.MOVIE_INTERVAL = new System.Windows.Forms.Label();
            this.MOVIE_ROOM = new System.Windows.Forms.Label();
            this.CHOOSE_MOVIE_BUTTON = new System.Windows.Forms.Button();
            this.INTRODUCTION = new System.Windows.Forms.Label();
            this.BOOK_BUTTON_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CHOOSE_ID
            // 
            this.CHOOSE_ID.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHOOSE_ID.Location = new System.Drawing.Point(457, 550);
            this.CHOOSE_ID.Name = "CHOOSE_ID";
            this.CHOOSE_ID.Size = new System.Drawing.Size(118, 28);
            this.CHOOSE_ID.TabIndex = 7;
            this.CHOOSE_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHOOSE_ID_KeyDown);
            // 
            // CONFIRM_BUTTON
            // 
            this.CONFIRM_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.CONFIRM_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.CONFIRM_BUTTON.ForeColor = System.Drawing.Color.White;
            this.CONFIRM_BUTTON.Location = new System.Drawing.Point(18, 546);
            this.CONFIRM_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.CONFIRM_BUTTON.Name = "CONFIRM_BUTTON";
            this.CONFIRM_BUTTON.Size = new System.Drawing.Size(136, 36);
            this.CONFIRM_BUTTON.TabIndex = 0;
            this.CONFIRM_BUTTON.Text = "KIỂM TRA";
            this.CONFIRM_BUTTON.UseVisualStyleBackColor = false;
            this.CONFIRM_BUTTON.Click += new System.EventHandler(this.CONFIRM_BUTTON_Click);
            // 
            // MOVIE_NAME
            // 
            this.MOVIE_NAME.BackColor = System.Drawing.Color.Transparent;
            this.MOVIE_NAME.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.MOVIE_NAME.ForeColor = System.Drawing.Color.White;
            this.MOVIE_NAME.Location = new System.Drawing.Point(128, 456);
            this.MOVIE_NAME.Name = "MOVIE_NAME";
            this.MOVIE_NAME.Size = new System.Drawing.Size(276, 22);
            this.MOVIE_NAME.TabIndex = 1;
            // 
            // TAG_NAME
            // 
            this.TAG_NAME.BackColor = System.Drawing.Color.Transparent;
            this.TAG_NAME.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.TAG_NAME.ForeColor = System.Drawing.Color.White;
            this.TAG_NAME.Location = new System.Drawing.Point(128, 483);
            this.TAG_NAME.Name = "TAG_NAME";
            this.TAG_NAME.Size = new System.Drawing.Size(163, 22);
            this.TAG_NAME.TabIndex = 2;
            // 
            // MONEY_COST
            // 
            this.MONEY_COST.BackColor = System.Drawing.Color.Transparent;
            this.MONEY_COST.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.MONEY_COST.ForeColor = System.Drawing.Color.White;
            this.MONEY_COST.Location = new System.Drawing.Point(128, 509);
            this.MONEY_COST.Name = "MONEY_COST";
            this.MONEY_COST.Size = new System.Drawing.Size(163, 22);
            this.MONEY_COST.TabIndex = 3;
            // 
            // MOVIE_DURATION
            // 
            this.MOVIE_DURATION.BackColor = System.Drawing.Color.Transparent;
            this.MOVIE_DURATION.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.MOVIE_DURATION.ForeColor = System.Drawing.Color.White;
            this.MOVIE_DURATION.Location = new System.Drawing.Point(532, 456);
            this.MOVIE_DURATION.Name = "MOVIE_DURATION";
            this.MOVIE_DURATION.Size = new System.Drawing.Size(163, 22);
            this.MOVIE_DURATION.TabIndex = 4;
            // 
            // MOVIE_INTERVAL
            // 
            this.MOVIE_INTERVAL.BackColor = System.Drawing.Color.Transparent;
            this.MOVIE_INTERVAL.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.MOVIE_INTERVAL.ForeColor = System.Drawing.Color.White;
            this.MOVIE_INTERVAL.Location = new System.Drawing.Point(532, 483);
            this.MOVIE_INTERVAL.Name = "MOVIE_INTERVAL";
            this.MOVIE_INTERVAL.Size = new System.Drawing.Size(163, 22);
            this.MOVIE_INTERVAL.TabIndex = 5;
            // 
            // MOVIE_ROOM
            // 
            this.MOVIE_ROOM.BackColor = System.Drawing.Color.Transparent;
            this.MOVIE_ROOM.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.MOVIE_ROOM.ForeColor = System.Drawing.Color.White;
            this.MOVIE_ROOM.Location = new System.Drawing.Point(532, 509);
            this.MOVIE_ROOM.Name = "MOVIE_ROOM";
            this.MOVIE_ROOM.Size = new System.Drawing.Size(163, 22);
            this.MOVIE_ROOM.TabIndex = 6;
            // 
            // CHOOSE_MOVIE_BUTTON
            // 
            this.CHOOSE_MOVIE_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.CHOOSE_MOVIE_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.CHOOSE_MOVIE_BUTTON.ForeColor = System.Drawing.Color.White;
            this.CHOOSE_MOVIE_BUTTON.Location = new System.Drawing.Point(582, 546);
            this.CHOOSE_MOVIE_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.CHOOSE_MOVIE_BUTTON.Name = "CHOOSE_MOVIE_BUTTON";
            this.CHOOSE_MOVIE_BUTTON.Size = new System.Drawing.Size(136, 36);
            this.CHOOSE_MOVIE_BUTTON.TabIndex = 8;
            this.CHOOSE_MOVIE_BUTTON.Text = "CHỌN PHIM";
            this.CHOOSE_MOVIE_BUTTON.UseVisualStyleBackColor = false;
            this.CHOOSE_MOVIE_BUTTON.Click += new System.EventHandler(this.CHOOSE_MOVIE_BUTTON_Click);
            // 
            // INTRODUCTION
            // 
            this.INTRODUCTION.BackColor = System.Drawing.Color.Transparent;
            this.INTRODUCTION.Font = new System.Drawing.Font("#HLV Baloo Tamma", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTRODUCTION.ForeColor = System.Drawing.Color.White;
            this.INTRODUCTION.Location = new System.Drawing.Point(99, 165);
            this.INTRODUCTION.Name = "INTRODUCTION";
            this.INTRODUCTION.Size = new System.Drawing.Size(536, 138);
            this.INTRODUCTION.TabIndex = 9;
            this.INTRODUCTION.Text = "HELLO BÀ GIÀ NGHÈO KHỔ GIỮA TRỜI ĐÔNG CÔ ĐƠN";
            this.INTRODUCTION.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BOOK_BUTTON_BUTTON
            // 
            this.BOOK_BUTTON_BUTTON.BackColor = System.Drawing.Color.MidnightBlue;
            this.BOOK_BUTTON_BUTTON.Font = new System.Drawing.Font("#HLV AmpleSoft Bold", 13F, System.Drawing.FontStyle.Bold);
            this.BOOK_BUTTON_BUTTON.ForeColor = System.Drawing.Color.White;
            this.BOOK_BUTTON_BUTTON.Location = new System.Drawing.Point(159, 546);
            this.BOOK_BUTTON_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.BOOK_BUTTON_BUTTON.Name = "BOOK_BUTTON_BUTTON";
            this.BOOK_BUTTON_BUTTON.Size = new System.Drawing.Size(136, 36);
            this.BOOK_BUTTON_BUTTON.TabIndex = 10;
            this.BOOK_BUTTON_BUTTON.Text = "ĐẶT";
            this.BOOK_BUTTON_BUTTON.UseVisualStyleBackColor = false;
            this.BOOK_BUTTON_BUTTON.Click += new System.EventHandler(this.BOOK_BUTTON_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(730, 600);
            this.Controls.Add(this.BOOK_BUTTON_BUTTON);
            this.Controls.Add(this.INTRODUCTION);
            this.Controls.Add(this.CHOOSE_MOVIE_BUTTON);
            this.Controls.Add(this.CHOOSE_ID);
            this.Controls.Add(this.MOVIE_ROOM);
            this.Controls.Add(this.MOVIE_INTERVAL);
            this.Controls.Add(this.MOVIE_DURATION);
            this.Controls.Add(this.MONEY_COST);
            this.Controls.Add(this.TAG_NAME);
            this.Controls.Add(this.MOVIE_NAME);
            this.Controls.Add(this.CONFIRM_BUTTON);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN CHỖ NGỒI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox CHOOSE_ID;
        private System.Windows.Forms.Button CONFIRM_BUTTON;
        private System.Windows.Forms.Label MOVIE_NAME;
        private System.Windows.Forms.Label TAG_NAME;
        private System.Windows.Forms.Label MONEY_COST;
        private System.Windows.Forms.Label MOVIE_DURATION;
        private System.Windows.Forms.Label MOVIE_INTERVAL;
        private System.Windows.Forms.Label MOVIE_ROOM;       
        private System.Windows.Forms.Button CHOOSE_MOVIE_BUTTON;
        private System.Windows.Forms.Label INTRODUCTION;
        private System.Windows.Forms.Button BOOK_BUTTON_BUTTON;
    }
}

