using System;
using System.Threading;
using Microsoft.Owin.Hosting;

namespace Services3
{
	class Program
	{
		private static ManualResetEvent _quitEvent = new ManualResetEvent(false);

		static void Main(string[] args)
		{
			int port = 5000;
			if(args.Length > 0)
			{
				int.TryParse(args[0], out port);
			}

			Console.CancelKeyPress += (sender,eArgs) => 
			{
						 _quitEvent.Set();
						 eArgs.Cancel = true;
			};
			//We'll listen for all HTTP websites on the given port.
			var siteURI = string.Format("http://*:{0}",port);
			
			
			using(WebApp.Start<Startup>(siteURI))
			{ 
				Console.WriteLine("Started");
				_quitEvent.WaitOne();
			}

		}
	}
}
