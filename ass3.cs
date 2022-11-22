using System;
namespace assignment3
{
    
    class list
    {

        public static void Main()
        {
            string s = "Hi goodmorning";
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    count++;
            }


            Console.Write("Number of spaces = " + count);

        }
    }
}
