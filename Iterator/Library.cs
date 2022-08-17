using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Library : IBookNumerable
    {
        public Book[] books;

        public Library()
        {
            books = new Book[]
{
            new Book{Name="The Great Gatsby"},
            new Book {Name="One Hundred Years of Solitude"},
            new Book {Name="Beloved"}
};
        }
        public Book this[int index]
        {
            get { return books[index]; }
        }

        public int Count
        {
           get { return books.Length; }
        }

        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}
