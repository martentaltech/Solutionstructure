using SportMap.Aids;

namespace SportMap.Tests;

public class TypeExtensionTests {
    [Fact] public void IsBoolTest() {
        Assert.True(TypeExtension.IsBool(typeof(bool)));
        Assert.True(typeof(bool).IsBool());
        Assert.False(TypeExtension.IsBool(typeof(string)));
    }
    [Theory]
    [InlineData(typeof(sbyte))]
    [InlineData(typeof(sbyte?))]
    [InlineData(typeof(byte))]
    [InlineData(typeof(byte?))]
    public void IsNumericTest(Type t) {
        Assert.True(TypeExtension.IsNumeric(t));
        Assert.True(t.IsNumeric());
    }
    [Fact] public void IsDateTest() {
        Assert.True(TypeExtension.IsDate(typeof(DateTime)));
        Assert.True(TypeExtension.IsDate(typeof(DateOnly)));
        Assert.False(TypeExtension.IsDate(typeof(string)));
    }
    [Fact] public void IsStringTest() {
        Assert.True(TypeExtension.IsString(typeof(string)));
        Assert.False(TypeExtension.IsString(typeof(int)));
    }
}
