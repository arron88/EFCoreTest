using System;
using System.Collections.Generic;

namespace ScaffloldTest
{
    public partial class Book
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime PubTime { get; set; }
        public string? AuthorName { get; set; }
        public string Age2 { get; set; } = null!;
        public int Age111 { get; set; }
    }
}
