using System;
using System.Collections;
class stack1
{
    static void Main(string[] args)
    {
        Stack st = new Stack();
        int ch;
        int c;
        do
        {
            Console.WriteLine("\n\nStack Operations\n");
            Console.WriteLine("1.Push\n2.Pop\n3.Peek\n4.Display\n5.Exit");
            Console.Write("Enter your choice : ");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.Write("Enter value to be pushed : ");
                    st.Push(int.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Console.Write("Popped Value : " + st.Pop());
                    break;

                case 3:
                    Console.Write("Peeked Value : " + st.Peek());
                    break;

                case 4:
                    Console.Write("Stack Elements : ");
                    foreach (Object obj in st)
                        Console.Write(obj + " ");
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }

            Console.Write("Press 1 to Continue : ");
            c = int.Parse(Console.ReadLine());

        } while (c == 1);
    }
}

