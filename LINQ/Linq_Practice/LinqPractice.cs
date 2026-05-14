using System.Linq;
using System.Collections.Generic;
using System;
public class LinqPractice
{
    public void LinqPracticeFun()
    {
        // List<Book> books = BooksData.GetBooks().ToList();

        var books = BooksData.GetBooks();

        var data = books.Select(b => b.Author);

        var idmul = books.Select(b => b.Id * 2);

        foreach (var item in data)
        {
            System.Console.WriteLine(item);
        }

        foreach (var item in idmul)
        {
            System.Console.WriteLine(item);
        }

        // select two items

        var bookNameAndAuthor = books.Select(b => new
        {
            BookName = b.Name,
            AuthorName = b.Author
        });


        foreach (var ba in bookNameAndAuthor)
        {
            System.Console.WriteLine(ba.BookName + " " + ba.AuthorName);
        }


        // query based syntax

        var dataq = from b in books
                    select b.Id;

        var pairinfo = from b in books
                       select (new
                       {
                           bName = b.Name,
                           bAuthor = b.Author
                       });

        foreach (var ba in pairinfo)
        {
            System.Console.WriteLine(ba.bName + " " + ba.bAuthor);
        }

        //without new

        var data2 = books.Select(b => (bookName: b.Name, bookAuthor: b.Author)).ToList();

        foreach (var d in data2)
        {
            System.Console.WriteLine(d.bookName + " " + d.bookAuthor);
        }

        data2.ForEach(b => System.Console.WriteLine(b.bookName + " " + b.bookAuthor));
    }
}