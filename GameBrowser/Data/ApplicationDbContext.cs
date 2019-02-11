using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GameBrowser.Models;

namespace GameBrowser.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Profile> Profiles { get; internal set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Profile>().HasKey(m => m.NickName);
            base.OnModelCreating(builder);
        }
    }
}
