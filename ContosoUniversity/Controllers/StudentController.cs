using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Contoso.Domain.Entities;
using Contoso.Data;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoUniversity.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
            var students = await _studentRepository.GetAll().ToListAsync();
            return students;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Student> Get(int id)
        {
            //  var student = await _context.Students.AsNoTracking().SingleOrDefaultAsync(a => a.ID == id);
            var student = await _studentRepository.GetAsync(id);
            return student;
        }
        // GET api/values/5
        [HttpGet("/StudentC")]
        public async Task<Student> StudentCourse()
        {
            var student = await _studentRepository.GetAsync(10);
            return student;
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
