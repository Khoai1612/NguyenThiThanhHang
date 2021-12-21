namespace NguyenThiThanhHang_04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanVien",
                c => new
                    {
                        MaNhanVien = c.Int(nullable: false, identity: true),
                        TenNhanVien = c.String(maxLength: 50),
                        MaTinhThanh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.TinhThanh", t => t.MaTinhThanh, cascadeDelete: true)
                .Index(t => t.MaTinhThanh);
            
            CreateTable(
                "dbo.TinhThanh",
                c => new
                    {
                        MaTinhThanh = c.Int(nullable: false, identity: true),
                        TenTinhThanh = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaTinhThanh);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanVien", "MaTinhThanh", "dbo.TinhThanh");
            DropIndex("dbo.NhanVien", new[] { "MaTinhThanh" });
            DropTable("dbo.TinhThanh");
            DropTable("dbo.NhanVien");
        }
    }
}
