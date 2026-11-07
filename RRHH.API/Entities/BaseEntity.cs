using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RRHH.API.Entities
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
        
        [Column("created_by_id")]
        public string? CreatedById { get; set; }
        
        [Column("updated_date")]
        public DateTime UpdatedDate { get; set; }
        
        [Column("updated_by_id")]
        public string? UpdatedById { get; set; }
    }
}