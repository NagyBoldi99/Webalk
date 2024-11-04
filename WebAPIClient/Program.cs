using System.Net.Http.Headers;

HttpClient client = new HttpClient();

client.DefaultRequestHeaders.Add("Accept", "application/json");

var requestData = "{\"name\":\"Skywalker\",\"namefield\":\"example\",\"iscomplese\":false}";
var requestContent = new StringContent(requestData, System.Text.Encoding.UTF8, "application/json");

var response = await client.PostAsync("http://localhost:5161/", requestContent);
var responseString = await response.Content.ReadAsStringAsync();

Console.Write(responseString);
