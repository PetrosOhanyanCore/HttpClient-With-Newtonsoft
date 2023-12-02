using ConsoleApp1;
using System.Net.Mime;
using System.Text;
using Newtonsoft.Json;

RequestModel rm = new RequestModel();

var json = JsonConvert.SerializeObject(rm);
var obj = JsonConvert.DeserializeObject<RequestModel>(json);


using (HttpClient cl = new HttpClient())
{
    var request = new HttpRequestMessage
    {
        Method = HttpMethod.Post,
        RequestUri = new Uri("https://localhost:44356/Auth/Register"),
        Content = new StringContent(json, Encoding.UTF8, MediaTypeNames.Application.Json /* or "application/json" in older versions */),
    };

    var response = await cl.SendAsync(request).ConfigureAwait(false);
    response.EnsureSuccessStatusCode();

    var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
    Console.WriteLine(responseBody);
}