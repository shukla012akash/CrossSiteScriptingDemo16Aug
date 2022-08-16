using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XSSDemo16Aug.Models;

namespace XSSDemo16Aug.Data
{
    public class XSSDemo16AugContext : DbContext
    {
        public XSSDemo16AugContext (DbContextOptions<XSSDemo16AugContext> options)
            : base(options)
        {
        }

        public DbSet<XSSDemo16Aug.Models.Employee> Employee { get; set; } = default!;
    }
}
