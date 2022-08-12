using NUnit.Framework;

public class ExampleUnitTest
{
    [Test]
    public void TestThatScoreStartsAtZero()
    {
        Assert.AreEqual(0, UpdateScoreAndTax.score);
    }
}
