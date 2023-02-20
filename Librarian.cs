using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Librarian
    {
        public String username;
        public String name;
        public String mail;
        public String phone;
        public bool isAdmin;
        public int id_lib;
        public Librarian(string username,string name,string mail,string phone,string isAdmin,string id_lib)
        {
            this.username = username;
            this.name = name;
            this.mail = mail;
            this.phone = phone;
            this.id_lib = Int32.Parse(id_lib);
            if (isAdmin.Equals("true")) this.isAdmin = true;
            else this.isAdmin = false;
        }
    }
}
