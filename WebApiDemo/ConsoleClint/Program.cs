using Newtonsoft.Json;
using System.Net.Http.Headers;
using WebApiDemo.Model;

namespace ConsoleClint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetStudents().Wait();
        }
        static async Task GetStudents()
        {
            using (var client = new HttpClient())
            {
                //Send HTTP requests from here. 
                client.BaseAddress = new Uri("http://localhost:5209/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync("api/Student");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    var student = JsonConvert.DeserializeObject<List<Student>>(jsonString.Result);

                    foreach (var temp in student)
                    {
                        Console.WriteLine("Id:{0}\tName:{1}", temp.ID, temp.Name);
                        //  Console.WriteLine("No of Employee in Department: {0}", department.Employees.Count);
                    }
                }
                else
                {
                    Console.WriteLine(response.ReasonPhrase);
                    Console.WriteLine("Internal server Error");
                }

            }


        }
    }
}