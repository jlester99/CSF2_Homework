using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {//fields
        private string _username;
        private string _password;

        //properties
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }//end Username

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }//end Password

        //constructors
        //FQ
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }//end FQ ctor

        public Login() { } //default

        //methods

        public override string ToString()
        {
            {
                return string.Format($"User Name: {Username}\n" +
                                 $"Password: {Password}\n");
            }//end return
        }//end override

    }//end class
}//end namespace
