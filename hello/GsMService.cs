using System;
using System.Net.Http;
using System.Threading.Tasks;
using ModernHttpClient;
using Newtonsoft.Json;

namespace hello
{
	public class GsMService
	{
	    private const string _apiUrlFormat = "http://phone.flatplanet.pl/api/PhoneService/{0}";

	    public async Task<GsmCheckResult> CheckAsync(string phoneNumber)
        {
            using (var httpClient = new HttpClient(new NativeMessageHandler()))
            {
                var url = string.Format(_apiUrlFormat, phoneNumber);
                var responseJson = await httpClient.GetStringAsync(url);

                var result = JsonConvert.DeserializeObject<GsmCheckResult>(responseJson);
                return result;
            }
        }

        public class GsmCheckResult
        {
            public string Data { get; set; }

            public bool Success { get; set; }

        }
	}
}

