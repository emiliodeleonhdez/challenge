using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public  string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public User(int id, string name, string lastName, string userName, string password, string email)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.userName = userName;
            this.password = password;
            this.email = email;
        }
    }
}
