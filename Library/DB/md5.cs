using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Library.DB
{
    internal class md5
    {
        public static string hashPassword(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] bytes = md5.ComputeHash(b);
            StringBuilder sb = new StringBuilder();
            foreach (byte b2 in bytes)
            {
                sb.Append(b2.ToString("X2"));
            }
            return sb.ToString();
        }
        
    }
}
