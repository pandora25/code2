using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a word ?");
            string Input = Console.ReadLine();
            var chars = Input.ToCharArray();

            char[] str = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            int count0 = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            for (int x = 0; x < chars.Length; x++)
            {
                if (chars[x] == 'a' || chars[x] == 'e' || chars[x] == 'i' || chars[x] == 'o' || chars[x] == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine($"the total vowels are { count}.\n\n");


            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a')
                {
                    count0++;
                }
                else if (chars[i] == 'e')
                {
                    count1++;
                }
                else if (chars[i] == 'i')
                {
                    count2++;
                }
                else if (chars[i] == 'o')
                {
                    count3++;
                }
                else if (chars[i] == 'u')
                {
                    count4++;
                }
            }
            Console.WriteLine(
         $"numbers of vowels {str[0]},{count0}\n," +
         $"numbers of vowels {str[1]},{count1}\n," +
         $"numbers of vowels {str[2]},{count2}\n," +
         $"numbers of vowels {str[3]},{count3}\n," +
         $"numbers of vowels {str[4]},{count4}\n ");

        }
    }
}
