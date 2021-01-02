using System;
using System.Collections.Generic;
using System.Text;
using QuanLyHangTon.Entities;
using QuanLyHangTon.BusinessLogic;
using QuanLyHangTon.DataAccess;
namespace QuanLyHangTon.Presenation
{
    class NhapKho_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("||                      QUẢN LÝ NHẬP KHO                      ||");
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
        public static void Chon(List<NhapKho> list, NhapKho_BLL NhapKho_BLL, NhapKho_DAL NhapKho_DAL)
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
                        NhapKho_BLL.NhapNhapKho(list);
                        Console.ReadKey();
                        Console.Clear();
                        NhapKho_DAL.GhiFile(list);
                        break;
                    case 2:
                        NhapKho_BLL.HienNhapKho(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3: NhapKho_BLL.TimKiem(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        NhapKho_BLL.Sua(list);
                        NhapKho_DAL.GhiFile(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        NhapKho_BLL.Xoa(list);
                        NhapKho_DAL.GhiFile(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        NhapKho_BLL.ThongKeNhap(list);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:break;

                }
            }
        }
    }
}
