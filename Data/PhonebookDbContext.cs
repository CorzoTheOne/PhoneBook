using Microsoft.EntityFrameworkCore;
using PhoneBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Data
{
    public class PhonebookDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(LocalDb)\\LocalPhonebookDB;Database=BlogDb;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True");

        }
    }
}
