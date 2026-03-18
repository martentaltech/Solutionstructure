using SportMap.Data;
using SportMap.Data.Common;

namespace SportMap.Tests;

public class CountryTests
{
    [Fact]
    public void Country_InheritsFromNamedEntity()
    {
        var country = new Country();
        Assert.IsAssignableFrom<NamedEntity>(country);
    }

    [Fact]
    public void Country_InheritsFromDetailedEntity()
    {
        var country = new Country();
        Assert.IsAssignableFrom<DetailedEntity>(country);
    }

    [Fact]
    public void Country_InheritsFromBaseEntity()
    {
        var country = new Country();
        Assert.IsAssignableFrom<BaseEntity>(country);
    }

    [Fact]
    public void Country_HasGuidId()
    {
        var country = new Country();
        Assert.NotEqual(Guid.Empty, country.Id);
    }

    [Fact]
    public void Country_HasNameProperty()
    {
        var country = new Country { Name = "Estonia" };
        Assert.Equal("Estonia", country.Name);
    }

    [Fact]
    public void Country_HasCodeProperty()
    {
        var country = new Country { Code = "EST" };
        Assert.Equal("EST", country.Code);
    }

    [Fact]
    public void Country_HasIsoCodeProperty()
    {
        var country = new Country { IsoCode = "EE" };
        Assert.Equal("EE", country.IsoCode);
    }

    [Fact]
    public void Country_HasOfficialNameProperty()
    {
        var country = new Country { OfficialName = "Republic of Estonia" };
        Assert.Equal("Republic of Estonia", country.OfficialName);
    }

    [Fact]
    public void Country_HasNativeNameProperty()
    {
        var country = new Country { NativeName = "Eesti" };
        Assert.Equal("Eesti", country.NativeName);
    }

    [Fact]
    public void Country_HasNumericCodeProperty()
    {
        var country = new Country { NumericCode = "233" };
        Assert.Equal("233", country.NumericCode);
    }

    [Fact]
    public void Country_DefaultStringValues_AreEmpty()
    {
        var country = new Country();
        Assert.Equal("", country.Name);
        Assert.Equal("", country.Code);
        Assert.Equal("", country.IsoCode);
        Assert.Equal("", country.OfficialName);
        Assert.Equal("", country.NativeName);
        Assert.Equal("", country.NumericCode);
    }

    [Fact]
    public void Country_IsSealed()
    {
        Assert.True(typeof(Country).IsSealed);
    }
}
