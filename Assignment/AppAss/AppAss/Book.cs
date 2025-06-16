using System;

namespace CSharpMiniProjects
{
    public class Book
    {
        private string Title;
        private string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }
}