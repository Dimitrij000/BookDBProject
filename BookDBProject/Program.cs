using System;

class Program
{
    static void Main()
    {
        BookDB db = new BookDB();

        db.UpdateBookStatus(1, "Borrowed");

        Console.WriteLine("Book status updated successfully!");
    }
}
