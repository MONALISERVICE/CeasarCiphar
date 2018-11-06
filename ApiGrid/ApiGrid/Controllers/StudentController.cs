using ApiGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiGrid.Controllers
{
    public class StudentController : ApiController
    {
        collegeDBEntities _ctx = null; // SchoolMangementEntities is data model name  

        public StudentController()
        {
            _ctx = new collegeDBEntities();
        }
        [Route("api/students")]
        [HttpGet]
        public List<student> GetStudents()
        {
            List<student> students = null;
            try
            {
                students = _ctx.students.ToList();
            }
            catch
            {
                students = null;
            }
            return students;
        }
    }
}

