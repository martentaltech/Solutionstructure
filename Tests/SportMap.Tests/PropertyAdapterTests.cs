using SportMap.Aids;

namespace SportMap.Tests;

public class PropertyAdapterTests : TestAids<PropertyAdapter> {
    private class testClass {
        public int? IntProp { get; set; }
        public string StringProp { get; set; }
    }
    private testClass item;
    private string propName = nameof(testClass.IntProp);
    private PropertyAdapter oStr;
    public PropertyAdapterTests() {
        item = new testClass();
        obj = new PropertyAdapter(item, propName);
        oStr = new PropertyAdapter(item, nameof(testClass.StringProp));
    }
    [Fact] public void ItemTypeTest() => areEqual(typeof(testClass), obj.ItemType);
    [Fact] public void ItemTest() => areSame(item, obj.Item);
    [Fact] public void PropInfoTest() => areEqual(propName, obj.PropInfo.Name);
    [Fact] public void PropTypeTest() {
        areEqual(typeof(int?), obj.PropType);
        areEqual(typeof(string), oStr.PropType);
    }
    [Fact] public void UnderlyingTypeTest() {
        areEqual(typeof(int), obj.UnderlyingType);
        areEqual(typeof(string), oStr.UnderlyingType);
    }
    [Fact] public void PropValueTest() {
        areEqual(null, obj.PropValue);
        areEqual(null, oStr.PropValue);
    }
    [Fact] public void SetValueTest() {
        var i = GetRandom.Int32();
        var s = GetRandom.String();
        obj.SetValue(i);
        oStr.SetValue(s);
        areEqual(i, item.IntProp);
        areEqual(s, item.StringProp);
        areEqual(obj.PropValue, item.IntProp);
        areEqual(oStr.PropValue, item.StringProp);
    }
}
