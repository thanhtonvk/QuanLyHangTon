using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyHangTon.Entities;
namespace QuanLyHangTon.DataAccess
{
    class SanPham_DAL
    {
        string path = "SanPham.txt";
        public void DocFile(List<SanPham> list)
        {
            if (File.Exists(path))
            {
                try
                {
                    StreamReader streamReader = new StreamReader(path);
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] arr = line.Split("#");
                        list.Add(new SanPham(arr[0], arr[1], int.Parse(arr[2]), double.Parse(arr[3]), arr[4]));
                    }
                    streamReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Không đọc được file");
                }
            }
        }
        public void GhiFile(List<SanPham> list)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (SanPham SanPham in list)
            {
                streamWriter.WriteLine(SanPham.ToString());
            }
            streamWriter.Close();
        }
    }
}
