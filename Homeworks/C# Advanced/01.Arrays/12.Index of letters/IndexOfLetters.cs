namespace _12.Index_of_letters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main()
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a' + i);
            }

            string word = Console.ReadLine();
            foreach (var item in word)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (item == alphabet[i])
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
