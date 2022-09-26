using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore_BlogPosting_Site.Models
{
    public class BlogDBContext: DbContext
    {
        public DbSet<Post> Post { get; set; }
        public BlogDBContext(DbContextOptions<BlogDBContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
