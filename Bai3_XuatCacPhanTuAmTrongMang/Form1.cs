using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_XuatCacPhanTuAmTrongMang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Xuất mảng chuổi phần tử âm
         */
        
        string XuatMangPhanTuAm(int[] mang)
        {
            string chuoiMang = null;

            for (int i = 0; i < mang.Length; i++)
            {

                if (mang[i] < 0)
                {
                    chuoiMang += " ";

                    chuoiMang += mang[i];
                }
            }

            return chuoiMang;
        }

        /*
         * Khỏi tạo mảng
         */

        string[] chuoiMang;
        int[] mangSoNguyen;

        void KhoiTaoMang()
        {
            string chuoi = txtMang.Text;

            string[] chuoiMang = chuoi.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        /*
         * chuyển mảng string sang số nguyên
         */

        void ChuyenChuoiSangSo()
        {
            int chieuDaimang = (int)chuoiMang.Length;
            mangSoNguyen = new int[chieuDaimang];

            for (int i = 0; i < chuoiMang.Length; i++)
            {
                mangSoNguyen[i]  = int.Parse(chuoiMang[i]);
            }
        }
        
        private void btnLocPhanTuAm_Click(object sender, EventArgs e)
        {
            KhoiTaoMang();

            ChuyenChuoiSangSo();

            txtCacPhanTuAm.Text = XuatMangPhanTuAm(mangSoNguyen);
        }
    }
}
