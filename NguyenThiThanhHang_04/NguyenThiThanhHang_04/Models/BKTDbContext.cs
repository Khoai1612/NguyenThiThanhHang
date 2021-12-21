using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NguyenThiThanhHang_04.Models
{
    public class BKTDbContext : DbContext
    {
        public BKTDbContext() : base("BKTDbContext")
        {
        }

        public DbSet<TinhThanh> TinhThanhs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
    }
}