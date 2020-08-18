using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MessageBoard.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime Date { get; set; }
    public string UserName { get; set; }
    public int GroupId { get; set; }
  }
}