using System.IO;

namespace MongoTool
{
    public interface IFileStuff
    {
        string ReadTextFile(string filePath);
        void WriteTextFile(string filePath, string fileContent);
    }

    public class FileStuff : IFileStuff
    {
        public string ReadTextFile(string filePath)
        {
            var content = File.ReadAllText(filePath);
            return content;
        }

        public void WriteTextFile(string filePath, string fileContent)
        {
            File.WriteAllText(filePath, fileContent);
        }
    }
}
