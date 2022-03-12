using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    abstract class User
    {
        private String id;
        private String name;
        private String password;

        public User()
        {
            Id = "";
            Name = name;
            Password = password;
        }

        public User(string id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
