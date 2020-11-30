using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcFriendsSite.Models;

namespace MvcFriendsSite.Data
{
    public class MvcFriendsSiteContext : DbContext
    {
        public MvcFriendsSiteContext (DbContextOptions<MvcFriendsSiteContext> options)
            : base(options)
        {
        }

        public DbSet<MvcFriendsSite.Models.UserModel> UserModel { get; set; }

        public DbSet<MvcFriendsSite.Models.SocialModel> SocialModel { get; set; }
        public DbSet<MvcFriendsSite.Models.BlogModel> Blogs { get; set; }
    }
}
