using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kravspec
{
    internal class Krav
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Krav(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
           

        }

        public Krav(string username, string password)
        {
            Username = username;
            Password = password;
        }




    }
}
