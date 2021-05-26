using System;

namespace PW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                Console.WriteLine("Введите слово");
                String Word = Console.ReadLine();
                Char[] ArrayOfWord = Word.ToCharArray();
                int Counter = 0;
                int CounterOfF = 0;
                int Index = 0;
                for (int i = 0; i < Word.Length; i++)
                {
                    if (ArrayOfWord[i].Equals('f'))
                    {
                        CounterOfF++;
                        Counter++;
                        if (CounterOfF == 2)
                        {
                            Index = i;
                        }
                    }
                }
                if (Counter == 1)
                {
                    Console.WriteLine("-1");
                }
                else if (Counter == 0)
                {
                    Console.WriteLine("-2");
                }
                else
                {
                    Console.WriteLine("Второе вхождение буквы f: " + Index);
                }

                
                String[] RusLanguage = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я", "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "ч", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
                String[] EngLanguage = { "A", "B", "V", "G", "D", "E", "E", "J", "Z", "I", "Th", "K", "L", "M", "N", "O", "P", "R", "S", "T", "Y", "F", "H", "C", "Ch", "Sh", "Shch", "'", "Y", "'", "Е", "U", "Ya", "a", "b", "v", "g", "d", "e", "e", "j", "z", "i", "th", "k", "l", "m", "n", "o", "p", "r", "s", "t", "y", "f", "h", "c", "ch", "sh", "shch", "'", "y", "'", "e", "u", "ya" };
                String Empty = String.Empty;
                Console.WriteLine("Введите слово");
                Word = Console.ReadLine();
                for (int i = 0; i < Word.Length; i++)
                {
                    for (int j = 0; j < RusLanguage.Length; j++)
                    {
                        if (Word.Substring(i, 1) == RusLanguage[j])
                        {
                            Empty += EngLanguage[j];
                        }
                    }
                }
                Console.WriteLine(Empty);

               
                Console.WriteLine("Введите слово");
                Word = Console.ReadLine();
                ArrayOfWord = Word.ToCharArray();
                Empty = String.Empty;
                int FirstH = Word.IndexOf("h");
                int LastH = Word.LastIndexOf("h");
                for (int i = 0; i < Word.Length; i++)
                {
                    if (i != FirstH && i != LastH)
                    {
                        if (ArrayOfWord[i].Equals('h'))
                        {
                            ArrayOfWord[i] = 'H';
                        }
                    }
                    Empty += ArrayOfWord[i];
                }
                Console.WriteLine(Empty);
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
