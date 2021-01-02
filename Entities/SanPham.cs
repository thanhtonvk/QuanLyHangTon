using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHangTon.Entities
{
    class SanPham
    {
        private string masanpham, tensanpham, donvitinh;
        private int soluong;
        private double giaban;
        public SanPham()
        {

        }
        public SanPham(string masanpham,string tensanpham,int soluong,double giaban,string donvitinh)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.donvitinh = donvitinh;
            this.soluong = soluong;
            this.giaban = giaban;
        }
        public string nhapChuoi()
        {
            string str = Console.ReadLine();
            while (true)
            {
                if (str != "") break;
                else
                {
                    Console.WriteLine("Chuỗi phải khác rỗng");
                    str = Console.ReadLine();
                }
            }
            return str;
        }
        public void Nhap(List<SanPham>list)
        {
            masanpham = "SP0" + list.Count;
            Console.WriteLine("Nhập tên sản phẩm: ");
            tensanpham = nhapChuoi();
            Console.WriteLine("Nhập số lượng: ");
            soluong = int.Parse(nhapChuoi());
            Console.WriteLine("Nhập giá bán: ");
            giaban = double.Parse(nhapChuoi());
            Console.WriteLine("Nhập đơn vị tính: ");
            donvitinh = nhapChuoi();
        }
        public void Display()
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", masanpham, tensanpham, soluong, giaban, donvitinh);
        }
        public override string ToString()
        {
            return masanpham + "#" + tensanpham + "#" + soluong + "#" + giaban + "#" + donvitinh;
        }
        public string Masanpham { get => masanpham; set => masanpham = value; }
        public string Tensanpham { get => tensanpham; set => tensanpham = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Giaban { get => giaban; set => giaban = value; }
    }
}
