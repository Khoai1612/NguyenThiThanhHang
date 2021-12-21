using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiThanhHang_04.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        [Display(Name = "Mã Nhân Viên")]
        public int MaNhanVien { get; set; }
        [Display(Name = "Tên Nhân Viên ")]
        [StringLength(50)]
        public string TenNhanVien { get; set; }
        [Display(Name = "Mã Tỉnh Thành")]
        public int MaTinhThanh { get; set; }
        [ForeignKey("MaTinhThanh")]
        public virtual TinhThanh TinhThanh { get; set; }
    }  
}