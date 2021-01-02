using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyHangTon.Entities;
namespace QuanLyHangTon.DataAccess
{
    class NhapKho_DAL
    {
        string path = "NhapKho.txt";
        public void DocFile(List<NhapKho> list)
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
                        list.Add(new NhapKho(arr[0], arr[1], arr[2], int.Parse(arr[3]), double.Parse(arr[4])));
                    }
                    streamReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Không đọc được file");
                }
            }
        }
        public void GhiFile(List<NhapKho> list)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach(NhapKho nhapKho in list)
            {
                streamWriter.WriteLine(nhapKho.ToString());
            }
            streamWriter.Close();
        }
    }
}
