using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTest
{
    internal class Books
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime PubTime { get; set; }
        public string? AuthorName { get; set; }
    }
}
