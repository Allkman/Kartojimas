using System;
using System.Net.Http.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace API.Exercise
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var uri = @"https://randomuser.me/api/?nat=dk&results=5";
            RandomUserApiModel content = null;

            var client = new HttpClient();

            try
            {
                var result = await client.GetAsync(uri);
                content = await result.Content.ReadFromJsonAsync<RandomUserApiModel>();
            }
            catch
            {
                Console.WriteLine("Vajeee");
            }
            finally
            {
                client.Dispose();
            }


            List<RandomUser> ransomUsers = content.results.Select(u => new RandomUser
            {
                Vardas = u.name.first,
                Pavarde = u.name.last,
                Adresas = $"{u.location}/{u.location.city} {u.location.street.name} {u.location.street.number}",
                Amzius = u.dob.age,

            }).ToList();

            Console.WriteLine(ransomUsers.Average(u => u.Amzius));
        }
    }
}
