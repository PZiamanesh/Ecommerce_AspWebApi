namespace Domain.Entities.Base
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
