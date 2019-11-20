using System;
using System.Collections.Generic;
using System.Data.Entity;
namespace MyDictionary
{
    class MyDictionaryContext:DbContext
    {
        public MyDictionaryContext()
            : base("DbConnection")
        { }
        public DbSet<Dictionary> Dictionaries { get; set; }
    }
}
