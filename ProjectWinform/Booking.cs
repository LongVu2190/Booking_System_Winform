using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;

namespace ProjectWinform
{
    public partial class Booking : Form
    {
        //PRAGMA journal_mode=WAL;
        public string DBLocation;
        Customer cus = new Customer();
        Movie mov = new Movie();  
        public int Check_SQL_Success = 0;
        public int Check_Choosed_Seats = 0;
        public int Check_Confirm = 0;
        public Booking(string DBLocation, Customer cus)
        {
            this.DBLocation = DBLocation;
            this.cus = cus;
            InitializeComponent();
            this.cus = cus;
        }
        public int ReadDataFromDB(string MOVIE_ID)
        {
            mov.SEATS.Clear();
            mov.SEATS.Add(5); // Bỏ giá trị đầu tiên ở vị trí 0
            // Lấy chỗ ngồi
            using (SQLiteConnection c = new SQLiteConnection(DBLocation))
            {
                c.Open();
                var sql = "SELECT * FROM SEATS";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(0) == mov.MOVIE_ID)
                            {
                                for (int i = 1; i <= 28; i++)
                                {
                                    mov.SEATS.Add(reader.GetInt32(i));
                                }
                                break;
                            }
                        }
                    }
                }
            }
            // Lấy thông tin phim
            using (SQLiteConnection c = new SQLiteConnection(DBLocation))
            {
                c.Open();
                var sql = "SELECT * FROM MOVIES WHERE MOVIE_ID == \""  + MOVIE_ID + "\"";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows == false)
                        {
                            MessageBox.Show("Không có mã phim " + MOVIE_ID, "Thông báo");
                            this.CHOOSE_ID.Text = "";
                            this.CHOOSE_ID.Focus();
                            Check_SQL_Success = 0;
                            return 0;
                        }
                        reader.Read();
                        mov.NAME = reader.GetString(1);
                        mov.TAG = reader.GetString(2);
                        mov.COST = reader.GetInt32(3);
                        mov.START_HOURS = reader.GetInt32(4);
                        mov.START_MINUTES = reader.GetInt32(5);
                        mov.END_HOURS = reader.GetInt32(6);
                        mov.END_MINUTES = reader.GetInt32(7);
                        mov.ROOM = reader.GetInt32(8);
                        mov.DURATION = (mov.END_HOURS * 60 + mov.END_MINUTES) - (mov.START_HOURS * 60 + mov.START_MINUTES);
                        Check_SQL_Success = 1;
                        return 1;
                    }
                }
            }
        }
        public void ChangeMovieLabel()
        {
            this.MOVIE_NAME.Text = mov.NAME;
            this.TAG_NAME.Text = mov.TAG;
            this.MONEY_COST.Text = mov.COST.ToString();
            this.MOVIE_DURATION.Text = mov.DURATION.ToString() + " PHÚT";
            this.MOVIE_INTERVAL.Text = mov.START_HOURS.ToString() + ":" + mov.START_MINUTES + " - " + mov.END_HOURS + ":" + mov.END_MINUTES;
            this.MOVIE_ROOM.Text = mov.ROOM.ToString();
        }
        public void CreateSeatsWidget()
        {
            ChangeMovieLabel();
            int Count = 1;
            int Buttons = 28;
            int X = 0;
            int Y = 0;
            for (int i = 1; i <= Buttons; i++)
            {
                Button b = new Button();
                b.Text = Count.ToString();
                b.Name = Count.ToString();
                b.Size = new Size(50, 50);
                b.Font = new Font("Arial", 12, FontStyle.Bold);
                b.Location = new Point(60 * (X + 1) + 100, 150 + Y);
                switch (mov.SEATS[i])
                {
                    case -1:
                        b.BackColor = Color.DodgerBlue;
                        break;
                    case 0:
                        b.BackColor = Color.LightSlateGray;
                        break;
                    case 1:
                        b.BackColor = Color.IndianRed;
                        break;
                }
                b.ForeColor = Color.White;
                b.Padding = new Padding(0);
                b.Click += new EventHandler(this.SeatClick);
                if (i % 7 == 0)
                {
                    X = -1;
                    Y += 60;
                }
                X++;
                Controls.Add(b);
                Count++;
            }
        }
        public void SeatClick(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Chỗ ngồi " + bt.Name + " đã bị chọn", "Thông báo");
            }
            else if (bt.BackColor == Color.DodgerBlue)
            {
                bt.BackColor = Color.LightSlateGray;
                MessageBox.Show("Hủy chọn chỗ " + bt.Name, "Thông báo");
                mov.SEATS[Convert.ToInt32(bt.Text)] = 0;
            }
            else if (bt.BackColor == Color.ForestGreen)
            {
                bt.BackColor = Color.LightSlateGray;
                MessageBox.Show("Đã hủy chọn chỗ ngồi " + bt.Name, "Thông báo");
                mov.SEATS[Convert.ToInt32(bt.Text)] = 0;
            }
            else
            {
                bt.BackColor = Color.ForestGreen;
                MessageBox.Show("Chọn chỗ ngồi " + bt.Name + " thành công", "Thông báo");
                mov.SEATS[Convert.ToInt32(bt.Text)] = -1;
                Check_Choosed_Seats = 1;
            }
        }
        public void ClearButtonsFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        if (ctrl.Name != "CONFIRM_BUTTON"
                            && ctrl.Name != "TAG_NAME"
                            && ctrl.Name != "MONEY_COST"
                            && ctrl.Name != "MOVIE_DURATION"
                            && ctrl.Name != "MOVIE_INTERVAL"
                            && ctrl.Name != "CHOOSE_ID"
                            && ctrl.Name != "CHOOSE_MOVIE_BUTTON"
                            && ctrl.Name != "MOVIE_ROOM"
                            && ctrl.Name != "BOOK_BUTTON_BUTTON")
                            this.Controls.Remove(ctrl);
                    }
                }
            }
        }
        private void CONFIRM_BUTTON_Click(object sender, EventArgs e)
        {
            if (Check_SQL_Success == 0)
            {
                MessageBox.Show("Chưa có phim được chọn", "Thông báo");
                return;
            }
            Check_Confirm = 1;
            ClearButtonsFunction();
            CreateSeatsWidget();
        }
        private void BOOK_BUTTON_Click(object sender, EventArgs e)
        {
            if (Check_Confirm == 0)
            {
                MessageBox.Show("Hãy kiểm tra trước khi đặt", "Thông báo");
                return;
            }
            if (Check_SQL_Success == 0)
            {
                MessageBox.Show("Chưa có phim được chọn", "Thông báo");
                return;
            }
            if (Check_Choosed_Seats == 0)
            {
                MessageBox.Show("Chưa có chỗ ngồi được chọn", "Thông Báo");
                return;
            }
            //Cập nhật dữ liệu lên database
            for (int i = 1; i <= 28; i++)
            {
                if (mov.SEATS[i] == -1)
                {
                    string temp = "S" + i.ToString();
                    var sql = "UPDATE SEATS SET \"" + temp + "\" = 1 WHERE MOVIE_ID = \"" + mov.MOVIE_ID + "\"";
                    using (SQLiteConnection c = new SQLiteConnection(DBLocation))
                    {
                        c.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    sql = "INSERT INTO BOOKED VALUES ('" + cus.USER + "', '" + mov.MOVIE_ID + "', '" + temp + "', '0' )";
                    using (SQLiteConnection c = new SQLiteConnection(DBLocation))
                    {
                        c.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            MessageBox.Show("Đã chọn ghế thành công, vui lòng thanh toán", "Thông báo");
            ClearButtonsFunction();
            Check_Choosed_Seats = 0;
            Check_Confirm = 0;
            Check_SQL_Success = 0;
        }
        private void CHOOSE_MOVIE_BUTTON_Click(object sender, EventArgs e)
        {
            mov.MOVIE_ID = CHOOSE_ID.Text;
            ClearButtonsFunction();
            // Truy vấn thành công
            if (ReadDataFromDB(mov.MOVIE_ID) == 0) return;
            this.Controls.Remove(this.INTRODUCTION);
            CreateSeatsWidget();
        }
        private void CHOOSE_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                CHOOSE_MOVIE_BUTTON_Click(sender, e);
            }
        }
    }
}