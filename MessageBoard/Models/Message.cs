using System;
using System.Collections.Generic;

namespace MessageBoard.Models
{
  // [JsonObject(IsReference = true)]
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

    // [JsonIgnore]
    // [IgnoreDataMember]
    public ICollection<GroupMessage> Groups { get; set; }
  }
}