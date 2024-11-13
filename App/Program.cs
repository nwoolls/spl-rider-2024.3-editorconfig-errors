// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Shows as an error in the editor and Solution Explorer - not the case in Rider 2024.2.
// This does show as an error in VS Code w/ C# Dev Kit, but not in the Solution Explorer in VS Code. Only the editor.
var guid = Guid.NewGuid();
Console.WriteLine(guid);
