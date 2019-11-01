using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShowImage
{
    public partial class HoangNgocThang : Form
    {
        Image image;
        string pathDirectoryImgFolder;
        string pathDirectoryCurrentImg;
        string[] files;
        int index = 0;
        int nextIndex1 = 1;
        int nextIndex2 = 2;
        int nextIndex3 = 3;
        int nextIndex4 = 4;
        public HoangNgocThang()
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();

        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            // openFileDialog.Title = "Chọn thư mục chứa ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                files = Directory.GetFiles(openFileDialog.SelectedPath);

                timer1.Enabled = true;
                timer1.Interval = 2000;
                timer1.Tick += new EventHandler(Timer2_Tick);
                timer1.Start();

            }
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            //hien thi anh hien tai
            if (index < files.Length - 1)
            {
                index = index + 1;
            }
            else
            {
                index = 0;
            }

            image = Image.FromFile(files[index]);
            picAnh.Image = image;

            
            if (nextIndex1 < files.Length - 1)
                nextIndex1 = nextIndex1 + 1;
            else
            {
                nextIndex1 = 0;
            }
            pictureBox1.Image = Image.FromFile(files[nextIndex1]);

            if (nextIndex2 < files.Length - 1)
                nextIndex2 = nextIndex2 + 1;
            else
            {
                nextIndex2 = 0;
            }
            pictureBox2.Image = Image.FromFile(files[nextIndex2]);

            if (nextIndex3 < files.Length - 1)
                nextIndex3 = nextIndex3 + 1;
            else
            {
                nextIndex3 = 0;
            }
            pictureBox3.Image = Image.FromFile(files[nextIndex3]);

            if (nextIndex4 < files.Length - 1)
                nextIndex4 = nextIndex4 + 1;
            else
            {
                nextIndex4 = 0;
            }
            pictureBox4.Image = Image.FromFile(files[nextIndex4]);


            textBox1.Text = files[index];
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
