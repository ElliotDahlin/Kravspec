using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kravspec
{
    internal class Kravspecloginresgister
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Kravspecloginresgister(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
           

        }




    }
}
