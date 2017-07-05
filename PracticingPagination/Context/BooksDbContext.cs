using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PracticingPagination.Models;

namespace PracticingPagination.Context
{
    public class BooksDbContext: DbContext
    {
        public BooksDbContext():base("name=Books")
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}