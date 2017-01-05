using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.DTO
{
    public class User
    {
        public User(int userId, string mail, string type, string fullname, string phone)
        {
            this.UserId = userId;
            this.Mail = mail;
            this.Type = type;
            this.Fullname = fullname;
            this.Phone = phone;
        }

        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string fullname;
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
