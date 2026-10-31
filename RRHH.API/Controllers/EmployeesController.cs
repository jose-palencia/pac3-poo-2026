
using Microsoft.AspNetCore.Mvc;
using RRHH.API.Entities;

namespace RRHH.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly List<EmployeeEntity> _employees;

        public EmployeesController()
        {
            _employees = new List<EmployeeEntity>();

            _employees.Add(new EmployeeEntity{ Id = 1, FirstName = "Juan", LastName = "Perez", DNI = "0401-2000-00001", Gender = "M" });
            _employees.Add(new EmployeeEntity{ Id = 2, FirstName = "Maria", LastName = "Rodriguez", DNI = "0401-2000-00002", Gender = "F" });
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employees);
        }

        [HttpGet("{dni}")]
        public IActionResult GetOne(string dni)
        {
            // EmployeeEntity emp = new EmployeeEntity();

            // foreach (var employee in _employees)
            // {
            //     if(employee.DNI != null && employee.DNI.Equals(dni))
            //     {
            //         emp = employee;
            //     }
            // }

            //var emp = _employees.FirstOrDefault(e => e.DNI == dni);

            return Ok(_employees.FirstOrDefault(e => e.DNI == dni));
        }

        [HttpPost]
        public IActionResult Post([FromBody] EmployeeEntity employee)
        {
            _employees.Add(employee);

            return Ok(new {id = employee.Id});
        }

        [HttpPut("{dni}")]
        public IActionResult Put(string dni, [FromBody] EmployeeEntity employee)
        {
            var oldEmployee = _employees.FirstOrDefault(e => e.DNI == dni);

            if(oldEmployee != null)
            {
                _employees.Remove(oldEmployee);
                _employees.Add(employee);
            }

            return Ok(_employees);
        }

        [HttpDelete("{dni}")]
        public IActionResult Delete(string dni)
        {
            var oldEmployee = _employees.FirstOrDefault(e => e.DNI == dni);

            if(oldEmployee != null)
            {
                _employees.Remove(oldEmployee);
            }

            return Ok(_employees);
        }
    }
}