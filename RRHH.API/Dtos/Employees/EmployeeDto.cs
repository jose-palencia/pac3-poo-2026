namespace RRHH.API.Dtos.Employees
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? DNI { get; set; }
        public string? Gender { get; set; }
    }
}