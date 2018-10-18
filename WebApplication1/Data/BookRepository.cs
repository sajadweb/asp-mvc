using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class BookRepository
    {
        private static Books[] _books = new Books[]
        {
            new Books()
            {
                SeriesTitle = "THe Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Description demo issue</p>",
                Artists = new Artist[]
               {
                    new Artist(){Name="a",Role="a1"},
                    new Artist(){Name="b",Role="b1"},
                    new Artist(){Name="c",Role="c1"},
               },
                Favorite= false
            },
              new Books()
            {
                SeriesTitle = "THe Amazing Spider-Man2",
                IssueNumber = 7002,
                DescriptionHtml = "<p>Description demo issue</p>2",
                Artists = new Artist[]
               {
                    new Artist(){Name="a2",Role="a12"},
                    new Artist(){Name="b2",Role="b12"},
                    new Artist(){Name="c2",Role="c12"},
               },
                Favorite= true
            },
    };
        public Books GetBook(int id)
        {
            Books book = null;
            foreach (var item in _books)
            {
                if (item.Id== id)
                {
                    book = item;
                    break;
                }
            }
            return book;
        }
    }
}
