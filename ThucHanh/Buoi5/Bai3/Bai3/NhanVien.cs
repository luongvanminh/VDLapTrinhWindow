using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public class NhanVien
    {
        public string MSNV;
        public string Hoten;

        public NhanVien(string MSNV, string Hoten)
        {
            this.MSNV = MSNV;
            this.Hoten = Hoten;
        }

        public virtual int TinhLuong()
        {
            return 0;
        }
    }
}
