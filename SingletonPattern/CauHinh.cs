using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class CauHinh
    {
        private static String filepath = "g:\\dptemp\\cauhinh.ini";

        private Color mauSac;
        private String chuoiVanBan;

        private static CauHinh _instance = null;
        public static CauHinh getInstance()
        {
            //Tạo mới và khởi tạo đối tượng duy nhất
            if (_instance == null)
            {
                _instance = new CauHinh();
                _instance.docTuFile();
            }

            //Return đối tượng duy nhất
            return _instance;
        }

        private CauHinh()
        {
            ///Do Constuctor là private nên ko thể tạo mới
            ///được đối tượng CauHinh từ bên ngoài class này
        }

        public Color getMauSac()
        {
            return mauSac;
        }

        public void setMauSac(Color value)
        {
            this.mauSac = value;
        }

        public String getChuoiVanBan()
        {
            return chuoiVanBan;
        }

        public void setChuoiVanBan(String value)
        {
            this.chuoiVanBan = value;
        }

        public void docTuFile()
        {
            try
            {
                var lines = new List<String>(System.IO.File.ReadLines(filepath));
                String stColor = lines[0];
                String vanBan = lines[1];
                this.setMauSac(Color.FromName(stColor));
                this.setChuoiVanBan(vanBan);
            }
            catch
            {
                this.setMauSac(Color.FromName("Red"));
                this.setChuoiVanBan("abc");

            }
        }

        public void luuXuongFile()
        {
            String noiDung = String.Format("{0}\r\n{1}", this.getMauSac().ToKnownColor(), this.getChuoiVanBan());
            System.IO.File.WriteAllText(filepath, noiDung);
        }
    }
}
