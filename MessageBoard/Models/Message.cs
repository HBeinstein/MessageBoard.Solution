using System;
using System.Collections.Generic;

namespace MessageBoard.Models
{
  public class Message
  {
    public Message()
    {
      this.Groups = new HashSet<GroupMessage>();
    }
    public int MessageId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime Date { get; set; }
    public string UserName { get; set; }

    public ICollection<GroupMessage> Groups { get; set; }
  }
}