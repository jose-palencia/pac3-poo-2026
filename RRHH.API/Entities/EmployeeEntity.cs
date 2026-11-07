using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RRHH.API.Entities
{
    [Table("employees")]
    public class EmployeeEntity : BaseEntity
    {
        [Required]
        [Column("first_name")]
        public string? FirstName { get; set; }
        
        [Required]
        [Column("last_name")]
        public string? LastName { get; set; }
        
        [Required]
        [Column("dni")]
        public string? DNI { get; set; }
        
        [Column("gender")]
        public string? Gender { get; set; }
    }
}