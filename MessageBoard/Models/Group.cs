using System;
using System.Collections.Generic;


namespace MessageBoard.Models
{
  // [JsonObject(IsReference = true)]
  public class Group
  {
    public Group()
    {
      this.Messages = new HashSet<GroupMessage>();
    }
    public int GroupId { get; set; }
    public string Name { get; set; }

    // [JsonIgnore]
    // [IgnoreDataMember]
    public ICollection<GroupMessage> Messages { get; set; }
  }
}