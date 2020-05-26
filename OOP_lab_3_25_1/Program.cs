using System;

namespace OOP_lab_3_25_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            int k = 0;

            foreach (string element in elements)
            {
                int k1 = 0;

                foreach (char c in element)
                {
                    if ((c >= (char)48) && (c <= (char)57)) ++k1;
                }

                if (k1 == element.Length) ++k;
            }

            Console.WriteLine("Kiлькiсть чисел у текстi: {0}", k);

            Console.Write("\nCлова, що складаються тiльки з латинських лiтер:");

            foreach (string element in elements)
            {
                k = 0;

                foreach (char leter in element)
                {
                    for (char c = 'a'; c <= 'z'; ++c)
                    {
                        if (leter == c)
                        {
                            ++k;
                        }
                    }

                    for (char c = 'A'; c <= 'Z'; ++c)
                    {
                        if (leter == c)
                        {
                            ++k;
                        }
                    }
                }

                if (k == element.Length)
                {
                    Console.Write(" {0}", element);
                }
            }

            Console.WriteLine();
        }
    }
}
