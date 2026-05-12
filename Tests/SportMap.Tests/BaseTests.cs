namespace SportMap.Tests;

public abstract class BaseTests<TClass> : TestAids<TClass> where TClass : class, new() {
    [Fact] public void CanCreateTest() => Assert.NotNull(obj);
    [Fact] public void IsClassTestedTest() {
        var testMethods = GetType().GetMethods().Select(x => x.Name);
        var membersToTest = getProperties().Concat(getMethods());
        var untested = membersToTest.Where(m => !testMethods.Contains(m + "Test")).ToList();
        Assert.True(untested.Count == 0, $"Not tested: {string.Join(", ", untested)}");
    }
}
