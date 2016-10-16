using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public class MD5Helper
    {
        public static string GetMD5(string txt)
        {

            MD5 md5 = MD5.Create();

            byte[] bs1 = Encoding.UTF8.GetBytes(txt);
            byte[] bs2 = md5.ComputeHash(bs1);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bs2.Length; i++)
            {
                sb.Append(bs2[i].ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}
