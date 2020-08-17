using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MessageBoard.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class GroupsController : ControllerBase
  {
    private MessageBoardContext _db;

    public GroupsController(MessageBoardContext db)
    {
      _db = db;
    }

    // GET api/groups
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Group>>> Get(int? groupId)
    {
      var query = _db.Groups.AsQueryable();

      if (groupId != null)
      {
        return await query.Where(entry => entry.GroupId == groupId)
        .Include(group => group.Messages).ToListAsync();
      }

      return query.ToList();
    }

    // POST api/groups
    [HttpPost]
    public void Post([FromBody] Group group)
    {
      _db.Groups.Add(group);
      _db.SaveChanges();
    }
  }
}