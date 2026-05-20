using SportMap.Aids;

namespace SportMap.Data.Common;

public abstract class NamedEntity : DetailedEntity {
    [Random(5, 11)] public virtual string Name { get; set; } = "";
    [Random(3, 6, "ABCDEF")] public virtual string Code { get; set; } = "";
}
