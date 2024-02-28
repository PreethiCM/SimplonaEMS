using System;
using System.Web.Http;
using BusinessLogicLayer;
using DataAccessLayer.Entities;

namespace WebApi.Controllers
{
    [RoutePrefix("api/employees")]
    public class EmployeeController : ApiController
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddEmployee(EmpProfile employee)
        {
            try
            {
                _employeeService.AddEmployee(employee);
                return Ok("Employee added successfully");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("getall")]
        public IHttpActionResult GetAllEmployees()
        {
            try
            {
                var employees = _employeeService.GetAllEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // Add other CRUD operations as needed
    }
}
