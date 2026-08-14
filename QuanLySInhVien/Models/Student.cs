using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySInhVien.Models
{
    public class Student
    {
        public string MaSinhVien { get; set; } = "";
        public string HoTen { get; set; } = "";
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; } = "";
        public string Email { get; set; } = "";
        public string SoDienThoai { get; set; } = "";
        public string NganhHoc { get; set; } = "";
        public double DiemTrungBinh { get; set; }
        public string TrangThaiHocTap { get; set; } = "";

        public Student() { }
        public Student(
         string maSinhVien,
         string hoTen,
         DateTime ngaySinh,
         string gioiTinh,
         string email,
         string soDienThoai,
         string nganhHoc,
         double diemTrungBinh,
         string trangThaiHocTap)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Email = email;
            SoDienThoai = soDienThoai;
            NganhHoc = nganhHoc;
            DiemTrungBinh = diemTrungBinh;
            TrangThaiHocTap = trangThaiHocTap;
        }
    }
}
