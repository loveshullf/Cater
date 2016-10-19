using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public class MD5Helper
    {
        public static string GetMD5(string txt)
        {
            var md5 = MD5.Create();

            var bs1 = Encoding.UTF8.GetBytes(txt);
            var bs2 = md5.ComputeHash(bs1);

            var sb = new StringBuilder();
            for (var i = 0; i < bs2.Length; i++)
                sb.Append(bs2[i].ToString("x2").ToLower());
            return sb.ToString();
        }
    }
}