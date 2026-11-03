namespace RRHH.API.Dtos.Employees
{
    public class EmployeeOneDto
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get => $"{FirstName} {LastName}"; }
        public string? DNI { get; set; }
        public string? Gender { get; set; }
    }
}