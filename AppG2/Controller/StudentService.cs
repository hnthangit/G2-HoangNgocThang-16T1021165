using AppG2.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Controller
{
    /// <summary>
    /// Lay sinh vien theo ma sinh vien
    /// </summary>
    /// <param name="idStudent">Ma sinh Vien</param>
    /// <returns>Sinh vien co ma tuong ung hoac null</returns>
    public class StudentService
    {
        public static Student GetStudent(string idStudent)
        {
            Student student = new Student
            {
                IDStudent = idStudent,
                FirstName = "Dung",
                LastName = "Nguyen",
                DOB = new DateTime(2000, 5, 5),
                POB = "Thua Thien Hue",
                Gender = GENDER.Male,
            };
            student.ListHistoryLearning = new List<HistoryLearning>();
            for(int i =0; i<12; i++)
            {
                HistoryLearning historyLearning = new HistoryLearning
                {
                    IDHistoryLearning = (i+1).ToString(),
                    YearFrom = 2006 + i,
                    YearEnd = 2007 + i,
                    Address = "THCS NTP",
                    IDStudent = idStudent,
                };
                student.ListHistoryLearning.Add(historyLearning);
            }
            return student;
        }

        /// <summary>
        /// Lấy sinh viên theo mã sinh từ file
        /// </summary>
        /// <param name="pathDataFile">Đường dẫn tới file chứa dữ liệu</param>
        /// <param name="idStudent">Mã sinh viên</param>
        /// <returns>Sinh viên theo mã sinh viên hoặc null nếu không thấy</returns>

        public static Student GetStudent(string pathDataFile, string idStudent)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            if (File.Exists(pathDataFile))
            {
                //Mở file đọc hết toàn bộ các dòng tỏng file xong đóng file lại
                var listLines = File.ReadAllLines(pathDataFile);

                foreach (var lines in listLines)
                {
                    var rs = lines.Split(new char[] { '#' });
                    Student student = new Student
                    {
                        IDStudent = rs[0],
                        FirstName = rs[1],
                        LastName = rs[2],
                        Gender = rs[3] == "Male" ? GENDER.Male : (rs[3] == "Female" ? GENDER.Female : GENDER.Other),
                        DOB = DateTime.ParseExact(rs[4], "yyyy-MM-dd", culture),
                        POB = rs[5]
                    };

                    if (student.IDStudent == idStudent)
                    {
                        return student;
                    }
                }
            }

            
            return null;

        }
        
        /// <summary>
        /// Lấy danh sách quá trình học tập của 1 sinh viên
        /// </summary>
        /// <param name="pathDataFile">Đường dẫn tới file chứa dữ liệu</param>
        /// <param name="idStudent">Mã sinh viên cần lấy</param>
        /// <returns>Danh sách quá trình học tập</returns>
        public static List<HistoryLearning> GetHistoryLearning(string pathDataFile, string idStudent)
        {

            if (File.Exists(pathDataFile))
            {
                List<HistoryLearning> hl = new List<HistoryLearning>();
                //Mở file đọc hết toàn bộ các dòng tỏng file xong đóng file lại
                var listLines = File.ReadAllLines(pathDataFile);

                foreach (var lines in listLines)
                {
                    var rs = lines.Split(new char[] { '#' });
                    HistoryLearning history = new HistoryLearning
                    {
                        IDHistoryLearning = rs[0],
                        YearFrom = int.Parse(rs[1]),
                        YearEnd = int.Parse(rs[2]),
                        Address = rs[3],
                        IDStudent = rs[4]
                    };
                    if (history.IDStudent == idStudent)
                    {
                        hl.Add(history);
                    }
                }
                return hl;
            }
            else return null;
        }

        public static List<HistoryLearning> GetAllHistoryLearning(string pathDataFile)
        {

            if (File.Exists(pathDataFile))
            {
                List<HistoryLearning> hl = new List<HistoryLearning>();
                //Mở file đọc hết toàn bộ các dòng tỏng file xong đóng file lại
                var listLines = File.ReadAllLines(pathDataFile);

                foreach (var lines in listLines)
                {
                    var rs = lines.Split(new char[] { '#' });
                    HistoryLearning history = new HistoryLearning
                    {
                        IDHistoryLearning = rs[0],
                        YearFrom = int.Parse(rs[1]),
                        YearEnd = int.Parse(rs[2]),
                        Address = rs[3],
                        IDStudent = null
                    };
                }
                return hl;
            }
            else return null;
        }
    }
}

