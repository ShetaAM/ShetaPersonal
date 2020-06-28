using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Data.Model.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {
            
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Danesh> Daneshes { get; set; }
        public DbSet<Maharat> Maharats { get; set; }
        public DbSet<Rezome> Rezomes { get; set; }
        public DbSet<Rezomedetail> Rezomedetails { get; set; }
        public DbSet<Sabeghe> Sabeghes { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Tahsilat> Tahsilats { get; set; }
        public DbSet<TamasHa> TamasHas { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<RezomeTecs> RezomeTecses { get; set; }
        public DbSet<Vaziyat> Vaziyats { get; set; }
        public DbSet<Setting> Settings { get; set; }

    }
}
