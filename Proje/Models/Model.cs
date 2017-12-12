using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace EFGetStarted.AspNetCore.NewDb.Models
    {
        public class YolcuContext : DbContext
        {
            public YolcuContext(DbContextOptions<YolcuContext> options)
                : base(options)
            { }

            public DbSet<Yolcu> Yolcular { get; set; }
            public DbSet<Arac> Araclar { get; set; }
        }

        public class Yolcu
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int YolcuId { get; set; }
            public string Yolculuk { get; set; }

            public List<Yolcu> Yolcular { get; set; }
        }

        public class Arac
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int AracId { get; set; }
            public string AracAdi { get; set; }
        }
    }
}
