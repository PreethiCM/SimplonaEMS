using DataAccessLayer.Entities;
using System.Data.Entity;

namespace DataAccessLayer.Context
{
    public class EmployeeDbInitializer : DropCreateDatabaseIfModelChanges<EmployeeDbContext>
    {
        protected override void Seed(EmployeeDbContext context)
        {
            // Seed initial data for DeptMaster table
            context.DeptMasters.Add(new DeptMaster { DeptCode = 1, DeptName = "IT" });
            context.DeptMasters.Add(new DeptMaster { DeptCode = 2, DeptName = "HR" });
            // Add more initial data as needed

            base.Seed(context);
        }
    }
}
