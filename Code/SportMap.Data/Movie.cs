using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SportMap.Aids;
using SportMap.Data.Common;

namespace SportMap.Data;

public class Movie : NamedEntity {
    [DisplayName("Title")] public override string Name { get; set; }
    [DisplayName("ReleaseDate")] public override DateTime? ValidFrom { get; set; }
    [Random(5, 15)] public string Genre { get; set; }
    [DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
    [Random(0, 5, 2)] public decimal Price { get; set; }
    public Money Money { get; set; }
    public Country Country { get; set; }
}
