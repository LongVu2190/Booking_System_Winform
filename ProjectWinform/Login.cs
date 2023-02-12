using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectWinform
{
    public partial class Login : Form
    {
        private string DBLocation = "Data Source=BookingSystem.db";

        public Login()
        {
            InitializeComponent();
        }
        private void SIGNIN_BUTTON_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.USER = this.USER.Text;
            cus.PASSWORD = this.PASSWORD.Text;
            using (SQLiteConnection c = new SQLiteConnection(DBLocation))
            {
                c.Open();
                var sql = "SELECT * FROM CUSTOMERS";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(0) == cus.USER)
                            {
                                if (reader.GetString(1) == cus.PASSWORD)
                                {
                                    cus.USER_NAME = reader.GetString(2);
                                    cus.AGE = reader.GetInt32(3);
                                    cus.PHONE_NUMBER = reader.GetString(4);
                                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                                    base.Hide();
                                    Information form = new Information(DBLocation, cus);
                                    form.ShowDialog();
                                    base.Close();
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
        private void SIGNUP_BUTTON_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp(DBLocation);
            form.ShowDialog();
        }
        private void PASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                SIGNIN_BUTTON_Click(sender, e);
            }
        }
    }
}
