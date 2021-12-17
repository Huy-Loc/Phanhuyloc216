using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhanHuyLoc216.Models;
namespace PhanHuyLoc216.Data{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }


        

        public DbSet<PhanHuyLoc216.Models.UniversityPHL216> University { get; set; }
         public DbSet<DinhTheAnh082.Models.PHL0216> PHL216 { get; set; }

       
    }
}