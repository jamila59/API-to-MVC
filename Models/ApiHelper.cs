using System.Threading.Tasks;
using RestSharp;

namespace MVC.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient("https://localhost:5003/");
      RestRequest request = new RestRequest($"home.json", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}