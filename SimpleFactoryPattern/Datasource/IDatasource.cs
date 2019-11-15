using SimpleFactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Datasource
{
    public interface IDatasource
    {
        List<SinhVien> GetAll();
    }
}
