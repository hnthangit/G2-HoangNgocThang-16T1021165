using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class AppG2Context : DbContext
    {
        public AppG2Context() : base("Data Source=.;Initial Catalog=DB_G2;User ID=sa;Password=123")
        {
        }

        public DbSet<Student> StudentDbSet { get; set; }
        public DbSet<HistoryLearning> HistoryLearningsDbSet { get; set; }
    }
}
