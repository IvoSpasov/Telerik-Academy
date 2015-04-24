using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sha1HashAlgoritm
{
    public class Sha1Hash
    {
        static void Main()
        {
            string name = "ivo";
            string nameHashed = Sha1HashStringForUtf8String(name);
            Console.WriteLine(nameHashed);

            string name2 = "ivo";
            string nameHashed2 = Sha1HashStringForUtf8String(name2);
            Console.WriteLine(nameHashed2);
        }

        /// <summary>
        /// Compute hash for string encoded as UTF8
        /// </summary>
        /// <param name="inputString">String to be hashed</param>
        /// <returns>40-character hex string</returns>
        public static string Sha1HashStringForUtf8String(string inputString)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);

            var sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(bytes);

            return HexStringFromBytes(hashBytes);
        }

        /// <summary>
        /// Convert an array of bytes to a string of hex digits
        /// </summary>
        /// <param name="bytes">array of bytes</param>
        /// <returns>String of hex digits</returns>
        private static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }

            return sb.ToString();
        }
    }
}
