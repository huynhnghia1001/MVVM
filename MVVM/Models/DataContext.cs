using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class DataContext : DbContext
    {
        // Kết nối sqlite
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = LoadData.db");

        }
        private static DataContext _ins;
        public static DataContext ins
        {
            get
            {
                if (_ins == null)
                    _ins = new DataContext();
                return _ins;
            }
            set { _ins = value; }
        }
        public DbSet<Input> Inputs { get; set; }

    }
}
