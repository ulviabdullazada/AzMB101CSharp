using ConsoleApp1.Models;
using Newtonsoft.Json;

HttpClient httpClient = new HttpClient();
ICollection<CustomObject> customObjects = new List<CustomObject>();
string response = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;
//Console.WriteLine(response);
customObjects =  JsonConvert.DeserializeObject<ICollection<CustomObject>>(response);

using (StreamWriter sw = new StreamWriter(@"C:\Users\Birinci novbe\Desktop\AzMB101CSharp\ConsoleApp1\Data\jsonData.json"))
{
    sw.Write(JsonConvert.SerializeObject(customObjects));
}