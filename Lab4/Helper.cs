using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Lab4;

public class Helper : Form1
{
    //             Deserializing
    public static dynamic Deserialize(string path)
    {
        using (FileStream fs = new FileStream(path,
                   FileMode.Open))
        {
            List<Book> books = null;
            try
            {
                 books = JsonSerializer.Deserialize<List<Book>>(fs);
            }
            catch (Exception e)
            {
                MessageBox.Show(@"There is error here. Please, try again", @"Error");
            }
            return books;
        }
    }
    //             Serializing
    public static void Serialize(List<Book> b, string path)
    {
        var options = new JsonSerializerOptions()
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        };
        using (FileStream fileStream = new FileStream(path, FileMode.Truncate))
        {
            JsonSerializer.Serialize(fileStream, b, options);
            Console.WriteLine(@"done");
        }
    }
    //             Searching by different criteria
    public static List<Book> SearchByTitle(List<Book> b, string pattern)
    {
        List<Book> result = new List<Book>();
        var myLinqQuery = from book in b 
                                         where book.Title.Contains(pattern) 
                                         select book;
        
        foreach (var book in myLinqQuery) result.Add(book);
        return result;
    }
    public static List<Book> SearchByIds(List<Book> b, string pattern)
    {
        List<Book> result = new List<Book>();
        var myLinqQuery = from book in b 
            where pattern.Contains(book.PublishingHouseId.ToString())
            select book;
        
        foreach (var book in myLinqQuery) result.Add(book);
        return result;
    }
    public static List<Book> SearchByAddresses(List<Book> b, string pattern)
    {
        List<Book> result = new List<Book>();
        var myLinqQuery = from book in b 
            where book.PublishingHouse.Adress.Contains(pattern)
            select book;
        
        foreach (var book in myLinqQuery) result.Add(book);
        return result;
    }
    //             Deleting from list
    public static List<Book> DeleteBook(List<Book> b, string pattern)
    {
        List<Book> result = new List<Book>();
        var myLinqQuery = from book in b 
                                         where !book.PublishingHouseId.ToString().Equals(pattern)
                                         select book;
        
        foreach (var book in myLinqQuery) result.Add(book);
        return result;
    }
    public static List<Book> ChangeBook(List<Book> b, string pattern, string id, string title, string address)
    {
        List<Book> result = new List<Book>();
        var myLinqQuery = from book in b 
                                         where book.PublishingHouseId.ToString().Equals(pattern)
                                         select book;
        var myLinqQuery1 = from book in b 
                                          where !book.PublishingHouseId.ToString().Equals(pattern)
                                          select book;

        foreach (var book in myLinqQuery1) result.Add(book);

        if (!UniqueCheck(result, Int32.Parse(pattern))) {return b;}

        foreach (var book in myLinqQuery)
        {
            Int32.TryParse(id, out int a);
            book.PublishingHouseId = a;
            book.Title = title;
            book.PublishingHouse.Adress = address;
            result.Add(book);
        }

        return result;
    }

    public static Book CreateBook()
    {
        PublishingHouse ph = new PublishingHouse(){Name = "a"};
        Book book = new Book();
        book.PublishingHouse = ph;
        return book;
    }

    public static bool UniqueCheck(List<Book> books, int pattern)
    {
        foreach (var book in books)
        {
            if (book.PublishingHouseId == pattern) return false;
        }
        return true;
    }
}