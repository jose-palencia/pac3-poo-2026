using RRHH.API.Entities;

namespace RRHH.API.Services.Employees
{
    public interface IEmployeeService
    {
        EmployeeEntity GetOneEmployee(int employeeId);
    }
}