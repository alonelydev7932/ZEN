using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEN._0x02
{
    internal class mcyAy
    {
        public static string AppName = AppDomain.CurrentDomain.FriendlyName;

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string UpperReturn = null;

        public static void UpperCase(string Convert)
        {
            UpperReturn = "";

            string str1 = Convert;

            string upperstr1 = str1.ToUpper();

            UpperReturn = upperstr1;
        }
    }
}
