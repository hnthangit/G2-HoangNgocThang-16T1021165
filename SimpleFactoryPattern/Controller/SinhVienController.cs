using SimpleFactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFactoryPattern.Controller
{
    public class SinhVienController
    {
        public static List<SinhVien> GetSinhVienFromFile()
        {
            string pathDataFile = Application.StartupPath + @"\Data\sinhvien.txt";
            if (File.Exists(pathDataFile))
            {
                //Mở file đọc hết toàn bộ các dòng tỏng file xong đóng file lại
                var listLines = File.ReadAllLines(pathDataFile);
                List<SinhVien> listSinhVien = new List<SinhVien>();
                foreach (var lines in listLines)
                {
                    var rs = lines.Split(new char[] { '#' });
                    SinhVien sinhvien = new SinhVien
                    {
                        Id = rs[0],
                        Name = rs[1],
                    };
                    listSinhVien.Add(sinhvien);
                }
                return listSinhVien;
            }
            else return null;
        }

        public static List<SinhVien> GetSinhVienFromDb()
        {
            return new SinhVienContext().SinhVienDbSet.ToList();
        }
    }
}
