using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System
{
    class Admin : User
    {
        public Admin()
        {
            base.Id = "A0001";
            base.Name = "Team";
            base.Password = "1234";
        }
    }
}
