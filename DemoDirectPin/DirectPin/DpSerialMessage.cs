
using System;
using System.Text;

namespace DirectPin
{
    public class DpSerialMessage
    {
        public const byte ACK = 0x06;
        public const byte NAK = 0x15;
        public const byte SYN = 0x16;
        public const byte ETB = 0x17;

        public string PayLoad { get; set; } = string.Empty;

        public string Message => GetMessage();

        public void Clear() => PayLoad = string.Empty;

        public string Checksum(string data)
        {
            ushort crc = Utils.StringCrcCCITT(data);
            return ((char)((crc >> 8) & 0xFF)).ToString() + ((char)(crc & 0xFF)).ToString();
        }

        private string GetMessage()
        {
            string base64 = Utils.ToBase64(PayLoad);
            ushort crc = Utils.StringCrcCCITT(base64);
            byte crcHigh = (byte)((crc >> 8) & 0xFF);
            byte crcLow = (byte)(crc & 0xFF);

            var builder = new StringBuilder();
            builder.Append((char)SYN);
            builder.Append(base64);
            builder.Append((char)crcHigh);
            builder.Append((char)crcLow);
            builder.Append((char)ETB);

            return builder.ToString();
        }

        public void SetMessage(string raw)
        {
            Clear();

            if (string.IsNullOrEmpty(raw) || raw.Length < 5)
                throw new Exception("Invalid message");

            byte[] rawBytes = Encoding.ASCII.GetBytes(raw);

            if (rawBytes[0] != SYN)
                throw new Exception("Message does not start with SYN");

            if (rawBytes[rawBytes.Length - 1] != ETB)
                throw new Exception("Message does not end with ETB");

            int base64Length = rawBytes.Length - 4; // remove SYN, CRC (2 bytes), ETB
            string base64 = Encoding.ASCII.GetString(rawBytes, 1, base64Length);

            ushort crcCalculated = Utils.StringCrcCCITT(base64);
            byte crcHigh = (byte)((crcCalculated >> 8) & 0xFF);
            byte crcLow = (byte)(crcCalculated & 0xFF);

            byte crcReceivedHigh = rawBytes[rawBytes.Length - 3];
            byte crcReceivedLow = rawBytes[rawBytes.Length - 2];

            if (crcHigh != crcReceivedHigh || crcLow != crcReceivedLow)
                throw new Exception("Message with wrong CRC");

            PayLoad = Utils.FromBase64(base64);
        }
    }
}
