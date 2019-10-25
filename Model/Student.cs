using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    //them modifier public de truy xuat class nay tu cho khac
    public class Student
    {
        public string IDStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GENDER Gender { get; set; }
        public DateTime DOB { get; set; }
        public string POB { get; set; }
        public ICollection<HistoryLearning> ListHistoryLearning { get; set; }

    }

    public enum GENDER
    {
        Male, Female, Other
    }

    public class Class1
    {
    }
}
