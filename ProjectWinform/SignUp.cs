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

namespace ProjectWinform
{
    public partial class SignUp : Form
    {
        private string DBLocation;

        public SignUp(string DBLocation)
        {
            this.DBLocation = DBLocation;
            InitializeComponent();
        }
        private void SIGNUP_BUTTON_Click(object sender, EventArgs e)
        {
            if (this.USER.Text == "" ||
                this.PASSWORD.Text == "" ||
                this.PASSWORD_AGAIN.Text == "" ||
                this.USERNAME.Text == "" ||
                this.AGE.Text == "" ||
                this.PHONE_NUMBER.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo");
                return;
            }
            if (PASSWORD_AGAIN.Text != PASSWORD.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo");
                this.PASSWORD.Clear();
                this.PASSWORD_AGAIN.Clear();
                this.PASSWORD.Focus();
                return;
            }
            // Kiểm tra đã tồn tại tài khoản chưa
            using (SQLiteConnection c = new SQLiteConnection(DBLocation))
            {
                var sql = "SELECT USER FROM CUSTOMERS";
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(0) == this.USER.Text)
                            {
                                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                                return;
                            }
                        }
                    }
                }
            }
            // Tạo tài khoản
            using (SQLiteConnection c = new SQLiteConnection(DBLocation))
            {
                c.Open();
                var sql = "INSERT INTO CUSTOMERS VALUES('" +
                this.USER.Text + "', '" +
                this.PASSWORD.Text + "', '" +
                this.USERNAME.Text + "', " +
                Convert.ToInt32(this.AGE.Text) + ", '" +
                this.PHONE_NUMBER.Text +
                "')";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Tạo tài khoản thành công", "Thông báo");
            base.Close();
        }
        private void OUT_BUTTON_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        private void PHONE_NUMBER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                SIGNUP_BUTTON_Click(sender, e);
            }
        }
    }
}
