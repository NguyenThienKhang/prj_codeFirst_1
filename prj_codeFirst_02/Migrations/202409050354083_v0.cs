namespace prj_codeFirst_02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KETQUA",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 3),
                        MaMH = c.String(nullable: false, maxLength: 2),
                        Diem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaSV, t.MaMH })
                .ForeignKey("dbo.MONHOC", t => t.MaMH, cascadeDelete: true)
                .ForeignKey("dbo.SINHVIEN", t => t.MaSV, cascadeDelete: true)
                .Index(t => t.MaSV)
                .Index(t => t.MaMH);
            
            CreateTable(
                "dbo.MONHOC",
                c => new
                    {
                        MaMH = c.String(nullable: false, maxLength: 2),
                        TenMH = c.String(maxLength: 50),
                        SoTiet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaMH);
            
            CreateTable(
                "dbo.SINHVIEN",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 3),
                        HoSV = c.String(maxLength: 50),
                        TenSV = c.String(maxLength: 10),
                        Phai = c.Boolean(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        NoiSinh = c.String(),
                        MaKH = c.String(maxLength: 2),
                        HocBong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSV)
                .ForeignKey("dbo.KHOA", t => t.MaKH)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.KHOA",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 2),
                        TenKH = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SINHVIEN", "MaKH", "dbo.KHOA");
            DropForeignKey("dbo.KETQUA", "MaSV", "dbo.SINHVIEN");
            DropForeignKey("dbo.KETQUA", "MaMH", "dbo.MONHOC");
            DropIndex("dbo.SINHVIEN", new[] { "MaKH" });
            DropIndex("dbo.KETQUA", new[] { "MaMH" });
            DropIndex("dbo.KETQUA", new[] { "MaSV" });
            DropTable("dbo.KHOA");
            DropTable("dbo.SINHVIEN");
            DropTable("dbo.MONHOC");
            DropTable("dbo.KETQUA");
        }
    }
}
