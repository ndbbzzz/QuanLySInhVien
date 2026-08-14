using QuanLySinhVien.Models;
using QuanLySinhVien.Services;

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
    Console.WriteLine("0. Thoat");

    Console.Write("Chon chuc nang: ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        // 1. Them sinh vien
        case "1":
            Console.WriteLine("\n--- THEM SINH VIEN ---");

            Console.Write("Ma sinh vien: ");
            string? maSinhVien = Console.ReadLine();

            Console.Write("Ho ten: ");
            string? hoTen = Console.ReadLine();

            Console.Write("Ngay sinh (dd/MM/yyyy): ");
            DateTime ngaySinh = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Gioi tinh: ");
            string? gioiTinh = Console.ReadLine();

            Console.Write("Email: ");
            string? email = Console.ReadLine();

            Console.Write("So dien thoai: ");
            string? soDienThoai = Console.ReadLine();

            Console.Write("Nganh hoc: ");
            string? nganhHoc = Console.ReadLine();

            Console.Write("Diem trung binh: ");
            double diemTrungBinh = double.Parse(Console.ReadLine()!);

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


        // 2. Hien thi danh sach
        case "2":
            Console.WriteLine("\n--- DANH SACH SINH VIEN ---");

            service.DisplayStudents();

            break;


        // 3. Tim sinh vien theo ma
        case "3":
            Console.WriteLine("\n--- TIM SINH VIEN THEO MA ---");

            Console.Write("Nhap ma sinh vien: ");
            string? maTim = Console.ReadLine();

            service.FindStudentById(maTim!);

            break;


        // 4. Tim gan dung theo ho ten
        case "4":
            Console.WriteLine("\n--- TIM SINH VIEN THEO TEN ---");

            Console.Write("Nhap ho ten can tim: ");
            string? tenTim = Console.ReadLine();

            service.FindStudentByName(tenTim!);

            break;


        // 5. Cap nhat sinh vien
        case "5":
            Console.WriteLine("\n--- CAP NHAT SINH VIEN ---");

            Console.Write("Nhap ma sinh vien can cap nhat: ");
            string? maCapNhat = Console.ReadLine();

            Console.Write("Ho ten moi: ");
            string? hoTenMoi = Console.ReadLine();

            Console.Write("Ngay sinh moi (dd/MM/yyyy): ");
            DateTime ngaySinhMoi = DateTime.Parse(Console.ReadLine()!);

            Console.Write("Gioi tinh moi: ");
            string? gioiTinhMoi = Console.ReadLine();

            Console.Write("Email moi: ");
            string? emailMoi = Console.ReadLine();

            Console.Write("So dien thoai moi: ");
            string? soDienThoaiMoi = Console.ReadLine();

            Console.Write("Nganh hoc moi: ");
            string? nganhHocMoi = Console.ReadLine();

            Console.Write("Diem trung binh moi: ");
            double diemTrungBinhMoi = double.Parse(Console.ReadLine()!);

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


        // 6. Xoa sinh vien
        case "6":
            Console.WriteLine("\n--- XOA SINH VIEN ---");

            Console.Write("Nhap ma sinh vien can xoa: ");
            string? maXoa = Console.ReadLine();

            service.DeleteStudentById(maXoa!);

            break;


        // 0. Thoat
        case "0":
            Console.WriteLine("Da thoat chuong trinh.");
            return;


        default:
            Console.WriteLine("Lua chon khong hop le.");
            break;
    }
}