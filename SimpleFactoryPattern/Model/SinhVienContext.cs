using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Model
{
    class SinhVienContext : DbContext
    {
        public SinhVienContext() : base("Data Source=.;Initial Catalog=designpattern;User ID=sa;Password=123")
        {
        }

        public DbSet<SinhVien> SinhVienDbSet { get; set; }
    }
}
