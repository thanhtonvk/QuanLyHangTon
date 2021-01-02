using System;
using System.Collections.Generic;
using System.Text;
using QuanLyHangTon.Entities;
using QuanLyHangTon.BusinessLogic;
using QuanLyHangTon.DataAccess;
namespace QuanLyHangTon.Presenation
{
    class XuatKho_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("||                      QUẢN LÝ XUẤT KHO                      ||");
            Console.WriteLine("================================================================");
            Console.WriteLine("||               1. Nhập thông tin                            ||");
            Console.WriteLine("||               2. Hiện thông tin                            ||");
            Console.WriteLine("||               3. Tìm kiếm                                  ||");
            Console.WriteLine("||               4. Sửa                                       ||");
            Console.WriteLine("||               5. Xóa                                       ||");
            Console.WriteLine("||               6. Thống kê                                  ||");
            Console.WriteLine("||               0. Thoát                                     ||");
            Console.WriteLine("================================================================");
        }
        public static void Chon(List<XuatKho> list, XuatKho_BLL XuatKho_BLL, XuatKho_DAL XuatKho_DAL)
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
                        XuatKho_BLL.NhapXuatKho(list);
                        Console.ReadKey();
                        Console.Clear();
                        XuatKho_DAL.GhiFile(list);
                        break;
                    case 2:
                        XuatKho_BLL.HienXuatKho(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        XuatKho_BLL.TimKiem(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        XuatKho_BLL.Sua(list);
                        XuatKho_DAL.GhiFile(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        XuatKho_BLL.Xoa(list);
                        XuatKho_DAL.GhiFile(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        XuatKho_BLL.ThongKeXuat(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;

                }
            }
        }
    }
}
