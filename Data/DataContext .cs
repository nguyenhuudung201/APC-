using APC_.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC_.Data
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString = "Server=DESKTOP-71IL0V1\\SEVERDUNG; Database=DataProduct; User Id=sa; Password=040620; Trusted_Connection=True; TrustServerCertificate=True;MultipleActiveResultSets=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<Product> Products { get; set; }
    }
}
