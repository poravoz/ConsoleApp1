using System.Timers;

namespace ConsoleApp1
{
	public class TimerExample
	{
		private System.Timers.Timer timer;

		public TimerExample(int interval)
		{
			timer = new System.Timers.Timer(interval);
			timer.Elapsed += Tick;
			timer.AutoReset = true; // ресет таймеру
			timer.Enabled = false; // timer спочатку вимикаємо
		}

		// timer start
		public void Start()
		{
			timer.Enabled = true;
			Console.WriteLine("Timer started.");
		}

		// timer stop
		public void Stop()
		{
			timer.Enabled = false;
			Console.WriteLine("Timer stopped.");
		}

		private void Tick(object source, ElapsedEventArgs e)
		{
			Console.WriteLine(e.SignalTime);
		}
	}
}
