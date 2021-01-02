using System;
using System.Collections.Generic;
using System.Text;
using QuanLyHangTon.Entities;
namespace QuanLyHangTon.BusinessLogic
{
    class XuatKho_BLL
    {
        public void NhapXuatKho(List<XuatKho> list)
        {
            while (true)
            {
                XuatKho XuatKho = new XuatKho();
                XuatKho.Nhap(list);
                list.Add(XuatKho);
                Console.WriteLine("Bạn muốn nhập tiếp không?C/K");
                string chon = Console.ReadLine();
                if (chon == "k" || chon == "K") break;

            }
        }
        public void HienXuatKho(List<XuatKho> list)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã báo cáo", "Ngày nhập", "Tên mặt hàng", "Số lượng", "Giá bán");
            foreach (XuatKho XuatKho in list)
            {
                XuatKho.Display();
            }
        }
        public XuatKho TimXuatKho(List<XuatKho> list)
        {
            XuatKho XuatKho = null;
            Console.WriteLine("Nhập từ khóa: ");
            string tukhoa = Console.ReadLine();
            foreach (XuatKho sp in list)
            {
                if (tukhoa.Equals(sp.Mabaocao) || tukhoa.Equals(sp.Tenmathang))
                {
                    XuatKho = sp;
                }
            }
            return XuatKho;
        }
        public void TimKiem(List<XuatKho> list)
        {
            XuatKho XuatKho = TimXuatKho(list);
            if (XuatKho == null)
            {
                Console.WriteLine("Không tìm thấy báo cáo");
            }
            else
            {
                XuatKho.Display();
            }
        }
        public void Xoa(List<XuatKho> list)
        {
            XuatKho XuatKho = TimXuatKho(list);
            if (XuatKho == null)
            {
                Console.WriteLine("Không tìm thấy báo cáo");
            }
            else
            {
                list.Remove(XuatKho);
            }
        }
        public void Sua(List<XuatKho> list)
        {
            XuatKho XuatKho = TimXuatKho(list);
            if (XuatKho == null)
            {
                Console.WriteLine("Không tìm thấy báo cáo");
            }
            else
            {
                XuatKho.Nhap(list);
            }
        }
        public void ThongKeXuat(List<XuatKho> list)
        {
            int dem=0;
            XuatKho xuatKho = TimXuatKho(list);
            if (xuatKho == null)
            {
                Console.WriteLine("Không tìm thấy báo cáo");
            }
            else
            {
                dem += xuatKho.Soluong;
                xuatKho.Display();

            }
            Console.WriteLine("Số lượng xuất là: " + dem);
        }
    }
}
