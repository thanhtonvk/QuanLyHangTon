using System;
using System.Collections.Generic;
using System.Text;
using QuanLyHangTon.Entities;
using QuanLyHangTon.BusinessLogic;
using QuanLyHangTon.DataAccess;
namespace QuanLyHangTon.Presenation
{
    class SanPham_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("||                      QUẢN LÝ SẢN PHẨM                      ||");
            Console.WriteLine("================================================================");
            Console.WriteLine("||               1. Nhập thông tin                            ||");
            Console.WriteLine("||               2. Hiện thông tin                            ||");
            Console.WriteLine("||               3. Tìm kiếm                                  ||");
            Console.WriteLine("||               4. Sửa                                       ||");
            Console.WriteLine("||               5. Xóa                                       ||");
            Console.WriteLine("||               0. Thoát                                     ||");
            Console.WriteLine("================================================================");
        }
        public static void Chon(List<SanPham> list, SanPham_BLL SanPham_BLL, SanPham_DAL SanPham_DAL)
        {
            int chon;
            while (true)
            {
                Menu();
                chon = int.Parse(Console.ReadLine());
                if (chon == 0) break;
                Console.Clear();

                switch (chon)
                {
                    case 1:
                        SanPham_BLL.NhapSanPham(list);
                        Console.ReadKey();
                        Console.Clear();
                        SanPham_DAL.GhiFile(list);
                        break;
                    case 2:
                        SanPham_BLL.HienSanPham(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        SanPham_BLL.TimKiem(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        SanPham_BLL.Sua(list);
                        SanPham_DAL.GhiFile(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        SanPham_BLL.Xoa(list);
                        SanPham_DAL.GhiFile(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;

                }
            }
        }
    }
}
