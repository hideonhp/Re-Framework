﻿using System;
using System.Collections.Generic;

namespace Re_Framework.CoreBase.Models
{
    public partial class BooksReq
    {
        public List<Book> Books { get; set; }
    }

    public partial class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Author { get; set; }
        public string PublishDate { get; set; }
        public string Publisher { get; set; }
        public long Pages { get; set; }
        public string Description { get; set; }
        public Uri Website { get; set; }
    }
}
