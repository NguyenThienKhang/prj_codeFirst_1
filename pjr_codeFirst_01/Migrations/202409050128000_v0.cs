namespace pjr_codeFirst_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PHIM",
                c => new
                    {
                        MaPH = c.String(nullable: false, maxLength: 4),
                        TenPH = c.String(maxLength: 50),
                        SoTap = c.Int(nullable: false),
                        MaTL = c.String(maxLength: 2),
                    })
                .PrimaryKey(t => t.MaPH)
                .ForeignKey("dbo.THELOAI", t => t.MaTL)
                .Index(t => t.MaTL);
            
            CreateTable(
                "dbo.THELOAI",
                c => new
                    {
                        MaTL = c.String(nullable: false, maxLength: 2),
                        TenTL = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaTL);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PHIM", "MaTL", "dbo.THELOAI");
            DropIndex("dbo.PHIM", new[] { "MaTL" });
            DropTable("dbo.THELOAI");
            DropTable("dbo.PHIM");
        }
    }
}
