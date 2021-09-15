using System;
using System.Collections.Generic;

namespace Lab02_Bai_1
{
    class Bai_1
    {
        static void XuatMang(List<string> M)
        {
            string chuoi = string.Join(", ", M);
            // Join them , moi 1 phan tu cua M
            Console.WriteLine(chuoi);
        }
        static void Main(string[] args)
        {
            // List phuong thuc ho tro san
            // List<kdl> ten = new List<kdl>();
            List<string> mang = new List<string>();
            string tmp;
            Console.WriteLine("Tien hanh nhap chuoi. Neu muon dung hay bam stop.");
            //nhập chuỗi đưa vào mảng cho tới khi gặp STOP
            while (true)
            {
                Console.Write("Chuoi nhap thu {0}: ", mang.Count + 1);
                tmp = Console.ReadLine().Trim();
                if (tmp.ToUpper() == "STOP")
                {
                    break;//thoat while
                }
                //them vao mang
                mang.Add(tmp);
                Console.WriteLine("Count = {0}, Capacity = {1}", mang.Count, mang.Capacity);
                // Capacity giup mang tu dong tang so luong tu co the chua
            }//end while
            XuatMang(mang);
            // Nhap chuoi can tim
            Console.Write("Can tim: ");
            tmp = Console.ReadLine().Trim();
            // Trim xoa khoang trang dau va cuoi

            if (mang.Contains(tmp))
            {//true: co chua
                Console.WriteLine(" true");
            }
            else
                Console.WriteLine(" false");// false: khong chua

            // Nhap chuoi can xoa
            Console.Write("Can xoa: ");
            tmp = Console.ReadLine().Trim();

            if (mang.Contains(tmp))
            {
                Console.WriteLine("Tim thay {0} tai vi tri {1}", tmp, mang.IndexOf(tmp));
                mang.Remove(tmp);
                Console.WriteLine("Sau khi xoa: ");
                XuatMang(mang);
                Console.WriteLine("Sau khi xoa, mang con {0} phan tu", mang.Count);
            }
            else
                Console.WriteLine("Khong co phan tu do trong mang.");
            
            // Them 1 phan tu tu 1 vi tri bat ky
            Console.Write("Nhap vi tri muon them: ");
            int idx = int.Parse(Console.ReadLine());
            Console.Write("Nhap chuoi can them: ");
            tmp = Console.ReadLine().Trim();

            mang.Insert(idx, tmp);
            Console.WriteLine("Sau khi them, mang co {0} phan tu", mang.Count);

            XuatMang(mang);

            
        }
    }
}
