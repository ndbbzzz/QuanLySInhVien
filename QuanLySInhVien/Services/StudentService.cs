using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Data;
using QuanLySinhVien.Models;
using QuanLySinhVien.Validators;

namespace QuanLySinhVien.Services;

public class StudentService
{   
    //them sinh vien
    public bool AddStudent(Student student)
    {
        if (!StudentValidators.IsValidStudent(student))
        {
            return false;
        }

        if (StudentData.Students.Any(s => s.MaSinhVien == student.MaSinhVien))
        {
            Console.WriteLine("Ma sinh vien da ton tai.");
            return false;
        }

        StudentData.Students.Add(student);

        Console.WriteLine("Them sinh vien thanh cong.");
        return true;
    }
    //hien thi danh sach sinh vien
    public void DisplayStudents()
    {
        if (StudentData.Students.Count == 0)
        {
            Console.WriteLine("Danh sach sinh vien trong.");
            return;
        }
        Console.WriteLine("Danh sach sinh vien:");
        for(int i=0; i< StudentData.Students.Count; i++)
        {
            var student = StudentData.Students[i];
            Console.WriteLine($"{i + 1}. Ma sinh vien: {student.MaSinhVien}, Ho ten: {student.HoTen}, Ngay sinh: {student.NgaySinh.ToShortDateString()}, Gioi tinh: {student.GioiTinh}, Email: {student.Email}, So dien thoai: {student.SoDienThoai}, Nganh hoc: {student.NganhHoc}, Diem trung binh: {student.DiemTrungBinh}, Trang thai hoc tap: {student.TrangThaiHocTap}");
        }
    }
    //tim sinh vien theo ma sinh vien
    public void FindStudentById(string maSinhVien)
    {
        var student = StudentData.Students.FirstOrDefault(s => s.MaSinhVien == maSinhVien);
        //firstOrDefault tra ve null neu khong tim thay sinh vien voi ma sinh vien nay(bdau tu sinh vien dau tien)
        if (student == null)
        {
            Console.WriteLine("Khong tim thay sinh vien voi ma sinh vien nay.");
            return;
        }
        Console.WriteLine($"Ma sinh vien: {student.MaSinhVien}, Ho ten: {student.HoTen}, Ngay sinh: {student.NgaySinh.ToShortDateString()}, Gioi tinh: {student.GioiTinh}, Email: {student.Email}, So dien thoai: {student.SoDienThoai}, Nganh hoc: {student.NganhHoc}, Diem trung binh: {student.DiemTrungBinh}, Trang thai hoc tap: {student.TrangThaiHocTap}");
    }
    //xoa sinh vien theo ma sinh vien
    public void DeleteStudentById(string maSinhVien)
    {
        var student = StudentData.Students.FirstOrDefault(s => s.MaSinhVien == maSinhVien);
        if (student == null)
        {
            Console.WriteLine("Khong tim thay sinh vien voi ma sinh vien nay.");
            return;
        }
        StudentData.Students.Remove(student);
        Console.WriteLine("Xoa sinh vien thanh cong.");
    }
    //tim gan theo ho ten
    public void FindStudentByName(string hoTen)
    {
        var students = StudentData.Students.Where(s => s.HoTen.Contains(hoTen, StringComparison.OrdinalIgnoreCase)).ToList();
        if (students.Count == 0)
        {
            Console.WriteLine("Khong tim thay sinh vien voi ho ten nay.");
            return;
        }
        Console.WriteLine("Danh sach sinh vien tim thay:");
        for (int i = 0; i < students.Count; i++)
        {
            var student = students[i];
            Console.WriteLine($"{i + 1}. Ma sinh vien: {student.MaSinhVien}, Ho ten: {student.HoTen}, Ngay sinh: {student.NgaySinh.ToShortDateString()}, Gioi tinh: {student.GioiTinh}, Email: {student.Email}, So dien thoai: {student.SoDienThoai}, Nganh hoc: {student.NganhHoc}, Diem trung binh: {student.DiemTrungBinh}, Trang thai hoc tap: {student.TrangThaiHocTap}");
        }
    }
    //cap nhat sinh vien theo ma sinh vien
    public void UpdateStudentById(string maSinhVien, Student updatedStudent)
    {
        var student = StudentData.Students.FirstOrDefault(s => s.MaSinhVien == maSinhVien);
        if (student == null)
        {
            Console.WriteLine("Khong tim thay sinh vien voi ma sinh vien nay.");
            return;
        }
        if (!StudentValidators.IsValidStudent(updatedStudent))
        {
            return;
        }
        student.HoTen = updatedStudent.HoTen;
        student.NgaySinh = updatedStudent.NgaySinh;
        student.GioiTinh = updatedStudent.GioiTinh;
        student.Email = updatedStudent.Email;
        student.SoDienThoai = updatedStudent.SoDienThoai;
        student.NganhHoc = updatedStudent.NganhHoc;
        student.DiemTrungBinh = updatedStudent.DiemTrungBinh;
        student.TrangThaiHocTap = updatedStudent.TrangThaiHocTap;
        Console.WriteLine("Cap nhat sinh vien thanh cong.");
    }
}

