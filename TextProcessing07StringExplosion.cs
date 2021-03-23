using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextProcessing07StringExplosion
{
    class Program
    {

        static void Main()
        {
            //TextProcessing07StringExplosion

            string text = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            int power = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char bomb = '>';
                if (text[i] == bomb)
                {
                    power += int.Parse(text[i + 1].ToString());
                }
                if (power > 0 && text[i] != bomb)
                {
                    power -= 1;
                    continue;
                }

                output.Append(text[i]);

            }
            Console.WriteLine(output);

            // abv>1>1>2>2asdasd

            //
        }
    }
}