using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace PhanHuyLoc216.Models
{
    public class PHL0216
    {
        [Key]
        [StringLength(20)]
        [Display(Name = "Mã")]

        public string PHLID { get; set; }
        [StringLength(50)]
        [Required]
        [Display(Name = "Tên")]

        public string PHLName { get; set; }
        [Required]
        [Display(Name = "Giới Tính")]
        public Boolean PHLGender { get; set; }
    }
}