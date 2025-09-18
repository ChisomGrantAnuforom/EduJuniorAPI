using EduJuniorAPI.Data;
using EduJuniorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduJuniorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentsController(AppDbContext context) : ControllerBase
    {

        [HttpGet (Name = "GetParents")]
        public IActionResult GetParents()
        {
            var parents = context.Parents.ToList();
            return Ok(parents);
        }

        [HttpGet("{id}")]
        public IActionResult GetParent(int id)
        {
            var parent = context.Parents.Find(id);
            if (parent == null)
            {
                return NotFound();
            }
            return Ok(parent);
        }


        [HttpPost]
        public IActionResult CreateParent([FromBody] Parent parent)
        {
            context.Parents.Add(parent);
            context.SaveChanges();
            return CreatedAtAction(nameof(GetParent), new { id = parent.ParentId }, parent);
        }



        [HttpPut("{id}")]
        public IActionResult UpdateParent(int id, [FromBody] Parent updatedParent)
        {
            var parent = context.Parents.Find(id);
            if (parent == null)
            {
                return NotFound();
            }
            parent.ParentIdLocal = updatedParent.ParentIdLocal;
            parent.Title = updatedParent.Title;
            parent.FirstName = updatedParent.FirstName;
            parent.OtherNames = updatedParent.OtherNames;
            parent.LastName = updatedParent.LastName;
            parent.Sex = updatedParent.Sex;
            parent.HomeAddress = updatedParent.HomeAddress;
            parent.PhoneNumber = updatedParent.PhoneNumber;
            parent.EmailAddress = updatedParent.EmailAddress;
            parent.Password = updatedParent.Password;
            parent.DateRegistered = updatedParent.DateRegistered;
            parent.DateLastUpdated = updatedParent.DateLastUpdated;
            parent.Uploaded = updatedParent.Uploaded;
            parent.Occupation = updatedParent.Occupation;
            


            context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteParent(int id)
        {
            var parent = context.Parents.Find(id);
            if (parent == null)
            {
                return NotFound();
            }
            context.Parents.Remove(parent);
            context.SaveChanges();
            return NoContent();
        }



    }
}
