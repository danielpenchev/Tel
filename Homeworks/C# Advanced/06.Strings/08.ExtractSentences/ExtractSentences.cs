namespace Ex08ExtractSentences
{
    using System;
    using System.Text;

    public class Ex08ExtractSentences
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = "." + Console.ReadLine();
            var s = new StringBuilder();

            for (int i = 0, j = 0; i < text.Length; i++)
            {
                var match = true;

                for (j = i; j < i + word.Length; j++)
                {
                    if (text[j] != word[j - i])
                    {
                        match = false;
                        break;
                    }
                }

                if (match && !char.IsLetter(text[i - 1])
                          && !char.IsLetter(text[j]))
                {
                    while (text[--i] != '.') ;
                    while (text[++i] == ' ') ;
                    while (text[i] != '.')
                        s.Append(text[i++]);
                    while (s[s.Length - 1] == ' ')
                        s.Length--;
                    s.Append(". ");
                }
            }

            Console.Write(s);
        }
    }
}
