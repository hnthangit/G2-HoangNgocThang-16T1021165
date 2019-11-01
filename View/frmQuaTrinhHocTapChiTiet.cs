using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG2.Controller;
using AppG2.Model;

namespace AppG2.View
{
    public partial class frmQuaTrinhHocTapChiTiet : Form
    {
        string pathHistoryLearningDataFile;      
        HistoryLearning history;
        string idStudent;
        public frmQuaTrinhHocTapChiTiet(String idStudent, HistoryLearning history = null)
        {
            InitializeComponent();
            pathHistoryLearningDataFile = Application.StartupPath + @"\Data\learninghistory.txt";
            this.history = history;
            this.idStudent = idStudent;
            if (history != null)
            {
                //Chỉnh sửa
                this.Text = "Chỉnh sửa quá trình học tập";
                numTuNam.Value = history.YearFrom;
                numDenNam.Value = history.YearEnd;
                txtNguoiHoc.Text = history.Address;
            }
            else
            {
                //Thêm mới
                this.Text = "Thêm mới quá trình học tập";
            }
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            if (history != null)
            {
                //Cập nhật
                var listHistoryLearning = StudentService.GetHistoryLearning(pathHistoryLearningDataFile, idStudent);
                string newHistory = history.IDHistoryLearning + "#" + numTuNam.Value.ToString() + "#" + numDenNam.Value.ToString() + "#" + txtNguoiHoc.Text + "#" + history.IDStudent;
                // xóa trong file                
                String delOldHistoryLearning = history.IDHistoryLearning + "#" + history.YearFrom + "#" + history.YearEnd + "#" + history.Address + "#" + history.IDStudent;
                var Lines = File.ReadAllLines(pathHistoryLearningDataFile);
                var newLines = Lines.Where(line=> !line.Contains(delOldHistoryLearning));
                File.WriteAllLines(pathHistoryLearningDataFile, newLines);
                File.AppendAllText(pathHistoryLearningDataFile, newHistory);
            }
            else
            {
                //Thêm mới
                var listHistoryLearning = StudentService.GetAllHistoryLearning(pathHistoryLearningDataFile);
                //Random id moi tu cac id da co
                var exclude = new HashSet<int>();
                foreach (var item in listHistoryLearning)
                {
                    exclude.Add(Int32.Parse(item.IDHistoryLearning));
                }
                var range = Enumerable.Range(1, 100).Where(i => !exclude.Contains(i));
                var rand = new System.Random();
                int index = rand.Next(0, 100 - exclude.Count);

                //Lay id moi
                string newId = range.ElementAt(index).ToString();

                //Tao moi

                string newHistory = newId + "#" + numTuNam.Value.ToString() + "#" + numDenNam.Value.ToString() + "#" + txtNguoiHoc.Text + "#" + idStudent;
                File.AppendAllText(pathHistoryLearningDataFile, "\n"+newHistory);
            }
            MessageBox.Show("Đã cập nhật dữ liệu thành công");
            
            //Thuộc tính có sự thay đổi thì form này ngay lập tức sẽ đóng lại
            DialogResult = DialogResult.OK;
        }
    }
}
