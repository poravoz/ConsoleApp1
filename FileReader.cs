using System.IO;

namespace ConsoleApp1
{
	public class FileReader
	{
		public void writeToFile(string path)
		{
			if (!File.Exists(path))
			{
				string createText = "Welcome\n";
				File.WriteAllText(path, createText);
			}

			string appendText = "hello world!\n";
			File.AppendAllText(path, appendText);

			string readText = File.ReadAllText(path);
			Console.WriteLine(readText);
		}
	}
}
