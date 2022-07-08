using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEN._0x02
{
    internal class ciPOk
    {
        public static string Decode(string coded)
        {
            if (coded == String.Empty)
                return String.Empty;

            var bytes = Convert.FromBase64String(coded);
            var text = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            return text;
        }

        public static string Encode(string text)
        {
            if (text == String.Empty)
                return String.Empty;

            byte[] byteslog = Encoding.UTF8.GetBytes(text);
            string base64log = Convert.ToBase64String(byteslog);
            return base64log;
        }
    }
}
