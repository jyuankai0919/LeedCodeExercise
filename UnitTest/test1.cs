using Xunit;
using LeedCodeExercise.Problem.Medium;
using LeedCodeExercise.Problem.Easy;

public class No14_Longest_Common_Prefix_Tests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var instance = new No14_Longest_Common_Prefix();
        // Act
        instance.Test();
        // Assert
        Assert.NotNull(instance);
    }
}