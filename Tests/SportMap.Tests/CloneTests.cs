using SportMap.Aids;

namespace SportMap.Tests;

public sealed class CloneTests {
    private class Address {
        public string City { get; set; }
    }
    private class Person {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
    private static Person person = new Person {
        Name = "John Doe",
        Address = new Address { City = "New York" }
    };
    private Person clone;
    public CloneTests() => clone = Clone.Object(person);

    [Fact] public void CloneTest() => Assert.NotSame(person, clone);
    [Fact] public void SamePersonNameTest() => Assert.Equal(person.Name, clone.Name);
    [Fact] public void SameCityTest() => Assert.Equal(person.Address.City, clone.Address.City);
    [Fact] public void ChangePersonNameTest() {
        clone.Name = "Bla Bla";
        Assert.Equal("John Doe", person.Name);
    }
    [Fact] public void NotSameAddressTest() => Assert.NotSame(person.Address, clone.Address);
    [Fact] public void ChangeCityTest() {
        clone.Address.City = "Bla Bla";
        Assert.Equal("New York", person.Address.City);
    }
    [Fact] public void ChangeAddressTest() {
        clone.Address = new Address { City = "Bla Bla" };
        Assert.Equal("New York", person.Address.City);
    }
}
