using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class UserInfo
    {
        private int id;
        private string name;
        private string login;
        private string password;
        private string email;
        private int roleId;

        public int Id { 
            get { return id; } 
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int RoleId
        { get { return roleId; } set {  roleId = value; } }
    }
}
