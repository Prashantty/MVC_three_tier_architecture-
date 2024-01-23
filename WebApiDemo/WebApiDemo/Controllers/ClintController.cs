using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Context;
using WebApiDemo.Interface;
using WebApiDemo.Model;
using WebApiDemo.Repository;

namespace WebApiDemo.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ClintController : ControllerBase
    {
        ClintInterface _repo;
        public ClintController(ClintInterface repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public List<Clint> GetClints()
        {
            return _repo.GetClint();
        }

        [HttpGet("{id}")]
        public Clint GetClintById(int id)
        {
            return _repo.GetClintById(id);  
        }


        [HttpPost]
        public void Post(Clint clint)
        {
            _repo.CreateClint(clint); 
        }

        [HttpPut("{id}")]
        public void EditClint(int id, Clint clint)
        {
            _repo.EditClint(id, clint);

        }
        [HttpDelete("{id}")]

        public void DeleteClint(int id)
        {
            _repo.DeleteClint(id);
        }
    }
}
