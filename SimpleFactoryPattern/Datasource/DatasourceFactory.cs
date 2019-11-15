using SimpleFactoryPattern.Datasource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Model
{
    public class DatasourceFactory
    {
        public IDatasource CreateDatasource(string dataType)
        {
            if (dataType.Equals("SQL"))
            {
                return new SQLDatasource();
            }
            else if (dataType.Equals("File"))
            {
                return new FileDataSource();
            }
            else
            {
                throw new Exception("Unknow class");
            }
        }
    }
}
