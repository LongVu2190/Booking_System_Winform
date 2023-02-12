using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWinform
{
    public class Customer
    {
        public string USER;
        public string PASSWORD;
        public string USER_NAME;
        public int AGE;
        public string PHONE_NUMBER;
        public int TOTAL_COST = 0;
        public Customer() { }
        ~Customer() { }
    }
    public class Bank_Account
    {
        public string USER;
        public string PASSWORD;
        public string USER_NAME;
        public string PHONE_NUMBER;
        public int BALANCE = -1;
        public Bank_Account() { }
        ~Bank_Account() { }
    }
    public class Movie
    {
        public string MOVIE_ID { get; set; } = "";
        public string NAME { get; set; } = "";
        public string TAG { get; set; } = "";
        public int COST { get; set; } = 0;
        public int START_HOURS { get; set; } = 0;
        public int START_MINUTES { get; set; } = 0;
        public int END_HOURS { get; set; } = 0;
        public int END_MINUTES { get; set; } = 0;
        public int DURATION { get; set; } = 0;
        public int ROOM { get; set; } = 0;

        public List<int> SEATS = new List<int>();
        public Movie() { }
        ~Movie() { }
    }
    public class Movie_Info
    {
        public string MOVIE_ID { get; set; } = "";
        public string NAME { get; set; } = "";
        public string TAG { get; set; } = "";
        public int COST { get; set; } = 0;
        public Movie_Info() { }
        ~Movie_Info() { }
    }
    public class Movie_Payment
    {
        public string MOVIE_ID { get; set; } = "";
        public string NAME { get; set; } = "";
        public string SEAT { get; set; } = "";
        public int COST { get; set; } = 0;
        public Movie_Payment() { }
        ~Movie_Payment() { }
    }
}
