using System;

namespace assignment3
{

    public class BClass  //baseclass
    {
        public virtual void Display()
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class DClass : BClass //derived class
    {
        public override void Display()
        {
            Console.WriteLine("Make Smile!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DClass d = new DClass();
            d.Display();
            BClass b = new BClass();
            b.Display();

        }
    }
}

