using ConsoleApp1;
using System.Text.Json;
using System.Diagnostics;
using System.Security.Principal;

class Program
{
	public static void Main()
	{
		//System.io
		string path = "E:\\hello_world.txt";
		FileReader file = new FileReader();
		file.writeToFile(path);



		//System.Text.Json
		var weatherForecast = new Person
		{
			Name = "Mykola",
			LastName = "Rud",
			Year = 19,
		};

		var options = new JsonSerializerOptions
		{
			WriteIndented = true,
		};

		string jsonString = JsonSerializer.Serialize(weatherForecast, options);
		Console.WriteLine(jsonString);



		// System.Security.Principal
		Console.WriteLine();
		WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();
		Console.WriteLine(windowsIdentity.Name);



		// System.Timers;
		Console.WriteLine();
		TimerExample timer = new TimerExample(2000);
		timer.Start();
		Console.ReadLine();
		timer.Stop();



		// System.Diagnostics;
		Process.Start("ping", "www.youtube.com");

	}
}
