using QuanLyHangTon.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHangTon.BusinessLogic
{
    class SanPham_BLL
    {
        public void NhapSanPham(List<SanPham> list)
        {
            while (true)
            {
                SanPham sanPham = new SanPham();
                sanPham.Nhap(list);
                list.Add(sanPham);
                Console.WriteLine("Bạn muốn nhập tiếp không?C/K");
                string chon = Console.ReadLine();
                if (chon == "k" || chon == "K") break;

            }
        }
        public void HienSanPham(List<SanPham> list)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã sản phẩm", "Tên sản phẩm", "Số lượng", "Giá bán", "Đơn vị tính");
            foreach(SanPham sanPham in list)
            {
                sanPham.Display();
            }
        }
        public SanPham TimSanPham(List<SanPham> list)
        {
            SanPham sanPham = null;
            Console.WriteLine("Nhập từ khóa: ");
            string tukhoa = Console.ReadLine();
            foreach(SanPham sp in list)
            {
                if (tukhoa.Equals(sp.Tensanpham) || tukhoa.Equals(sp.Masanpham))
                {
                    sanPham = sp;
                }
            }
            return sanPham;
        }
        public void TimKiem(List<SanPham> list)
        {
            SanPham sanPham = TimSanPham(list);
            if (sanPham == null)
            {
                Console.WriteLine("Không tìm thấy sản phẩm");
            }
            else
            {
                sanPham.Display();
            }
        }
        public void Xoa(List<SanPham> list)
        {
            SanPham sanPham = TimSanPham(list);
            if (sanPham == null)
            {
                Console.WriteLine("Không tìm thấy sản phẩm");
            }
            else
            {
                list.Remove(sanPham);
            }
        }
        public void Sua(List<SanPham> list)
        {
            SanPham sanPham = TimSanPham(list);
            if (sanPham == null)
            {
                Console.WriteLine("Không tìm thấy sản phẩm");
            }
            else
            {
                sanPham.Nhap(list);
            }
        }
    }
}
