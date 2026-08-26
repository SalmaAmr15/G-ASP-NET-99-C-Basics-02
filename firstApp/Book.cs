using System;
using System.Collections.Generic;
using System.Text;

namespace firstApp
{
    internal class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public override string ToString()
        {
            return $"Title: {Title}, Pages: {Pages}";
        }
        public override bool Equals(object obj)
        {
            if (obj is not Book)
                return false;
            Book book = obj as Book;
            return book.Title == this.Title && book.Pages == this.Pages;

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Pages);
        }
    }
}
