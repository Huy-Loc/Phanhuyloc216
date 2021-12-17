using System;
using System.ComponentModel.DataAnnotations;

namespace PhanHuyLoc216.Models
{
    public class UniversityPHL216
    {
        [Key]
        [StringLength(20)]
        public string UniversityId { get; set; }
        [StringLength(50)]
        public string UniversityName { get; set; }
        
    }
}