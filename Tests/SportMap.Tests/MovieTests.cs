using SportMap.Data;
using SportMap.Data.Common;

namespace SportMap.Tests;

public class MovieTests {
    [Fact] public void Movie_InheritsFromNamedEntity() => Assert.IsAssignableFrom<NamedEntity>(new Movie());
    [Fact] public void Movie_InheritsFromBaseEntity() => Assert.IsAssignableFrom<BaseEntity>(new Movie());
    [Fact] public void Movie_HasGuidId() => Assert.NotEqual(Guid.Empty, new Movie().Id);
    [Fact] public void Movie_HasGenreProperty() {
        var movie = new Movie { Genre = "Action" };
        Assert.Equal("Action", movie.Genre);
    }
    [Fact] public void Movie_HasPriceProperty() {
        var movie = new Movie { Price = 9.99m };
        Assert.Equal(9.99m, movie.Price);
    }
    [Fact] public void Movie_HasNameProperty() {
        var movie = new Movie { Name = "Test Movie" };
        Assert.Equal("Test Movie", movie.Name);
    }
    [Fact] public void Movie_HasValidFromProperty() {
        var date = new DateTime(2024, 1, 1);
        var movie = new Movie { ValidFrom = date };
        Assert.Equal(date, movie.ValidFrom);
    }
}
