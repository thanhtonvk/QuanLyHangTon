using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyHangTon.Entities;
namespace QuanLyHangTon.DataAccess
{
    class XuatKho_DAL
    {
        string path = "XuatKho.txt";
        public void DocFile(List<XuatKho> list)
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
                        list.Add(new XuatKho(arr[0], arr[1], arr[2], int.Parse(arr[3]), double.Parse(arr[4])));
                    }
                    streamReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Không đọc được file");
                }
            }
        }
        public void GhiFile(List<XuatKho> list)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (XuatKho XuatKho in list)
            {
                streamWriter.WriteLine(XuatKho.ToString());
            }
            streamWriter.Close();
        }
    }
}
