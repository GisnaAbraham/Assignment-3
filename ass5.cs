class Book
{
    public int bookNo;
    public string bookTitle;
    public float price;

    public void Input()
    {
        Console.Write("Enter Book No: ");
        bookNo = int.Parse(Console.ReadLine());
        Console.Write("Enter Book Title: ");
        bookTitle = Console.ReadLine();
        Console.Write("Enter Book Price: ");
        price = int.Parse(Console.ReadLine());
    }

    public float TotalCost(int n)
    {
        return price * n;
    }

    public void Purchase()
    {
        Console.Write("Enter the number of copies to be purchased: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Total cost to be paid: {0}", TotalCost(n));
    }

    public void Display()
    {
        Console.WriteLine("Book No: {0}", bookNo);
        Console.WriteLine("Book Title: {0}", bookTitle);
        Console.WriteLine("Price: {0}", price);
    }

    static void Main(string[] args)
    {
        Book b = new Book();
        b.Input();
        b.Purchase();
        b.Display();
    }
}