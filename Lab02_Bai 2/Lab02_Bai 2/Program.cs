using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Lab02_Bai_2
{
    class Program
    {

        struct HangHoa
        {
            public int MaHH;
            public string TenHH;
            public int SoLuong;
            public double DonGia;


            public void Tao(int MaHH, string TenHH, int SoLuong, double DonGia)
            {
                this.MaHH = MaHH;
                this.TenHH = TenHH;
                this.SoLuong = SoLuong;
                this.DonGia = DonGia;
            }
        }
        static double ThanhTien(int SoLuong, double DonGia)
        {
            return SoLuong * DonGia;
        }

        static void Them(List<HangHoa> N, HangHoa M)
        {
            Console.WriteLine("Them mot mat hang vao danh sach: ");
            M = Nhap(M, N.Count + 1); // vì 1 số lý do nào đó nên phải gán thên N = mới nhận giá trị
            N.Add(M); // thêm M vào list N
        }

        static bool Find(List<HangHoa> N, int M)
        {
            for (int i = 0; i < N.Count; i++)
            {
                if (N[i].MaHH == M)
                {
                    M = i; // lấy vị trí để tiến hành xóa at
                    return true; // so sánh 2 mã hàng hóa trùng nhau không
                }
            }
            return false;
        }

        static HangHoa Nhap(HangHoa N, int i)
        {
            Console.WriteLine("Mat hang thu {0} gom: ", i);
            Console.Write("Ma hang hoa: ");
                N.MaHH = int.Parse(Console.ReadLine());
            Console.Write("Ten hang hoa: ");
                N.TenHH = Console.ReadLine();
            Console.Write("So luong cua hang hoa: ");
                N.SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Don gia cua hang hoa: ");
                N.DonGia = double.Parse(Console.ReadLine());
            return N;
        }

        static void Xuat(List<HangHoa> N)
        {
            for (int i = 0; i < N.Count; i++)
            {
                Console.Write("Mat hang thu {0}: ", i + 1);
                Console.WriteLine("{0} - {1} - SL: {2} - DG: {3} = {4}", N[i].MaHH, N[i].TenHH, N[i].SoLuong, N[i].DonGia, ThanhTien(N[i].SoLuong, N[i].DonGia));
            }
        }

        static void Xoa(List<HangHoa> N, int M)
        {
            if (Find(N, M))
            {
                N.RemoveAt(M - 1);
                if (N.Count == 0) Console.WriteLine("Xoa thanh cong. Nhung khong con san pham nao trong danh sach.");
                else
                {
                    Console.WriteLine("Xoa thanh cong. Danh sach mat hang sau khi xoa la: ");
                    Xuat(N);
                }
            }
            else
            {
                Console.WriteLine("Xoa that bai. Khong co mat hang do trong danh sach. ");
                //Xuat(N);
            }
        }

        static void Main(string[] args)
        {
            List<HangHoa> HH = new List<HangHoa>();
            HangHoa N = new HangHoa();
            Console.WriteLine("Nhap danh sach cac mat hang: ");
            Them(HH, N);

            while (true)
            {
                Console.WriteLine("Ban muon nhap them hang hoa khong? yes/no");
                string tmp = Console.ReadLine();
                if (tmp == "no") break;
                else
                {
                    Them(HH, N);
                }
            }
              
            Console.WriteLine("Danh sach cac mat hang hien co: ");
            Xuat(HH);

            Console.WriteLine("Tien hanh xoa mot mat hang: ");
            Console.Write("Hay chon 1 ma hang de xoa: ");
            int thaythe = int.Parse(Console.ReadLine());

            Xoa(HH, thaythe);

        }
    }
}

