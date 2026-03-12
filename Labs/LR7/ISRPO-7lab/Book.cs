using System;

namespace Lab7
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int ReleaseYear { get; set; }
        public int Pages { get; set; }
        public int Circulation { get; set; }
    }
}