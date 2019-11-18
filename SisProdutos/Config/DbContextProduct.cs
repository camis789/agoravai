using System;
using Microsoft.EntityFrameworkCore;
using SisProdutos.models;

namespace SisProdutos.Config
{
    public class DbContextProduct : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MARIS-PC\SQLEXPRESS;DataBase=DBTeste;Trusted_Connection=True;");
        }
    }
}
