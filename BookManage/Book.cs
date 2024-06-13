using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManage
{
    internal class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public Book() {
            this.Title = "Default title";
            this.Author = "Default Author";
            this.Description = "Default Description";
        }
        public Book(string title, string description, string author) {
            this.Title = title;
            this.Description = description;
            this.Author = author;
        }

    }
}
