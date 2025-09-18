using EduJuniorAPI.Data;
using EduJuniorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduJuniorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PupilsController(AppDbContext context) : ControllerBase
    {

        [HttpGet (Name = "GetPupils")]
        public IActionResult GetPupils()
        {
            var pupils = context.Pupils.ToList();
            return Ok(pupils);
        }


        [HttpGet("{id}")]
        public IActionResult GetPupil(int id)
        {
            var pupil = context.Pupils.Find(id);
            if (pupil == null)
            {
                return NotFound();
            }
            return Ok(pupil);
        }


        [HttpPost]
        public IActionResult CreatePupil([FromBody] Pupil pupil)
        {
            context.Pupils.Add(pupil);
            context.SaveChanges();
            return CreatedAtAction(nameof(GetPupil), new { id = pupil.PupilId }, pupil);
        }


        [HttpPut("{id}")]
        public IActionResult UpdatePupil(int id, [FromBody] Pupil updatedPupil)
        {
            var pupil = context.Pupils.Find(id);
            if (pupil == null)
            {
                return NotFound();
            }
            pupil.PupilIdLocal = updatedPupil.PupilIdLocal;
            pupil.FirstName = updatedPupil.FirstName;
            pupil.OtherNames = updatedPupil.OtherNames;
            pupil.LastName = updatedPupil.LastName;
            pupil.Sex = updatedPupil.Sex;
            pupil.DateOfBirthDay = updatedPupil.DateOfBirthDay;
            pupil.DateOfBirthMonth = updatedPupil.DateOfBirthMonth;
            pupil.DateOfBirthYear = updatedPupil.DateOfBirthYear;
            pupil.HomeAddress = updatedPupil.HomeAddress;
            pupil.PhoneNumber = updatedPupil.PhoneNumber;
            pupil.ParentId = updatedPupil.ParentId;
            pupil.ClassId = updatedPupil.ClassId;
            pupil.LevelId = updatedPupil.LevelId;
            pupil.SchoolId = updatedPupil.SchoolId;
            pupil.Picture = updatedPupil.Picture;
            pupil.Fp1 = updatedPupil.Fp1;
            pupil.Fp2 = updatedPupil.Fp2;
            pupil.Fp3 = updatedPupil.Fp3;
            pupil.Fp4 = updatedPupil.Fp4;
            pupil.DateEnroled = updatedPupil.DateEnroled;
            pupil.DateRegistered = updatedPupil.DateRegistered;
            pupil.DateLastUpdated = updatedPupil.DateLastUpdated;
            pupil.Uploaded = updatedPupil.Uploaded;
            pupil.ActiveSecurity = updatedPupil.ActiveSecurity;
            pupil.ActiveInteractive = updatedPupil.ActiveInteractive;
            pupil.Enabled = updatedPupil.Enabled;
            pupil.ParentId2 = updatedPupil.ParentId2;
         



            context.SaveChanges();
            return NoContent();
        }

    }
}
