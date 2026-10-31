namespace RRHH.API.Entities
{
    public class EmployeeEntity : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DNI { get; set; }
        public string? Gender { get; set; }
    }
}