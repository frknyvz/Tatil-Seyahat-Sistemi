using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelToLearn.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas  { get; set; }
        public DbSet<Iletisim> Iletisims  { get; set; }
        public DbSet<Yorumlar> Yorumlars  { get; set; }
        public DbSet<GezilecekYerler> GezilecekYerlers  { get; set; }
        public DbSet<Restoranlar> Restoranlars { get; set; }
        public DbSet<TarihiMekanlar> TarihiMekanlars { get; set; }
    }
}