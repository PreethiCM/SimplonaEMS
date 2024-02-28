using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccessLayer.Context;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class EmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(EmpProfile employee)
        {
            _context.EmpProfiles.Add(employee);
            _context.SaveChanges();
        }

        public IEnumerable<EmpProfile> GetAllEmployees()
        {
            return _context.EmpProfiles.ToList();
        }

        public EmpProfile GetEmployeeByCode(int empCode)
        {
            return _context.EmpProfiles.FirstOrDefault(e => e.EmpCode == empCode);
        }

        public void UpdateEmployee(EmpProfile employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteEmployee(int empCode)
        {
            var employee = _context.EmpProfiles.FirstOrDefault(e => e.EmpCode == empCode);
            if (employee != null)
            {
                _context.EmpProfiles.Remove(employee);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Employee not found");
            }
        }
    }
}
