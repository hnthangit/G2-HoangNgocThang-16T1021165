using AppG2.Controller;
using AppG2.Model;
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

namespace AppG2.View
{
    public partial class frmThongTinSinhVien : Form
    {
        #region Variable for Image Avatar
        Image image;
        string pathDirectoryImg;
        string pathAvatarImg;
        #endregion

        #region Path data file
        string pathStudentDataFile;
        string pathHistoryLearningDataFile;
        #endregion
        public frmThongTinSinhVien(string maSinhVien)
        {
            InitializeComponent();
            pathDirectoryImg = Application.StartupPath + "\\Img";
            pathAvatarImg = pathDirectoryImg + "\\avatar.png";
            picAnhDaiDien.AllowDrop = true;

            pathStudentDataFile = Application.StartupPath + @"\Data\student.txt";
            pathHistoryLearningDataFile = Application.StartupPath + @"\Data\learninghistory.txt";
            if (File.Exists(pathAvatarImg))
            {
                FileStream fileStream = new FileStream(pathAvatarImg, FileMode.Open, FileAccess.Read);
                picAnhDaiDien.Image = Image.FromStream(fileStream);
                fileStream.Close();
            }

            //bds de luu data trung gian, sau do dung bds de do vao datagridview 
            //edit column trong datagridview de chuyen truong data ve field trong class
            bdsQuaTrinhHocTap.DataSource = null;
            dtgQuaTrinhHocTap.AutoGenerateColumns = false;

            //var student = StudentService.GetStudent(maSinhVien);
            var student = StudentService.GetStudent(pathStudentDataFile, maSinhVien);

            if (student == null)
                throw new Exception("Khong ton tai sinh vien nay");
            else
            {
                student.ListHistoryLearning = StudentService.GetHistoryLearning(pathHistoryLearningDataFile, maSinhVien);
                txtId.Text = student.IDStudent;
                txtHo.Text = student.LastName;
                txtTen.Text = student.FirstName;
                txtQueQuan.Text = student.POB;
                dtpNgaySinh.Value = student.DOB;
                chkGioiTinh.Checked = student.Gender == Model.GENDER.Male;
                if (student.ListHistoryLearning != null)
                {
                    bdsQuaTrinhHocTap.DataSource = student.ListHistoryLearning;
                }

                dtgQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;
            }
        }

        private void frmThongTinSinhVien_Load(object sender, EventArgs e)
        {

        }


        private void LinkLabel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "chon anh dia dien";
            openFileDialog.Filter = "File anh|*.png;*.jpg";
            //openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                picAnhDaiDien.Image = image;
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            #region Cap nhat hinh dai dien
            bool imageSave = false;
            if (image != null)
            {
                if (!Directory.Exists(pathDirectoryImg))
                {
                    Directory.CreateDirectory(pathDirectoryImg);
                }
                image.Save(pathAvatarImg);
                imageSave = true;
            }
            #endregion
            if (imageSave)
            {
                MessageBox.Show("da cap nhat avatar thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Anhdaidien_DragDrop(object sender, DragEventArgs e)
        {
            var rs = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filePath = rs.FirstOrDefault();
            image = Image.FromFile(filePath);
            picAnhDaiDien.Image = image;
        }

        private void PicAnhDaiDien_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void MniXoaAnhDaiDien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xoa Anh Dai Dien");
            picAnhDaiDien.Image = Properties.Resources.tet;
            File.Delete(pathAvatarImg);
        }

        //chuyển copy always về do not copy để file cũ khi chạy ko copy đè lên file mới
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                //Viết code xóa dữ liệu ở đây
                var history = (HistoryLearning)bdsQuaTrinhHocTap.Current;

                //Lấy toàn bộ nội dung trong bds ra list
                List<HistoryLearning> hl = (List<HistoryLearning>)bdsQuaTrinhHocTap.DataSource;
                //Xóa mục đc chọn
                hl.Remove(history);

                //set lại bds = list mới
                bdsQuaTrinhHocTap.DataSource = hl;
                //hiển thị lại bds
                bdsQuaTrinhHocTap.ResetBindings(true);

                // xóa trong file
                String delete = history.IDHistoryLearning + "#" + history.YearFrom + "#" + history.YearEnd + "#" + history.Address + "#" + history.IDStudent;
                var Lines = File.ReadAllLines(pathHistoryLearningDataFile);
                var newLines = Lines.Where(line => !line.Contains(delete));
                File.WriteAllLines(pathHistoryLearningDataFile, newLines);
                //Ép kiểu 2 bdsQuaTrinhHocTap.Current as HistoryLearning
                MessageBox.Show("Bạn đã xóa thành công. Địa chỉ: " + history.Address);
            }
            else
            {
                MessageBox.Show("Bạn đã không xóa");
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            var hl = (HistoryLearning)bdsQuaTrinhHocTap.Current;
            var idStudent = hl.IDStudent;
            var f = new frmQuaTrinhHocTapChiTiet(idStudent: hl.IDStudent);
            if (f.ShowDialog() == DialogResult.OK)
            {
                //Tiến hành nạp lại dữ liệu lên lưới
                var newHistoryLearningList = StudentService.GetHistoryLearning(pathHistoryLearningDataFile, idStudent);
                bdsQuaTrinhHocTap.DataSource = newHistoryLearningList;
                bdsQuaTrinhHocTap.ResetBindings(true);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            var history = bdsQuaTrinhHocTap.Current as HistoryLearning;
            var idStudent = history.IDStudent;
            if (history != null)
            {
                var f = new frmQuaTrinhHocTapChiTiet(history.IDStudent, history);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    //Tiến hành nạp lại dữ liệu lên lưới
                    var newHistoryLearningList = StudentService.GetHistoryLearning(pathHistoryLearningDataFile, idStudent);
                    bdsQuaTrinhHocTap.DataSource = newHistoryLearningList;
                    bdsQuaTrinhHocTap.ResetBindings(true);
                }
            }         
        }
    }
}
