using SportMap.Data;
using SportMap.Data.Common;

namespace SportMap.Tests;

public class CurrencyTests
{
    [Fact]
    public void Currency_InheritsFromNamedEntity()
    {
        var currency = new Currency();
        Assert.IsAssignableFrom<NamedEntity>(currency);
    }

    [Fact]
    public void Currency_InheritsFromDetailedEntity()
    {
        var currency = new Currency();
        Assert.IsAssignableFrom<DetailedEntity>(currency);
    }

    [Fact]
    public void Currency_InheritsFromBaseEntity()
    {
        var currency = new Currency();
        Assert.IsAssignableFrom<BaseEntity>(currency);
    }

    [Fact]
    public void Currency_HasGuidId()
    {
        var currency = new Currency();
        Assert.NotEqual(Guid.Empty, currency.Id);
    }

    [Fact]
    public void Currency_HasNameProperty()
    {
        var currency = new Currency { Name = "Euro" };
        Assert.Equal("Euro", currency.Name);
    }

    [Fact]
    public void Currency_HasCodeProperty()
    {
        var currency = new Currency { Code = "EUR" };
        Assert.Equal("EUR", currency.Code);
    }

    [Fact]
    public void Currency_HasNumericCodeProperty()
    {
        var currency = new Currency { NumericCode = "978" };
        Assert.Equal("978", currency.NumericCode);
    }

    [Fact]
    public void Currency_HasMajorUnitSymbolProperty()
    {
        var currency = new Currency { MajorUnitSymbol = "€" };
        Assert.Equal("€", currency.MajorUnitSymbol);
    }

    [Fact]
    public void Currency_HasMinorUnitSymbolProperty()
    {
        var currency = new Currency { MinorUnitSymbol = "c" };
        Assert.Equal("c", currency.MinorUnitSymbol);
    }

    [Fact]
    public void Currency_HasRatioOfMinorUnitProperty()
    {
        var currency = new Currency { RatioOfMinorUnit = 100.0 };
        Assert.Equal(100.0, currency.RatioOfMinorUnit);
    }

    [Fact]
    public void Currency_HasIsIsoCurrencyProperty()
    {
        var currency = new Currency { IsIsoCurrency = true };
        Assert.True(currency.IsIsoCurrency);
    }

    [Fact]
    public void Currency_DefaultStringValues_AreEmpty()
    {
        var currency = new Currency();
        Assert.Equal("", currency.Name);
        Assert.Equal("", currency.Code);
        Assert.Equal("", currency.NumericCode);
        Assert.Equal("", currency.MajorUnitSymbol);
        Assert.Equal("", currency.MinorUnitSymbol);
        Assert.Equal(0.0, currency.RatioOfMinorUnit);
        Assert.False(currency.IsIsoCurrency);
    }

    [Fact]
    public void Currency_IsSealed()
    {
        Assert.True(typeof(Currency).IsSealed);
    }
}
