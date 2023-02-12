using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProjectWinform
{
    public partial class Payment : Form
    {
        string DBLocation = "Data source=BookingSystem.db";
        Bank_Account bank = new Bank_Account();
        Customer cus = new Customer();
        List<Movie_Payment> paid_movies = new List<Movie_Payment>();
        List<Movie_Payment> notpaid_movies = new List<Movie_Payment>();
        public Payment(Customer cus)
        {
            this.cus = cus;
            InitializeComponent();
            Load_PaymentStatus();
        }
        public void Load_PaymentStatus()
        {
            using (SQLiteConnection c = new SQLiteConnection(DBLocation))
            {
                c.Open();
                var sql = "SELECT BOOKED.USER, BOOKED.MOVIE_ID, MOVIES.NAME, BOOKED.SEAT, MOVIES.COST, BOOKED.PAYMENT_STATUS" +
                    " FROM BOOKED, MOVIES" +
                    " WHERE BOOKED.MOVIE_ID == MOVIES.MOVIE_ID AND BOOKED.USER == " + "\"" + cus.USER + "\"";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(5) == 0)
                            {
                                Movie_Payment mov = new Movie_Payment();
                                mov.MOVIE_ID = reader.GetString(1);
                                mov.NAME = reader.GetString(2);
                                mov.SEAT = reader.GetString(3);
                                mov.COST = reader.GetInt32(4);
                                notpaid_movies.Add(mov);
                            }
                            else
                            {
                                Movie_Payment mov = new Movie_Payment();
                                mov.MOVIE_ID = reader.GetString(1);
                                mov.NAME = reader.GetString(2);
                                mov.SEAT = reader.GetString(3);
                                mov.COST = reader.GetInt32(4);
                                paid_movies.Add(mov);
                            }
                        }
                    }
                }
            }
            PAID_MOVIES.DataSource = paid_movies;
            NOT_PAID_MOVIES.DataSource = notpaid_movies;
        }
        private void LOGIN_BANK_BUTTON_Click(object sender, EventArgs e)
        {
            bank.USER = this.USER.Text;
            bank.PASSWORD = this.PASSWORD.Text;
            using (SQLiteConnection c = new SQLiteConnection(DBLocation))
            {
                c.Open();
                var sql = "SELECT * FROM BANK_ACCOUNTS";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(0) == bank.USER)
                            {
                                if (reader.GetString(1) == bank.PASSWORD)
                                {
                                    bank.USER_NAME = reader.GetString(2);
                                    bank.PHONE_NUMBER = reader.GetString(3);
                                    bank.BALANCE = reader.GetInt32(4);
                                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                                    Change_Label_Status();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Sai mật khẩu", "Thông báo");
                                    this.PASSWORD.Clear();
                                    this.PASSWORD.Focus();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Tài khoản không tồn tại", "Thông báo");
            return;
        }
        public void Change_Label_Status()
        {
            USER_LABEL.Text = bank.USER;
            USERNAME_LABEL.Text = bank.USER_NAME;
            PHONE_NUMBER_LABEL.Text = bank.PHONE_NUMBER;
            BALANCE_LABEL.Text = bank.BALANCE.ToString() + " VND";
        }
        private void PAYMENT_BUTTON_Click(object sender, EventArgs e)
        {
            cus.TOTAL_COST = 0;
            var sql = "";
            using (SQLiteConnection c = new SQLiteConnection(DBLocation))
            {
                c.Open();
                sql = "SELECT BOOKED.USER, MOVIES.COST " +
                      "FROM BOOKED, MOVIES " +
                      "WHERE BOOKED.MOVIE_ID = MOVIES.MOVIE_ID " +
                      "AND BOOKED.USER == \"" + cus.USER + "\"" +
                      "AND PAYMENT_STATUS == 0";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cus.TOTAL_COST += reader.GetInt32(1);
                        }
                    }
                }
            }
            if (bank.BALANCE == -1)
            {
                MessageBox.Show("Chưa đăng nhập tài khoản ngân hàng", "Thông báo");
                return;
            }
            if (bank.BALANCE < cus.TOTAL_COST)
            {
                MessageBox.Show("Tài khoản không đủ tiền", "Thông báo");
                return;
            }
            
            sql = "UPDATE BOOKED SET \"PAYMENT_STATUS\"= 1 WHERE USER = \"" + cus.USER + "\"";
            using (SQLiteConnection c = new SQLiteConnection(DBLocation))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            if (cus.TOTAL_COST == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế", "Thông báo");
                return;
            }
            Update_BankAccount();
            MessageBox.Show("Đã thanh toán " + cus.TOTAL_COST + " VND", "Thông báo");
            PAID_MOVIES.DataSource = null;
            NOT_PAID_MOVIES.DataSource = null;
        }
        public void Update_BankAccount()
        {
            Load_PaymentStatus();
            int balance = bank.BALANCE - cus.TOTAL_COST;
            bank.BALANCE = balance;
            this.BALANCE_LABEL.Text = balance.ToString() + " VND";
            var sql = "UPDATE BANK_ACCOUNTS SET BALANCE = " + balance + " WHERE USER = \"" + bank.USER + "\"";
            using (SQLiteConnection c = new SQLiteConnection(DBLocation))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void PASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LOGIN_BANK_BUTTON_Click(sender, e);
            }
        }
        private void PAID_MOVIES_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(PAID_MOVIES.RowHeadersDefaultCellStyle.ForeColor))
            {
                b.Color = Color.Black;
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        private void NOT_PAID_MOVIES_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(NOT_PAID_MOVIES.RowHeadersDefaultCellStyle.ForeColor))
            {
                b.Color = Color.Black;
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
