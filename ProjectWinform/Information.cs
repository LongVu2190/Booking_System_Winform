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
    public partial class Information : Form
    {
        public string DBLocation;
        Customer cus = new Customer();
        List<Movie_Info> movies = new List<Movie_Info>();
        public Information(string DBLocation, Customer cus)
        {
            this.DBLocation = DBLocation;
            this.cus = cus;
            InitializeComponent();
            ChangeInformationLabel();
        }
        public void ChangeInformationLabel()
        {
            this.USER_LABEL.Text = cus.USER;
            this.USER_NAME_LABEL.Text = cus.USER_NAME;
            this.AGE_LABEL.Text = cus.AGE.ToString();
            this.PHONE_NUMBER_LABEL.Text = cus.PHONE_NUMBER;
        }
        private void CHOOSE_BUTTON_Click(object sender, EventArgs e)
        {
            Booking form = new Booking(DBLocation, cus);
            form.Show();
        }
        private void TOTAL_COST_Click(object sender, EventArgs e)
        {
            Payment form = new Payment(cus);
            form.Show();           
        }
        public void LoadMoviesFromDB(string tag)
        {
            movies = new List<Movie_Info>();
            if (tag == "ALL")
            {
                using (SQLiteConnection c = new SQLiteConnection(DBLocation))
                {
                    c.Open();
                    var sql = "SELECT * FROM MOVIES ";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Movie_Info mov = new Movie_Info();
                                mov.MOVIE_ID = reader.GetString(0);
                                mov.NAME = reader.GetString(1);
                                mov.TAG = reader.GetString(2);
                                mov.COST = reader.GetInt32(3);
                                movies.Add(mov);
                            }
                        }
                    }
                }
            }
            else
            {
                using (SQLiteConnection c = new SQLiteConnection(DBLocation))
                {
                    c.Open();
                    var sql = "SELECT * FROM MOVIES ";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(2) == tag)
                                {
                                    Movie_Info mov = new Movie_Info();
                                    mov.MOVIE_ID = reader.GetString(0);
                                    mov.NAME = reader.GetString(1);
                                    mov.TAG = reader.GetString(2);
                                    mov.COST = reader.GetInt32(3);
                                    movies.Add(mov);
                                }

                            }
                        }
                    }
                }
            }           
            MOVIES_SHOW.DataSource = movies;
        }
        private void MOVIES_SHOW_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(MOVIES_SHOW.RowHeadersDefaultCellStyle.ForeColor))
            {
                b.Color = Color.Black;
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        private void ALL_BUTTON_Click(object sender, EventArgs e)
        {
            LoadMoviesFromDB("ALL");
        }
        private void ACTION_BUTTON_Click(object sender, EventArgs e)
        {
            LoadMoviesFromDB("HÀNH ĐỘNG");
        }
        private void CARTOON_BUTTON_Click(object sender, EventArgs e)
        {
            LoadMoviesFromDB("HOẠT HÌNH");
        }
        private void HORROR_BUTTON_Click(object sender, EventArgs e)
        {
            LoadMoviesFromDB("KINH DỊ");
        }
        private void ROMANCE_BUTTON_Click(object sender, EventArgs e)
        {
            LoadMoviesFromDB("LÃNG MẠN");
        }
    }
}
