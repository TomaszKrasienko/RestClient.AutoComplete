using RestClient.AutoComplete.File.Abstractions;

namespace RestClient.AutoComplete.File;

internal sealed class FileCreator : IFileCreator
{
    public void CreateFile(string fileName)
    {
        System.IO.File.WriteAllText(fileName, "test");
    }
}