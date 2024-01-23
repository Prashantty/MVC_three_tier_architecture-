using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using MVCClint.Model;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MVCClint.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public async  Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                List<Student> students = new List<Student>();
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
                    students = JsonConvert.DeserializeObject<List<Student>>(jsonString.Result);

                }
                else
                {
                    ViewBag.msg = response.ReasonPhrase;

                }
                return View(students);

            }
        }

        // GET: StudentController/Details/5
        public async Task<ActionResult> Details(int id)
        {

            using (var client = new HttpClient())
            {
                Student students = new Student();
                //Send HTTP requests from here. 
                client.BaseAddress = new Uri("http://localhost:5209/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync("api/Student/" + id);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    students = JsonConvert.DeserializeObject<Student>(jsonString.Result);

                }
                else
                {
                    ViewBag.msg = response.ReasonPhrase;

                }
                return View(students);

            }
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();

        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Student student)
        {
         
            try
            {
                using (var client = new HttpClient())
                {
                    //Send HTTP requests from here. 
                    client.BaseAddress = new Uri("http://localhost:5209/");
                    HttpResponseMessage response = await client.PostAsJsonAsync("api/Student", student);

                    if (response.IsSuccessStatusCode)
                    {
                        // Get the URI of the created resource.  
                        

                    }
                    return RedirectToAction(nameof(Index));

                }
                

            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public async  Task<ActionResult> Edit(int id)
        {
            using (var client = new HttpClient())
            {
                Student students = new Student();
                //Send HTTP requests from here. 
                client.BaseAddress = new Uri("http://localhost:5209/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync("api/Student/" + id);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    students = JsonConvert.DeserializeObject<Student>(jsonString.Result);
                    return View(students);

                }
                else
                {
                    ViewBag.msg = response.ReasonPhrase;
                    return View();

                }
                

            }
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Student student)
        {
            try
            {

                using (var client = new HttpClient())
                {
                    //Send HTTP requests from here. 
                    client.BaseAddress = new Uri("http://localhost:5209/");

                    //PUT Method  
                    
                 
                    HttpResponseMessage response = await client.PutAsJsonAsync("api/Student/" + id, student);
                    if (response.IsSuccessStatusCode)

                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        return View();
                    }
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            using (var client = new HttpClient())
            {
                Student students = new Student();
                //Send HTTP requests from here. 
                client.BaseAddress = new Uri("http://localhost:5209/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync("api/Student/" + id);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    students = JsonConvert.DeserializeObject<Student>(jsonString.Result);
                    return View(students);

                }
                else
                {
                    ViewBag.msg = response.ReasonPhrase;
                    return View();

                }


            }
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id , Student student)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    //Send HTTP requests from here. 
                    client.BaseAddress = new Uri("http://localhost:5209/");


                    HttpResponseMessage response = await client.DeleteAsync("api/Student/" + id );
                    if (response.IsSuccessStatusCode)
                    {
                        
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
