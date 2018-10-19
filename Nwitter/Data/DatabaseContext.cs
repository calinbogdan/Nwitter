using Microsoft.EntityFrameworkCore;
using Nwitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nwitter.Data {
    public class DatabaseContext : DbContext {

        public DbSet<User> Users { get; set; }
        public DbSet<Nweet> Nweets { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
            Database.EnsureCreated();
        }
    }
}
