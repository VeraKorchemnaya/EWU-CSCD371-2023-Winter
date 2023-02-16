using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LambdaExpressions;

[TestClass]
public class PatternMatchingTests
{
    [TestMethod]
    public void SetName_InigoMontoya_Success()
    {
        FullName testName = new FullName("Inigo Montoya");
        (string, string) actual = (testName.FirstName, testName.LastName);
        Assert.AreEqual<(string, string)>(("Inigo", "Montoya"), actual);
        Assert.IsTrue(testName.FirstName is "Inigo");
        // pattern matching to a constrant
        // when pattern matching we car use is or a switch with is

    }


    [TestMethod]
    public void UsingSwitch_InitialsInigoMontoya_Success()
    {
        FullName testName = new FullName("Inigo Montoya");

        string actual = testName.Initials;
        Assert.AreEqual<string>("IM", actual);

    }
}
