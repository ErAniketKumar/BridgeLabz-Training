using System.Linq;
using System.Collections.Generic;
using System;
public class LinqPractice
{
    public void LinqPracticeFun()
    {
        // List<Book> books = BooksData.GetBooks().ToList();

        var books = BooksData.GetBooks();

        //     var data = books.Select(b => b.Author);

        //     var idmul = books.Select(b => b.Id * 2);

        //     foreach (var item in data)
        //     {
        //         System.Console.WriteLine(item);
        //     }

        //     foreach (var item in idmul)
        //     {
        //         System.Console.WriteLine(item);
        //     }

        //     // select two items

        //     var bookNameAndAuthor = books.Select(b => new
        //     {
        //         BookName = b.Name,
        //         AuthorName = b.Author
        //     });


        //     foreach (var ba in bookNameAndAuthor)
        //     {
        //         System.Console.WriteLine(ba.BookName + " " + ba.AuthorName);
        //     }


        //     // query based syntax

        //     var dataq = from b in books
        //                 select b.Id;

        //     var pairinfo = from b in books
        //                    select (new
        //                    {
        //                        bName = b.Name,
        //                        bAuthor = b.Author
        //                    });

        //     foreach (var ba in pairinfo)
        //     {
        //         System.Console.WriteLine(ba.bName + " " + ba.bAuthor);
        //     }

        //     //without new

        //     var data2 = books.Select(b => (bookName: b.Name, bookAuthor: b.Author)).ToList();

        //     foreach (var d in data2)
        //     {
        //         System.Console.WriteLine(d.bookName + " " + d.bookAuthor);
        //     }

        //     data2.ForEach(b => System.Console.WriteLine(b.bookName + " " + b.bookAuthor));


        // where use for filtering the row and per condition

        // var data = books.Where(b => b.Price > 200);

        // foreach (var d in data)
        // {
        //     System.Console.WriteLine(d.Name + " " + d.Price + " " + d.Author);
        // }

        // where with select like i want only book id whose price gt 200

        var bID = books.Where(b => b.Price > 200).Select(b => b.Id);

        // orderby and orderby descending order

        // var data = books.OrderBy(b => b.Price);
        // foreach (var d in data)
        // {
        //     System.Console.WriteLine(d.Price);
        // }

        // var descdata = books.OrderByDescending(b => b.Price);
        // foreach (var d in descdata)
        // {
        //     System.Console.WriteLine(d.Price);
        // }

        // sort by second paramater

        List<List<int>> list = new List<List<int>>()
        {
            new List<int>{1,3},
            new List<int>{2,4},
            new List<int>{3,3},
            new List<int>{3,4},
            new List<int>{4,9},
            new List<int>{5,11},
            new List<int>{6,23},
            new List<int>{7,1},
            new List<int>{2,9},
            new List<int>{4,5},
        };

        // sort by first paramater but when same then sort by second parameter descending
        var data = list.OrderBy(b => b[0])
        .ThenByDescending(b => b[1]);

        // sort by acending if 1st paramater same then sort by 2nd paramater assending
    //     var data = list.OrderBy(b => b[0])
    //    .ThenBy(b => b[1]);

        foreach (var d in data)
        {
            System.Console.WriteLine(d[0] + " " + d[1]);
        }
    }



}