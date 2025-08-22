using System;
using System.Text;

namespace DirectPin
{
    public static class Utils
    {
        public static ushort StringCrcCCITT(string s, ushort initial = 0, ushort polynomial = 0x1021)
        {
            if (string.IsNullOrEmpty(s)) return initial;
            ushort crc = initial;
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            foreach (byte b in bytes)
            {
                crc ^= (ushort)(b << 8);
                for (int i = 0; i < 8; i++)
                {
                    if ((crc & 0x8000) != 0)
                        crc = (ushort)((crc << 1) ^ polynomial);
                    else
                        crc <<= 1;
                }
            }
            return crc;
        }

        public static string ToHex(ushort value) => value.ToString("X4");

        public static string ToBase64(string json) => Convert.ToBase64String(Encoding.UTF8.GetBytes(json));
        public static string FromBase64(string base64) => Encoding.UTF8.GetString(Convert.FromBase64String(base64));
    }
}
