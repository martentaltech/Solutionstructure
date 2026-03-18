using SportMap.Aids;

namespace SportMap.Tests;

public class GetRandomTests
{
    [Fact]
    public void Int32_ReturnsValueInRange()
    {
        var result = GetRandom.Int32(1, 100);
        Assert.InRange(result, 1, 99);
    }

    [Fact]
    public void Int32_EqualMinMax_ReturnsMin()
    {
        var result = GetRandom.Int32(5, 5);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Int32_SwapsIfMinGreaterThanMax()
    {
        var result = GetRandom.Int32(100, 1);
        Assert.InRange(result, 1, 99);
    }

    [Fact]
    public void Int64_ReturnsValueInRange()
    {
        var result = GetRandom.Int64(1, 100);
        Assert.InRange(result, 1L, 99L);
    }

    [Fact]
    public void Int64_EqualMinMax_ReturnsMin()
    {
        var result = GetRandom.Int64(5, 5);
        Assert.Equal(5L, result);
    }

    [Fact]
    public void Int64_SwapsIfMinGreaterThanMax()
    {
        var result = GetRandom.Int64(100, 1);
        Assert.InRange(result, 1L, 99L);
    }

    [Fact]
    public void Double_ReturnsValueInRange()
    {
        var result = GetRandom.Double(1.0, 10.0);
        Assert.InRange(result, 1.0, 10.0);
    }

    [Fact]
    public void Double_EqualMinMax_ReturnsMin()
    {
        var result = GetRandom.Double(5.0, 5.0);
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Double_SwapsIfMinGreaterThanMax()
    {
        var result = GetRandom.Double(10.0, 1.0);
        Assert.InRange(result, 1.0, 10.0);
    }

    [Fact]
    public void Int32_MultipleCallsReturnDifferentValues()
    {
        var results = Enumerable.Range(0, 50).Select(_ => GetRandom.Int32(0, 10000)).ToHashSet();
        Assert.True(results.Count > 1);
    }
}
