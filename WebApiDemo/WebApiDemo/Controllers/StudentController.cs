using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Model;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class StudentController : ControllerBase
    {

        static List<Student> students = null;

        void Initaillizer()
        {
            students = new List<Student>()
            {
                new Student() {ID =  1, Name = "Prashant " , BatchCode = "B001" , Marks= 10},
                new Student() {ID =  2, Name = "Ashvi " , BatchCode = "B023" , Marks= 10},
                new Student() {ID =  3, Name = "Aman " , BatchCode = "B031" , Marks= 10},
                new Student() {ID =  4, Name = "Prabhat " , BatchCode = "B090" , Marks= 10},
                new Student() {ID =  5, Name = "Pranav " , BatchCode = "B011" , Marks= 10},
                new Student() {ID =  6, Name = "Amit  " , BatchCode = "B002" , Marks= 10},
                new Student() {ID =  7, Name = "Akshans " , BatchCode = "B005" , Marks= 10},
                new Student() {ID =  8, Name = "Nishant " , BatchCode = "B002" , Marks= 10},
                new Student() {ID =  9, Name = "Shashank " , BatchCode = "B004" , Marks= 10}
            };
        }

        public StudentController()
        {
            if (students == null)
            {
                Initaillizer();
            }

        }

        public List<Student> Get()
        {
            return students;
        }

        [HttpGet ("{id}")]
        public Student Get(int id)
        {
            return students[id-1];
        }

        [HttpPost]
        public void PostStudent(Student student)
        {
            students.Add(student);
        }

        [HttpPut("{id}")]
        public void EditStudent(int id , Student student)
        {
            (from p in students
             where p.ID == id
             select p).ToList().
             ForEach(x =>
             {
                 x.ID = student.ID;
                 x.Name = student.Name;
                 x.BatchCode = student.BatchCode;
                 x.Marks = student.Marks;

             });
        }

        [HttpDelete ("{id}")]
        public void DeleteStudent(int id)
        {
            Student student = students.Where(x => x.ID == id-1).FirstOrDefault(); 
            students.Remove(student);
        }





    }
}
