using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum KieuKetQua { Dat,Khongdat}
    public class CThiSinh
    {
        protected string m_MaTS, m_HoTen;
        public string MaTS {
            get { return m_MaTS; }
            set { m_MaTS = value; }
        }
        public string HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }
        public CThiSinh()
        {
            m_MaTS = "";
            m_HoTen = "";
        }
        public CThiSinh(string ma,string ten)
        {
            m_MaTS = ma;
            m_HoTen = ten;
        }
        public virtual double TongDiem()
        {
            return 0;
        }
        public virtual KieuKetQua KetQua()
        {
            return KieuKetQua.Khongdat;
        }
        public virtual bool LaKhoiA()
        {
            return false;
        }
        public virtual bool LaKhoiNangKhieu()
        {
            return false;
        }
    }
    public class CKhoiA : CThiSinh
    {
        protected double m_DiemToan, m_DiemLy, m_DiemHoa;
        public double DiemToan
        {
            get { return m_DiemToan; }
            set
            {
                if (value < 0)
                    m_DiemToan = 0;
                else
                    m_DiemToan = value;
            }

        }    
        public double DiemLy
        {
            get { return m_DiemLy; }
            set
            {
                if (value < 0)
                    m_DiemLy = 0;
                else
                    m_DiemLy = value;
            }
        }
        public double DiemHoa
        {
            get { return m_DiemHoa; }
            set
            {
                if (value < 0)
                    m_DiemHoa = 0;
                else
                    m_DiemHoa = value;
            }
        }
        public CKhoiA() { }
        public CKhoiA(string ma,string ten,double toan,double ly,double hoa)
        {
            m_MaTS = ma;
            m_HoTen = ten;
            m_DiemToan = toan;
            m_DiemLy = ly;
            m_DiemHoa = hoa;
        }
        public override double TongDiem()
        {
            return m_DiemToan+m_DiemLy+m_DiemHoa;
        }
        public override KieuKetQua KetQua()
        {
            if (TongDiem() >= 18.5)
            {
                return KieuKetQua.Dat;
            }
            return KieuKetQua.Khongdat;
        }
        public override bool LaKhoiA()
        {
            return true;
        }
        public override bool LaKhoiNangKhieu()
        {
            return false;   
        }
    }
    class CKhoiNangKhieu : CThiSinh
    {
        protected double m_DiemToan, m_DiemNangKhieu;
        public double DiemToan
        {
            get { return m_DiemToan; }
            set
            {
                if (value < 0)
                    m_DiemToan = 0;
                else
                    m_DiemToan = value;
            }
        }
        public double DiemNangKhieu
        {
            get { return m_DiemNangKhieu; }
            set
            {
                if (value < 0)
                    m_DiemNangKhieu = 0;
                else
                    m_DiemNangKhieu = value;
            }
        }
        public CKhoiNangKhieu() { }
        public CKhoiNangKhieu(string ma,string ten,double toan,double nangkhieu)
        {
            m_MaTS = ma;
            m_HoTen = ten;
            m_DiemNangKhieu=nangkhieu;
            m_DiemToan = toan;
        }
        public override double TongDiem()
        {
            return m_DiemToan + (m_DiemNangKhieu*2.0);
        }
        public override KieuKetQua KetQua()
        {
            if (TongDiem() >= 17)
            {
                return KieuKetQua.Dat;
            }
            return KieuKetQua.Khongdat;
        }
        public override bool LaKhoiA()
        {
            return false;
        }
        public override bool LaKhoiNangKhieu()
        {
            return true;
        }
    }
}
