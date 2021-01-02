using System;
using System.Collections.Generic;
using System.Text;
using QuanLyHangTon.BusinessLogic;
using QuanLyHangTon.DataAccess;
using QuanLyHangTon.Entities;
namespace QuanLyHangTon.Presenation
{
    class Run
    {
        private static void Menu()
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("||                      QUẢN LÝ HÀNG TỒN                      ||");
            Console.WriteLine("================================================================");
            Console.WriteLine("||               1. QUẢN LÝ SẢN PHẨM                          ||");
            Console.WriteLine("||               2. QUẢN LÝ NHẬP KHO                          ||");
            Console.WriteLine("||               3. QUẢN LÝ XUẤT KHO                          ||");
            Console.WriteLine("||               0. THOÁT                                     ||");
            Console.WriteLine("================================================================");
        }
        public static void RunProgram()
        {
            List<SanPham> sanPhams = new List<SanPham>();
            List<NhapKho> nhapKhos = new List<NhapKho>();
            List<XuatKho> xuatKhos = new List<XuatKho>();
            NhapKho_BLL nhapKho_BLL = new NhapKho_BLL();
            XuatKho_BLL xuatKho_BLL = new XuatKho_BLL();
            SanPham_BLL sanPham_BLL = new SanPham_BLL();
            NhapKho_DAL nhapKho_DAL = new NhapKho_DAL();
            SanPham_DAL sanPham_DAL = new SanPham_DAL();
            XuatKho_DAL xuatKho_DAL = new XuatKho_DAL();
            nhapKho_DAL.DocFile(nhapKhos);
            xuatKho_DAL.DocFile(xuatKhos);
            sanPham_DAL.DocFile(sanPhams);
            int chon;
            while (true)
            {
                Menu();
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        SanPham_GUI.Chon(sanPhams, sanPham_BLL, sanPham_DAL);
                        Console.Clear();
                        break;
                    case 2:
                        NhapKho_GUI.Chon(nhapKhos, nhapKho_BLL, nhapKho_DAL);
                        Console.Clear();
                        break;
                    case 3:
                        XuatKho_GUI.Chon(xuatKhos, xuatKho_BLL, xuatKho_DAL);
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
