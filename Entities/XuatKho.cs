using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHangTon.Entities
{
    class XuatKho
    {
        private string mabaocao, ngaynhap, tenmathang;
        private int soluong;
        private double giaban;
        public XuatKho()
        {

        }
        public XuatKho(string mabaocao, string ngaynhap, string tenmathang, int soluong, double giaban)
        {
            this.mabaocao = mabaocao;
            this.ngaynhap = ngaynhap;
            this.tenmathang = tenmathang;
            this.soluong = soluong;
            this.giaban = giaban;
        }
        public override string ToString()
        {
            return mabaocao + "#" + ngaynhap + "#" + tenmathang + "#" + soluong + "#" + giaban;
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
        public void Nhap(List<XuatKho> list)
        {
            mabaocao = "MA" + list.Count;
            Console.WriteLine("Ngày nhập: ");
            ngaynhap = nhapChuoi();
            Console.WriteLine("Tên mặt hàng");
            tenmathang = nhapChuoi();
            Console.WriteLine("Nhập số lượng");
            soluong = int.Parse(nhapChuoi());
            Console.WriteLine("Nhập giá bán");
            giaban = double.Parse(nhapChuoi());

        }
        public void Display()
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", mabaocao, ngaynhap, tenmathang, soluong, giaban);
        }
        public string Mabaocao { get => mabaocao; set => mabaocao = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Tenmathang { get => tenmathang; set => tenmathang = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Giaban { get => giaban; set => giaban = value; }
    }
}
