namespace DotNetCodeCoveragePipeline.Shared.Tests;

public class UnitTest1
{
    [Fact]
    public void TestTruth()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void TestFalsehood()
    {
        Assert.False(false);
    }
    
    [Fact]
    public void LetsDoubleCheckMathStillWorks()
    {
        Assert.Equal(4, 2 + 2);
    }
}