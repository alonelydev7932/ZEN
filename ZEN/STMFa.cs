using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEN
{
    internal class STMFa
    {
        public static string Locatoion = "C:\\ProgramData\\Zen";

        public static string Username = "";
        public static string Password = "";
        public static string Theme = "Dark";

        public static void Load()
        {
            try
            {
                string[] empty = File.ReadAllLines(Locatoion);

                if (empty.Length == 0)
                {
                    return;
                }

                string line0 = File.ReadLines(Locatoion).Skip(0).First(); // Username
                string line1 = File.ReadLines(Locatoion).Skip(1).First(); // Password
                string line2 = File.ReadLines(Locatoion).Skip(2).First(); // Theme

                Username = _0x02.ciPOk.Decode(line0);
                Password = _0x02.ciPOk.Decode(line1);
                Theme = _0x02.ciPOk.Decode(line2);
            }
            catch
            {
                Save();
            }
        }

        public static void Save()
        {
            StreamWriter file = new StreamWriter(Locatoion);

            file.WriteLine(_0x02.ciPOk.Encode(Username));
            file.WriteLine(_0x02.ciPOk.Encode(Password));
            file.WriteLine(_0x02.ciPOk.Encode(Theme));

            file.Close();
        }
    }
}
