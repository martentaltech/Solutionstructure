using SportMap.Aids;
using SportMap.Data.Common;

namespace SportMap.Tests;

public class GetRandomTests {
    private const sbyte min = sbyte.MinValue;
    private const sbyte max = sbyte.MaxValue;

    [Fact] public void Int8Test()
        => Assert.NotEqual(GetRandom.Int8(min, max), GetRandom.Int8(min, max));
    [Fact] public void Int16Test()
        => Assert.NotEqual(GetRandom.Int16(min, max), GetRandom.Int16(min, max));
    [Fact] public void Int32Test()
        => Assert.NotEqual(GetRandom.Int32(min, max), GetRandom.Int32(min, max));
    [Fact] public void Int64Test()
        => Assert.NotEqual(GetRandom.Int64(min, max), GetRandom.Int64(min, max));
    [Fact] public void UInt8Test()
        => Assert.NotEqual(GetRandom.UInt8(0, (byte)max), GetRandom.UInt8(0, (byte)max));
    [Fact] public void UInt16Test()
        => Assert.NotEqual(GetRandom.UInt16(0, (ushort)max), GetRandom.UInt16(0, (ushort)max));
    [Fact] public void UInt32Test()
        => Assert.NotEqual(GetRandom.UInt32(0, (uint)max), GetRandom.UInt32(0, (uint)max));
    [Fact] public void UInt64Test()
        => Assert.NotEqual(GetRandom.UInt64(0, (ulong)max), GetRandom.UInt64(0, (ulong)max));
    [Fact] public void DoubleTest()
        => Assert.NotEqual(GetRandom.Double(min, max), GetRandom.Double(min, max));
    [Fact] public void FloatTest()
        => Assert.NotEqual(GetRandom.Float(min, max), GetRandom.Float(min, max));
    [Fact] public void DecimalTest()
        => Assert.NotEqual(GetRandom.Decimal(min, max), GetRandom.Decimal(min, max));
    [Fact] public void StringTest()
        => Assert.NotEqual(GetRandom.String(0, (byte)max), GetRandom.String(0, (byte)max));
    [Fact] public void CharTest()
        => Assert.NotEqual(GetRandom.Char((char)0, (char)max), GetRandom.Char((char)0, (char)max));
    [Fact] public void BoolTest() {
        var x = GetRandom.Bool();
        var y = GetRandom.Bool();
        for (var i = 0; i < 10; i++) {
            if (x != y) break;
            y = GetRandom.Bool();
        }
        Assert.NotEqual(x, y);
    }
    [Fact] public void DateTimeTest() {
        var minDate = DateTime.Now.AddYears(-100);
        var maxDate = DateTime.Now.AddYears(100);
        Assert.NotEqual(GetRandom.DateTime(minDate, maxDate), GetRandom.DateTime(minDate, maxDate));
    }
    [Fact] public void TimeSpanTest() {
        var minSpan = TimeSpan.FromTicks(DateTime.Now.AddYears(-100).Ticks);
        var maxSpan = TimeSpan.FromTicks(DateTime.Now.AddYears(100).Ticks);
        Assert.NotEqual(GetRandom.TimeSpan(minSpan, maxSpan), GetRandom.TimeSpan(minSpan, maxSpan));
    }
    [Fact] public void GuidTest()
        => Assert.NotEqual(GetRandom.Guid(), GetRandom.Guid());
    private class testClass : NamedEntity { }
    [Fact] public void ObjectTest() {
        var o1 = GetRandom.Object(typeof(testClass));
        var o2 = GetRandom.Object(typeof(testClass));
        foreach (var p in typeof(testClass).GetProperties()) {
            if (p.PropertyType.IsArray) continue;
            Assert.NotEqual(p.GetValue(o1), p.GetValue(o2));
        }
    }
}
