using System;
using System.Collections.Generic;
using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;

namespace BusinessLogicLayer
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            var context = new EmployeeDbContext();
            _employeeRepository = new EmployeeRepository(context);
        }

        public void AddEmployee(EmpProfile employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        public IEnumerable<EmpProfile> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public EmpProfile GetEmployeeByCode(int empCode)
        {
            return _employeeRepository.GetEmployeeByCode(empCode);
        }

        public void UpdateEmployee(EmpProfile employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }

        public void DeleteEmployee(int empCode)
        {
            _employeeRepository.DeleteEmployee(empCode);
        }
    }
}
