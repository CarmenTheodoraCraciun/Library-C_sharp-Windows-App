using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Reader
    {
        public String username;
        public String name;
        public String mail;
        public String phone;
        public int id_reader;
        public Reader(String username, String name, String mail, String phone,String id_reader)
        {
            this.username = username;
            this.name = name;
            this.mail = mail;
            this.phone = phone;
            this.id_reader = Int32.Parse(id_reader);
        }
    }
}
