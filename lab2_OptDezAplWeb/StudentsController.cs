using Lab2_24.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ana", Age = 21 },
            new Student { Id = 2, Name = "Maria", Age = 19 },
            new Student { Id = 3, Name = "Vlad", Age = 22 },
            new Student { Id = 4, Name = "Florin", Age = 25 },
            new Student { Id = 5, Name = "Marian", Age = 20 },
        };

        
        [HttpGet]
        public List<Student> Get()
        {
            return students.OrderBy(o => o.Age).ToList();
        }

       
        [HttpPost]
        public List<Student> Add(Student student)
        {
            students.Add(student);
            return students;
        }

        // ENDPOINT DELETE BY STUDENT ID
        [HttpDelete("{id}")]
        public List<Student> Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
            return students;
        }

        // endpoint studenti dupa varsta
        [HttpGet("getAllOrdered")]
        public List<Student> GetAllOrdered()
        {
            return students.OrderBy(s => s.Age).ToList();
        }
    }
}
using Lab2_24.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2_24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ana", Age = 21 },
            new Student { Id = 2, Name = "Maria", Age = 19 },
            new Student { Id = 3, Name = "Vlad", Age = 22 },
            new Student { Id = 4, Name = "Florin", Age = 25 },
            new Student { Id = 5, Name = "Marian", Age = 20 },
        };

        
        [HttpGet]
        public List<Student> Get()
        {
            return students.OrderBy(o => o.Age).ToList();
        }

        
        [HttpPost]
        public List<Student> Add(Student student)
        {
            students.Add(student);
            return students;
        }

        // END POINT-DELETE
        [HttpDelete("{id}")]
        public List<Student> Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
            return students;
        }

        // ENDPOINT NOU
        [HttpGet("getAllOrdered")]
        public List<Student> GetAllOrdered()
        {
            return students.OrderBy(s => s.Age).ToList();
        }
    }
}
