namespace App.Tests;

// With Rider 2024.3, no errors show in the editor below, but this file has an error in the Solution Explorer.
// Checking the Problems tool window, under All Solution Files, there's an error for this file:
//   <App.Tests>\UnitTest1.cs:378 Anonymous function can be made static
// However, clicking the File tab on the Problems tool window shows no errors.
// In a large solution, this problem manifests *everywhere*.
// This does not happen in Rider 2024.2. This also does not show in VS Code w/ C# Dev Kit.

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        List<string> list = ["foo"];

        Assert.Contains(list, l => l == "foo");
    }
}