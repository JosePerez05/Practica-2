using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Practica_2.Controllers
{
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService_ = studentService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_studentService.GetAll());
        }

        // POST api/values
        [HttpPost]
        public void IActionResult ([FromBody] Student model)
        {
            return Ok(_studentService.Add(model));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void IActionResult ( int id, [FromBody] Student model)
        {
            return Ok(_studentService.Add(model));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void IActionResult Delete(int id)
        {
            return Ok(_studentService.Delete(id));
        }
    }
}
