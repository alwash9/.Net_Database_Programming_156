using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Entity_ClassDemo.Models
{
    class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
