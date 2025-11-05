using System;

public class BookDB
{
    public bool UpdateBookStatus(int bookId, string newStatus)
    {
        Console.WriteLine($"Kirjan ID {bookId} status päivitetty tilaan: {newStatus}");
        return true;
    }
}
