using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace LambdaExpressions;

[TestClass]
public class Lambdas
{
    public bool AlphabeticalGreaterThan(string a, string b)
    {
        return a.CompareTo(b) > 0;
    }

    public bool AlphabeticalGreaterThan(string a, int b)
    {
        return a.CompareTo(b) > 0;
    }

    public string[] Sort(Func<string,string, bool> greaterThan, string[] items)
    {
        return null;
    }



    public void Foreach(Action<string> action, string[]items) 
    { 
        foreach(string item in items)
        {
            action(item);
        }
    }

    [TestMethod]
    public void Sort_AB_Success()
    {
        string[] items = new[] { "A", "B" };
        string[] sortedItem = Sort(AlphabeticalGreaterThan, items);
        foreach(string item in sortedItem)
        {
            Console.WriteLine(item);
        }

    }

    [TestMethod]
    public void Foreach_AB_Success()
    {
        string[] items = new[] { "A", "B" };
        Foreach(DoSomethingString, items);

    }

    void DoSomethingString(string text)
    {
        Console.WriteLine(text);
    }

    void DoSomethingObject(object text)
    {
        Console.WriteLine(text);
    }    
    
    void DoSomethingInt(int text)
    {
        Console.WriteLine(text);
    }


    [TestMethod]
    public void Foreach_LambdaExpresion_Success()
    {
        string[] items = new[] { "A", "B" };
        string sentence = "This is a really long string";
        Action<string> action = DoSomethingString;
        action = (string item) => Console.WriteLine(item);
        action = (item) => Console.WriteLine(item);
        action = item => Console.WriteLine(item); // if only one parameter you don't need parenthesis
        action = Console.WriteLine;
        action = text =>
        {
            Console.WriteLine(text);
            Console.WriteLine(sentence);

        };


        Action takeAction = () => Console.WriteLine(sentence); // if no parameters you need parenthesis
        takeAction = Console.WriteLine;

        takeAction();
    }


    object GetThing(string thing) => thing;
    string GetText(object text) => text.ToString();
    string? Calculate(Func<object, string> getData) => getData(null!);


    [TestMethod]
    public void MyTestMethod()
    {
        Func<object, string> func;
        // func = GetThing; Doesn't work
        // func = GetText; Does work;
        //string obj = Calculate(GetThing);
        string text = Calculate(GetText);
    }


    [TestMethod]
    public void ExceptionHandling()
    {


    }
}
