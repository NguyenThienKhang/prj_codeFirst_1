namespace prj_codeFirst_02.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<prj_codeFirst_02.QLSVDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(prj_codeFirst_02.QLSVDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.KHOAs.Add(new KHOA { MaKH = "AV", TenKH = "Anh văn" });
            context.KHOAs.Add(new KHOA { MaKH = "TH", TenKH = "Tin học" });
            context.KHOAs.Add(new KHOA { MaKH = "KT", TenKH = "Kinh tế" });
            context.SINHVIENs.Add(new SINHVIEN { MaSV = "A01", HoSV = "Nguyễn Văn", TenSV = "Hùng", Phai = true, NgaySinh = new DateTime(2002, 8, 12), NoiSinh = "Tiền Giang", MaKH = "TH", HocBong = 120000 });
            context.SINHVIENs.Add(new SINHVIEN { MaSV = "A02", HoSV = "Nguyễn Văn", TenSV = "Tuấn", Phai = true, NgaySinh = new DateTime(2002, 9, 16), NoiSinh = "Hậu Giang", MaKH = "TH", HocBong = 130000 });
            context.SINHVIENs.Add(new SINHVIEN { MaSV = "A03", HoSV = "Nguyễn Văn", TenSV = "Hậu", Phai = true, NgaySinh = new DateTime(2002, 12, 02), NoiSinh = "Kiên Giang", MaKH = "TH", HocBong = 140000 });
            context.SINHVIENs.Add(new SINHVIEN { MaSV = "B01", HoSV = "Nguyễn Thị", TenSV = "Lan", Phai = false, NgaySinh = new DateTime(2002, 3, 2), NoiSinh = "Sài Gòn", MaKH = "AV", HocBong = 220000 });
            context.SINHVIENs.Add(new SINHVIEN { MaSV = "B02", HoSV = "Nguyễn Thị", TenSV = "Cúc", Phai = false, NgaySinh = new DateTime(2002, 4, 22), NoiSinh = "Hà Nội", MaKH = "AV", HocBong = 220000 });
            context.MONHOCs.Add(new MONHOC { MaMH = "01", TenMH = "Kỹ thuật lập trình", SoTiet = 90 });
            context.MONHOCs.Add(new MONHOC { MaMH = "02", TenMH = "Lập trình Java", SoTiet = 75 });
            context.MONHOCs.Add(new MONHOC { MaMH = "03", TenMH = "Thiết kế Web", SoTiet = 60 });
            context.KETQUAs.Add(new KETQUA { MaSV = "A01", MaMH = "01", Diem = 8 });
            context.KETQUAs.Add(new KETQUA { MaSV = "A01", MaMH = "02", Diem = 9 });
            context.KETQUAs.Add(new KETQUA { MaSV = "A01", MaMH = "03", Diem = 10 });
            context.KETQUAs.Add(new KETQUA { MaSV = "A02", MaMH = "01", Diem = 6 });
            context.KETQUAs.Add(new KETQUA { MaSV = "A02", MaMH = "02", Diem = 7 });
            context.KETQUAs.Add(new KETQUA { MaSV = "B01", MaMH = "02", Diem = 9 });
            context.KETQUAs.Add(new KETQUA { MaSV = "B01", MaMH = "03", Diem = 8 });

        }
    }
}
