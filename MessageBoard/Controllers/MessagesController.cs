using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;


namespace MessageBoard.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MessagesController : ControllerBase
  {
    private MessageBoardContext _db;

    public MessagesController(MessageBoardContext db)
    {
      _db = db;
    }

    // GET api/messages
    [HttpGet]
    public ActionResult<IEnumerable<Message>> Get(string user, DateTime? startDate, DateTime? endDate)
    {
      var query = _db.Messages.AsQueryable();

      if (user != null)
      {
        query = query.Where(entry => entry.UserName == user);
      }

      if (startDate != null && endDate != null)
      {
        query = query.Where(entry => entry.Date >= startDate && entry.Date <= endDate);
      } 
      else if (startDate != null && endDate == null)
      {
        query = query.Where(entry => entry.Date == startDate);
      } 

      return query.ToList();
    }

    // POST api/messages
    [HttpPost]
    public void Post([FromBody] Message message)
    {
      _db.Messages.Add(message);
      _db.SaveChanges();
    }

    // PUT api/messages/[MessageId]
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Message message)
    {
      message.MessageId = id;
      _db.Entry(message).State = EntityState.Modified;
      _db.SaveChanges();
    }
    
    //DELETE api/messages/[MessageId]
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var messageToDelete = _db.Messages.FirstOrDefault(entry => entry.MessageId == id);
      _db.Messages.Remove(messageToDelete);
      _db.SaveChanges();
    }
  }
}