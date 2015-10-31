using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Encode_and_Encrypt
{
    class EncodeAndEncrypt
    {
        static string Encrypt(string message, string cypher)
        {
            char[] messageArray = message.ToCharArray();
            char[] cypherArray = cypher.ToCharArray();
            char[] result = new char[messageArray.Length];

            if (messageArray.Length >= cypherArray.Length)
            {
                for (int i = 0, j = 0; i < messageArray.Length; i++, j++)
                {
                    if (j == cypherArray.Length)
                    {
                        j = 0;
                    }
                    result[i] = (char)(((messageArray[i] - 'A') ^ (cypherArray[j] - 'A')) + 'A');
                }
            }
            else
            {
                for (int i = 0, j = 0; i < cypherArray.Length; i++, j++)
                {
                    if (j == messageArray.Length)
                    {
                        j = 0;
                    }
                    result[j] = (char)(((messageArray[j] - 'A') ^ (cypherArray[i] - 'A')) + 'A');
                    messageArray[j] = result[j];
                }
            }

            string cypherText = string.Join("", result);
            return cypherText;
        }

        static string Encode(string text)
        {
            int counter = 1;
            StringBuilder newText = new StringBuilder();
            string modText = text + '@';

            for (int i = 0; i < modText.Length - 1; i++)
            {
                if (modText[i] == modText[i + 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > 2)
                    {
                        newText.Append(counter + modText[i].ToString()); 
                    }
                    else if (counter == 2)
                    {
                        newText.Append(modText[i].ToString() + modText[i].ToString());
                    }
                    else
                    {
                        newText.Append(modText[i].ToString());
                    }
                    
                    counter = 1;
                }
            }

            return newText.ToString();
        }

        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();
            int lengthOfCypher = cypher.Length;
            Console.WriteLine(Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher);
        }
    }
}
