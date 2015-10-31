// Write a program that encodes and decodes a string using given encryption key (cipher). 
// The key consists of a sequence of characters. The encoding/decoding is done by performing XOR 
// (exclusive or) operation over the first letter of the string with the first of the key, the second 
// – with the second, etc. When the last key character is reached, the next is the first.

using System;

class TextEncodeAndDecode
{
    static void Main()
    {
        string text = "Telerik Academy";
        string key = "study";
        Console.WriteLine("The original message is:");
        Console.WriteLine("\"{0}\"", text);

        char[] textAsArray = text.ToCharArray();
        char[] keyAsArray = key.ToCharArray();
        char[] encodedMessage = new char[textAsArray.Length];
        char[] decodedMessage = new char[textAsArray.Length];

        // Encode message
        for (int i = 0, j = 0; i < textAsArray.Length; i++, j++)
        {
            if (j == keyAsArray.Length)
            {
                j = 0;
            }
            encodedMessage[i] = (char)(textAsArray[i] ^ keyAsArray[j]);
        }
        Console.WriteLine("The encoded message with key \"{0}\" is:", key);
        Console.WriteLine("\"{0}\"", string.Join("", encodedMessage));

        // Decode message
        for (int i = 0, j = 0; i < encodedMessage.Length; i++, j++)
        {
            if (j == keyAsArray.Length)
            {
                j = 0;
            }
            decodedMessage[i] = (char)(encodedMessage[i] ^ keyAsArray[j]);
        }
        Console.WriteLine("The decoded message is:");
        Console.WriteLine("\"{0}\"", string.Join("", decodedMessage));
    }
}

