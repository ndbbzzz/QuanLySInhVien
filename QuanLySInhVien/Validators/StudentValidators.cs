using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using QuanLySinhVien.Models;
namespace QuanLySinhVien.Validators
{
    public class StudentValidators
    {
        public static bool IsValidStudent(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.MaSinhVien))
            {
                Console.WriteLine("Mã sinh viên không được để trống.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(student.HoTen))
            {
                Console.WriteLine("Họ tên khong duoc de trong.");
                return false;
            }
            if (student.DiemTrungBinh < 0 || student.DiemTrungBinh > 10)
            {
                Console.WriteLine("Diem trung binh nam trong khoang 0 den 10");
                return false;
            }
            if (string.IsNullOrWhiteSpace(student.Email) || !Regex.IsMatch(student.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Console.WriteLine("Email không được để trống va dung dinh dang .");
                return false;
            }
            if (string.IsNullOrWhiteSpace(student.SoDienThoai))
            {
                Console.WriteLine("So dien thoai khong duoc de trong.");
                return false;
            }
            return true;
        }
    } 

}
