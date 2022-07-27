using System;

namespace ROT.Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine().ToLower();


            Console.WriteLine("Enter the ROT:");
            int rot = int.Parse(Console.ReadLine());


            char[] alphabets = new char[]
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z'
            };

            for (int i = 0; i < text.Length; i++)
            {
                int newIndex = Array.IndexOf(alphabets, text[i]) + rot;

                int rotatedIndex;

                if (newIndex > alphabets.Length)
                    rotatedIndex = newIndex - alphabets.Length;
                else
                    rotatedIndex = newIndex;


                char character = alphabets[rotatedIndex];

                text.Replace(text[i], character);
                Console.Write(character);
            }

            Console.Read();
        }
    }
}
