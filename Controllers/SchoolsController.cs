
using EduJuniorAPI.Data;
using EduJuniorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduJuniorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController(AppDbContext context) : ControllerBase
    {

        [HttpGet (Name = "GetSchools")]
        public IActionResult GetSchools()
        {
            var schools = context.Schools.ToList();
            return Ok(schools);
        }

        [HttpGet("{id}")]
        public IActionResult GetSchool(int id)
        {
            var school = context.Schools.Find(id);
            if (school == null)
            {
                return NotFound();
            }
            return Ok(school);
        }


        [HttpGet("{emailAddress}/{password}")]
        public IActionResult GetSchoolByEmailAddress(string emailAddress, string password)
        {
            var school = context.Schools.FirstOrDefault(s =>  s.EmailAddress == emailAddress && s.Password == password );

            if (school == null)
            { 
                return NotFound("Invalid credentials");
            }
            
            return Ok(school);
        }

        [HttpPost]
        public IActionResult CreateSchool([FromBody] School school)
        {
            context.Schools.Add(school);
            context.SaveChanges();
            return CreatedAtAction(nameof(GetSchool), new { id = school.SchoolId }, school);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateSchool(int id, [FromBody] School updatedSchool)
        {
            var school = context.Schools.Find(id);
            if (school == null)
            {
                return NotFound();
            }
            school.ServerSchoolId = updatedSchool.ServerSchoolId;
            school.SchoolName = updatedSchool.SchoolName;
            school.Address = updatedSchool.Address;
            school.PhoneNo = updatedSchool.PhoneNo;
            school.EmailAddress = updatedSchool.EmailAddress;
            school.Password = updatedSchool.Password;
            school.LocationId = updatedSchool.LocationId;
            school.ProprietorFullName = updatedSchool.ProprietorFullName;   
            school.HeadFullName = updatedSchool.HeadFullName;
            school.DateLastUpdated = updatedSchool.DateLastUpdated;
            school.RegKey = updatedSchool.RegKey;
            school.Active = updatedSchool.Active;
            school.Uploaded = updatedSchool.Uploaded;
           


            context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteSchool(int id)
        {
            var school = context.Schools.Find(id);
            if (school == null)
            {
                return NotFound();
            }
            context.Schools.Remove(school);
            context.SaveChanges();
            return NoContent();
        }

    }
}
