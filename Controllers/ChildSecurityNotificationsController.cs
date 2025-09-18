using EduJuniorAPI.Data;
using EduJuniorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduJuniorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildSecurityNotificationsController(AppDbContext context) : ControllerBase
    {

        [HttpGet(Name = "GetChildSecurityNotifications")]
        public IActionResult GetChildSecurityNotifications()
        {
            var notifications = context.ChildSecurityNotifications.ToList();
            return Ok(notifications);
        }
        [HttpGet("{id}")]
        public IActionResult GetChildSecurityNotification(int id)
        {
            var notification = context.ChildSecurityNotifications.Find(id);
            if (notification == null)
            {
                return NotFound();
            }
            return Ok(notification);
        }
        [HttpPost]
        public IActionResult CreateChildSecurityNotification([FromBody] ChildSecurityNotification notification)
        {
            context.ChildSecurityNotifications.Add(notification);
            context.SaveChanges();
            return CreatedAtAction(nameof(GetChildSecurityNotification), new { id = notification.Id }, notification);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateChildSecurityNotification(int id, [FromBody] ChildSecurityNotification updatedNotification)
        {
            var notification = context.ChildSecurityNotifications.Find(id);
            if (notification == null)
            {
                return NotFound();
            }
            notification.Id = updatedNotification.Id;
            notification.StudentId = updatedNotification.StudentId;
            notification.StudentId = updatedNotification.StudentId;
            notification.Message =updatedNotification.Message;  
            notification.SentAt = updatedNotification.SentAt;
            notification.Channel = updatedNotification.Channel;

            context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteChildSecurityNotification(int id)
        {
            var notification = context.ChildSecurityNotifications.Find(id);
            if (notification == null)
            {
                return NotFound();
            }
            context.ChildSecurityNotifications.Remove(notification);
            context.SaveChanges();
            return NoContent();
        }

    }
}
