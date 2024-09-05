namespace pjr_codeFirst_01.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<pjr_codeFirst_01.QLPHIMDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(pjr_codeFirst_01.QLPHIMDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.theloais.Add(new THELOAI { MaTL = "TC", TenTL = "Tình cảm" });
            context.theloais.Add(new THELOAI { MaTL = "HD", TenTL = "Hành động" });
            context.theloais.Add(new THELOAI { MaTL = "KH", TenTL = "Kím hiệp" });

            context.phims.Add(new PHIM {MaPH="TC01",TenPH="Tình nhân",SoTap=8,MaTL="TC"});
            context.phims.Add(new PHIM { MaPH = "HD01", TenPH = "Đặc nhiệm macao", SoTap = 30, MaTL = "HD" });
            context.phims.Add(new PHIM { MaPH = "KH01", TenPH = "Lưu bá ôn", SoTap = 20, MaTL = "KH" });


        }
    }
}
