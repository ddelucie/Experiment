using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
	public class TPL // stack overflow question
	{
		private static async Task RunAsync(string postValue)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("http://localhost:56789/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				var response = await client.PostAsync("api/MyApi", new StringContent(postValue));
			}
		}

		protected void Session_Start(object sender, EventArgs e)
		{
			var somePostValue = "";
			RunAsync(somePostValue).Wait();
			RunAsync(somePostValue);
		}
	}
}
