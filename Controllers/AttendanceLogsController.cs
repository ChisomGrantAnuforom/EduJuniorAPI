using EduJuniorAPI.Data;
using EduJuniorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduJuniorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceLogsController(AppDbContext context) : ControllerBase
    {
        [HttpGet (Name = "GetAttendanceLogs")]
        public IActionResult GetAttendanceLogs()
        {
            var attendanceLogs = context.AttendanceLogs.ToList();
            return Ok(attendanceLogs);
        }
        [HttpGet("{id}")]
        public IActionResult GetAttendanceLog(int id)
        {
            var attendanceLog = context.AttendanceLogs.Find(id);
            if (attendanceLog == null)
            {
                return NotFound();
            }
            return Ok(attendanceLog);
        }

        [HttpPost]
        public IActionResult CreateAttendanceLog([FromBody] AttendanceLog attendanceLog)
        {
            context.AttendanceLogs.Add(attendanceLog);
            context.SaveChanges();
            return CreatedAtAction(nameof(GetAttendanceLog), new { id = attendanceLog.Id }, attendanceLog);
        }


        [HttpPost]
        public IActionResult CreateAttendanceLogs([FromBody] List<AttendanceLog> attendanceLogs)
        {
            context.AttendanceLogs.AddRange(attendanceLogs);
            context.SaveChanges();
            return Ok(attendanceLogs);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAttendanceLog(int id, [FromBody] AttendanceLog updatedAttendanceLog)
        {
            var attendanceLog = context.AttendanceLogs.Find(id);
            if (attendanceLog == null)
            {
                return NotFound();
            }
            attendanceLog.Id = updatedAttendanceLog.Id;
            attendanceLog.StudentId = updatedAttendanceLog.StudentId;
            attendanceLog.AttendanceType = updatedAttendanceLog.AttendanceType;
            attendanceLog.TimeIn = updatedAttendanceLog.TimeIn;
            attendanceLog.TimeOut = updatedAttendanceLog.TimeOut;
         
            context.SaveChanges();
            return NoContent();
        }


        [HttpPost]
        public IActionResult UpdateAttendanceLogs([FromBody] List<AttendanceLog> updatedAttendanceLogs)
        {
            foreach (var updatedAttendanceLog in updatedAttendanceLogs)
            {
                var attendanceLog = context.AttendanceLogs.Find(updatedAttendanceLog.Id);
                if (attendanceLog != null)
                {

                    attendanceLog.Id = updatedAttendanceLog.Id;
                    attendanceLog.StudentId = updatedAttendanceLog.StudentId;
                    attendanceLog.AttendanceType = updatedAttendanceLog.AttendanceType;
                    attendanceLog.TimeIn = updatedAttendanceLog.TimeIn;
                    attendanceLog.TimeOut = updatedAttendanceLog.TimeOut;
                }
            }
            context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteAttendanceLog(int id)
        {
            var attendanceLog = context.AttendanceLogs.Find(id);
            if (attendanceLog == null)
            {
                return NotFound();
            }
            context.AttendanceLogs.Remove(attendanceLog);
            context.SaveChanges();
            return NoContent();
        }

    }
}
