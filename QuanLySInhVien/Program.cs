using QuanLySinhVien.Models;
using QuanLySinhVien.Services;
// Nguyễn Đức Bảo Bình-241230664 CNTT2-k65
StudentService service = new StudentService();

while (true)
{
    Console.WriteLine("\n===== QUAN LY SINH VIEN =====");
    Console.WriteLine("1. Them sinh vien");
    Console.WriteLine("2. Hien thi danh sach sinh vien");
    Console.WriteLine("3. Tim sinh vien theo ma sinh vien");
    Console.WriteLine("4. Tim gan dung theo ho ten");
    Console.WriteLine("5. Cap nhat sinh vien");
    Console.WriteLine("6. Xoa sinh vien");
    Console.WriteLine("7. Sap xep sinh vien theo ho ten");
    Console.WriteLine("8. Sap xep sinh vien theo diem trung binh");
    Console.WriteLine("9. Hien thi sinh vien co GPA tu 8 tro len");
    Console.WriteLine("10. Hien thi sinh vien co GPA cao nhat");
    Console.WriteLine("11. Tinh GPA trung binh");
    Console.WriteLine("12. Thong ke sinh vien theo nganh hoc");
    Console.WriteLine("13. Thong ke sinh vien theo trang thai hoc tap");
    Console.WriteLine("0. Thoat");

    Console.Write("\nChon chuc nang: ");
    string? choice = Console.ReadLine();

    switch (choice)
    { 
        // 1. THEM SINH VIEN
      
        case "1":
            Console.WriteLine("\n--- THEM SINH VIEN ---");

            Console.Write("Ma sinh vien: ");
            string? maSinhVien = Console.ReadLine();

            Console.Write("Ho ten: ");
            string? hoTen = Console.ReadLine();

            Console.Write("Ngay sinh (dd/MM/yyyy): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime ngaySinh))
            {
                Console.WriteLine("Ngay sinh khong hop le.");
                break;
            }

            Console.Write("Gioi tinh: ");
            string? gioiTinh = Console.ReadLine();

            Console.Write("Email: ");
            string? email = Console.ReadLine();

            Console.Write("So dien thoai: ");
            string? soDienThoai = Console.ReadLine();

            Console.Write("Nganh hoc: ");
            string? nganhHoc = Console.ReadLine();

            Console.Write("Diem trung binh: ");
            if (!double.TryParse(Console.ReadLine(), out double diemTrungBinh))
            {
                Console.WriteLine("Diem trung binh khong hop le.");
                break;
            }

            Console.Write("Trang thai hoc tap: ");
            string? trangThaiHocTap = Console.ReadLine();

            Student student = new Student
            {
                MaSinhVien = maSinhVien!,
                HoTen = hoTen!,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh!,
                Email = email!,
                SoDienThoai = soDienThoai!,
                NganhHoc = nganhHoc!,
                DiemTrungBinh = diemTrungBinh,
                TrangThaiHocTap = trangThaiHocTap!
            };

            service.AddStudent(student);
            break;


       
        // 2. HIEN THI DANH SACH
 
        case "2":
            Console.WriteLine("\n--- DANH SACH SINH VIEN ---");

            service.DisplayStudents();
            break;

 
        // 3. TIM THEO MA
       
        case "3":
            Console.WriteLine("\n--- TIM SINH VIEN THEO MA ---");

            Console.Write("Nhap ma sinh vien: ");
            string? maTim = Console.ReadLine();

            service.FindStudentById(maTim!);
            break;


    
        // 4. TIM GAN DUNG THEO TEN
     
        case "4":
            Console.WriteLine("\n--- TIM SINH VIEN THEO TEN ---");

            Console.Write("Nhap ho ten can tim: ");
            string? tenTim = Console.ReadLine();

            service.FindStudentByName(tenTim!);
            break;


       
        // 5. CAP NHAT
        
        case "5":
            Console.WriteLine("\n--- CAP NHAT SINH VIEN ---");

            Console.Write("Nhap ma sinh vien can cap nhat: ");
            string? maCapNhat = Console.ReadLine();

            Console.Write("Ho ten moi: ");
            string? hoTenMoi = Console.ReadLine();

            Console.Write("Ngay sinh moi (dd/MM/yyyy): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime ngaySinhMoi))
            {
                Console.WriteLine("Ngay sinh khong hop le.");
                break;
            }

            Console.Write("Gioi tinh moi: ");
            string? gioiTinhMoi = Console.ReadLine();

            Console.Write("Email moi: ");
            string? emailMoi = Console.ReadLine();

            Console.Write("So dien thoai moi: ");
            string? soDienThoaiMoi = Console.ReadLine();

            Console.Write("Nganh hoc moi: ");
            string? nganhHocMoi = Console.ReadLine();

            Console.Write("Diem trung binh moi: ");
            if (!double.TryParse(Console.ReadLine(), out double diemTrungBinhMoi))
            {
                Console.WriteLine("Diem trung binh khong hop le.");
                break;
            }

            Console.Write("Trang thai hoc tap moi: ");
            string? trangThaiMoi = Console.ReadLine();

            Student updatedStudent = new Student
            {
                MaSinhVien = maCapNhat!,
                HoTen = hoTenMoi!,
                NgaySinh = ngaySinhMoi,
                GioiTinh = gioiTinhMoi!,
                Email = emailMoi!,
                SoDienThoai = soDienThoaiMoi!,
                NganhHoc = nganhHocMoi!,
                DiemTrungBinh = diemTrungBinhMoi,
                TrangThaiHocTap = trangThaiMoi!
            };

            service.UpdateStudentById(maCapNhat!, updatedStudent);
            break;


        
        // 6. XOA
      
        case "6":
            Console.WriteLine("\n--- XOA SINH VIEN ---");

            Console.Write("Nhap ma sinh vien can xoa: ");
            string? maXoa = Console.ReadLine();

            service.DeleteStudentById(maXoa!);
            break;


        
        // 7. SAP XEP THEO TEN
       
        case "7":
            Console.WriteLine("\n--- SAP XEP THEO HO TEN ---");

            service.SortStudentsByName();
            break;


         
        // 8. SAP XEP THEO GPA
         
        case "8":
            Console.WriteLine("\n--- SAP XEP THEO DIEM TRUNG BINH ---");

            service.SortStudentsByGPA();
            break;

             
        // 9. GPA >= 8
    
        case "9":
            Console.WriteLine("\n--- SINH VIEN CO GPA TU 8 TRO LEN ---");

            service.DisplayStudentsWithGPAAbove8();
            break;


       
        // 10. GPA CAO NHAT
        
        case "10":
            Console.WriteLine("\n--- SINH VIEN CO GPA CAO NHAT ---");

            service.DisplayStudentsWithHighestGPA();
            break;


     
        // 11. GPA TRUNG BINH
        
        case "11":
            Console.WriteLine("\n--- GPA TRUNG BINH CUA TAT CA SINH VIEN ---");

            service.AverageGPA();
            break;

 
        // 12. THONG KE THEO NGANH
      
        case "12":
            Console.WriteLine("\n--- THONG KE SINH VIEN THEO NGANH HOC ---");

            service.CountStudentsByMajor();
            break;

 
        // 13. THONG KE THEO TRANG THAI
       
        case "13":
            Console.WriteLine("\n--- THONG KE SINH VIEN THEO TRANG THAI ---");

            service.CountStudentsByStatus();
            break;

 
        // 0. THOAT
        
        case "0":
            Console.WriteLine("Da thoat chuong trinh.");
            return;
 
        default:
            Console.WriteLine("Lua chon khong hop le.");
            break;
    }
}