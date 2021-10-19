using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UnitTest_Mock.Models
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) :
            base(options)
        {
        }
    }
}
