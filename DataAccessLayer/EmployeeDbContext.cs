using DataAccessLayer.Entities;
using System.Data.Entity;

namespace DataAccessLayer.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("name=EmployeeDbContext")
        {
        }

        public DbSet<DeptMaster> DeptMasters { get; set; }
        public DbSet<EmpProfile> EmpProfiles { get; set; }
    }
}
