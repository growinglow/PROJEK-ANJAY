using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_ANJAY.Models
{
    public class User
    {
        private int _id;
        private string _username;
        private string _password;
        private string _email;
        private string _notelp;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Notelp
        {
            get { return _notelp; }
            set { _notelp = value; }
        }
    }
}
