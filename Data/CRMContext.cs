using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using MyCRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCRM.Data
{
    public class CRMContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public string DbPath { get; }

        public CRMContext()
        {
            DbPath = "C:\\Users\\mafaz\\src\\repos\\MyCRM\\db\\local.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
