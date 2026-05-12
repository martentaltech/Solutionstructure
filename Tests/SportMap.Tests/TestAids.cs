using System.Reflection;

namespace SportMap.Tests;

public abstract class TestAids<TClass> where TClass : class, new() {
    protected TClass obj;
    protected Type type;

    public TestAids() {
        type = typeof(TClass);
        obj = new TClass();
    }

    protected const BindingFlags publicDeclared = BindingFlags.Public
        | BindingFlags.DeclaredOnly
        | BindingFlags.Instance
        | BindingFlags.Static;

    protected static IEnumerable<string> getProperties()
        => SportMap.Aids.GetType.PropertyNames<TClass>(publicDeclared);
    protected static IEnumerable<string> getMethods()
        => SportMap.Aids.GetType.MethodNames<TClass>(publicDeclared, false);

    protected void areEqual<T>(T e, T a) => Assert.Equal(e, a);
    protected void areSame(object e, object a) => Assert.Same(e, a);
}
