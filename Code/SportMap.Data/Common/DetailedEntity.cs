namespace SportMap.Data.Common;

public abstract class DetailedEntity : BaseEntity {
    public virtual string Details { get; set; } = "";
}
