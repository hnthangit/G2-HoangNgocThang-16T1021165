using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryPattern.Controller;
using SimpleFactoryPattern.Model;

namespace SimpleFactoryPattern.Datasource
{
    class SQLDatasource : IDatasource
    {
        public List<SinhVien> GetAll()
        {
            return SinhVienController.GetSinhVienFromDb();
        }
    }
}
