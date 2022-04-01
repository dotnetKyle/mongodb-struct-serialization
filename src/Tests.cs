[TestClass]
public class Tests
{
    public void TestMethod()
    {
        // Arrange
        var str = "bob@aol.com";
        
        // Act
        var email = new EmailAddress("bob@aol.com");
        
        // Assert
        Assert.IsTrue(a == b, "message");
    }
    
    
}
