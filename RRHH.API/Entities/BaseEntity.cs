namespace RRHH.API.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedById { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? UpdatedById { get; set; }
    }
}