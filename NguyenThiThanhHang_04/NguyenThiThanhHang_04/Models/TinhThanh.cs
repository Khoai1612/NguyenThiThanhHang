using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenThiThanhHang_04.Models
{
    [Table("TinhThanh")]
    public class TinhThanh
    {
        [Key]
        [Display(Name ="Mã Tỉnh Thành")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTinhThanh { get; set; }
        [Display(Name = "Tên Tỉnh Thành")]
        [StringLength(50)]
        public string TenTinhThanh { get; set; }
        public ICollection<NhanVien> nhanViens { get; set; }
    }
}