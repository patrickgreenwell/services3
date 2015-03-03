using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;

namespace Services3
{
	public class Startup
	{
		public void Configure(IAppBuilder app)
		{
			app.UseWelcomePage();
		}
	}
}
