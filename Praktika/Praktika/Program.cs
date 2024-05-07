namespace Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input your text ==>  ");
            string text = Console.ReadLine();
            char c = 'c';

            int count = text.Count(ch => ch == c);
            Console.WriteLine($"Symbol '{c}' vstrechaytsya v srtoke {count} raz." );

            Console.WriteLine("________________________________________________________________");
           
            string textWithoutDigits = new string(text.Where(ch => !char.IsDigit(ch)).ToArray());
            Console.WriteLine($"Stroka bez sefr: {textWithoutDigits}");

            Console.WriteLine("________________________________________________________________");

            string word = "key";
            bool allLettersPresent = word.All(w => text.Contains(w));
            Console.WriteLine($"V texti presutsvuyt vse bukvi slova 'key': {allLettersPresent}");

            Console.WriteLine("________________________________________________________________");

          
            bool bracketsCorrect = Skobka(text);
            Console.WriteLine($"Pravilnost pastanovki kruglih skobok: {bracketsCorrect}");
        }

        public static bool Skobka(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == '(')
                {
                    count++;
                }
                else if (c == ')')
                {
                    count--;
                    if (count < 0)
                    {
                        return false;
                    }
                }
            }

            return count == 0;
        }
       
    }
}

