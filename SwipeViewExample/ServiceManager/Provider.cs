using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwipeViewExample.Models;

namespace SwipeViewExample.ServiceManager
{
    public class Provider
    {
        public async Task<Person> GetPersons()
        {
            var client = new HttpClient();
            return JsonConvert.DeserializeObject<Person>(await client.GetStringAsync("https://randomuser.me/api/?results=25"));
        }
    }
}
