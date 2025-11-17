using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<CThiSinh> NhapDSThiSinh()
        {
            List<CThiSinh> danhsach = new List<CThiSinh>();
            Console.WriteLine("===Nhap danh sach thi sinh===");
            Console.WriteLine("Nhap x de thoat");
            while (true)
            {
                Console.Write("Nhap x de thoat hoac nhap enter de tiep tuc.");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "x")
                {
                    break;
                }
                Console.WriteLine("NHap thong tin hoc sinh.");
                Console.Write("Nhap ma hoc sinh.");
                string MaTS = Console.ReadLine();
                Console.Write("NHap ho ten hoc sinh.");
                string HoTen = Console.ReadLine();
                Console.WriteLine("Chon khoi thi:");
                Console.WriteLine("(1). Khoi A(Toan, Ly, Hoa)");
                Console.WriteLine("(2). Khoi nang khieu(Toan, Nang khieu)");
                Console.WriteLine("Hay chon 1 hoac 2");
                string chonKhoi = Console.ReadLine();
                try
                {
                    switch (chonKhoi)
                    {
                        case "1":
                            Console.Write("Nhap diem mon toan");
                            double DiemToan = double.Parse(Console.ReadLine());
                            Console.Write("Nhap diem mon ly");
                            double DiemLy = double.Parse(Console.ReadLine());
                            Console.Write("Nhap diem mon Hoa");
                            double DiemHoa = double.Parse(Console.ReadLine());
                            CKhoiA thiSinhA = new CKhoiA(MaTS, HoTen, DiemToan, DiemLy, DiemHoa);
                            if (thiSinhA.TongDiem() >= 18.5)
                            {
                                danhsach.Add(thiSinhA);
                                Console.WriteLine("Them thanh cong.");

                            }
                            else
                            {
                                Console.WriteLine("Diem du yeu cau. Them khong thanh cong.");
                            }
                            break;
                        case "2":
                            Console.Write("Nhap diem mon toan");
                            double Diemtoan = double.Parse(Console.ReadLine());
                            Console.Write("Nhap diem nang khieu");
                            double diemNangKhieu = double.Parse(Console.ReadLine());
                            CKhoiNangKhieu thiSinhB = new CKhoiNangKhieu(MaTS, HoTen, Diemtoan, diemNangKhieu);
                            if (thiSinhB.TongDiem() >= 17)
                            {
                                danhsach.Add(thiSinhB);
                                Console.WriteLine("Them thanh cong.");
                            }
                            else
                            {
                                Console.WriteLine("Diem du yeu cau. Them khong thanh cong.");
                            }
                            break;
                        default:
                            Console.WriteLine("❌ Lựa chọn không hợp lệ! Vui lòng chọn lại.");
                            continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("❌ Lỗi: Điểm phải là số! Vui lòng nhập lại thí sinh này.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Lỗi: {ex.Message}");
                }



            }
            //static int GetSoThiSinhKhoiNangKhieu(List<CThiSinh> ds)
            //{

            //}
            return danhsach;
        }
    }
}
