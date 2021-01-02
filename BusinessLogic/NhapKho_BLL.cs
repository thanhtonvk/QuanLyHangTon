using System;
using System.Collections.Generic;
using System.Text;
using QuanLyHangTon.Entities;
namespace QuanLyHangTon.BusinessLogic
{
    class NhapKho_BLL
    {
        public void NhapNhapKho(List<NhapKho> list)
        {
            while (true)
            {
                NhapKho NhapKho = new NhapKho();
                NhapKho.Nhap(list);
                list.Add(NhapKho);
                Console.WriteLine("Bạn muốn nhập tiếp không?C/K");
                string chon = Console.ReadLine();
                if (chon == "k" || chon == "K") break;

            }
        }
        public void HienNhapKho(List<NhapKho> list)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã báo cáo", "Ngày nhập", "Tên mặt hàng", "Số lượng", "Giá bán");
            foreach (NhapKho NhapKho in list)
            {
                NhapKho.Display();
            }
        }
        private NhapKho TimNhapKho(List<NhapKho> list)
        {
            NhapKho NhapKho = null;
            Console.WriteLine("Nhập từ khóa: ");
            string tukhoa = Console.ReadLine();
            foreach (NhapKho sp in list)
            {
                if (tukhoa.Equals(sp.Mabaocao) || tukhoa.Equals(sp.Tenmathang))
                {
                    NhapKho = sp;
                }
            }
            return NhapKho;
        }
        public void TimKiem(List<NhapKho> list)
        {
            NhapKho NhapKho = TimNhapKho(list);
            if (NhapKho == null)
            {
                Console.WriteLine("Không tìm thấy báo cáo");
            }
            else
            {
                NhapKho.Display();
            }
        }
        public void Xoa(List<NhapKho> list)
        {
            NhapKho NhapKho = TimNhapKho(list);
            if (NhapKho == null)
            {
                Console.WriteLine("Không tìm thấy báo cáo");
            }
            else
            {
                list.Remove(NhapKho);
            }
        }
        public void Sua(List<NhapKho> list)
        {
            NhapKho NhapKho = TimNhapKho(list);
            if (NhapKho == null)
            {
                Console.WriteLine("Không tìm thấy báo cáo");
            }
            else
            {
                NhapKho.Nhap(list);
            }
        }
        public void ThongKeNhap(List<NhapKho> list)
        {
            int dem = 0;
            NhapKho nhapKho = TimNhapKho(list);
            if (nhapKho== null)
            {
                Console.WriteLine("Không tìm thấy báo cáo");
            }
            else
            {
                dem += nhapKho.Soluong;
                nhapKho.Display();

            }
            Console.WriteLine("Số lượng xuất là: " + dem);
        }
    }
}
