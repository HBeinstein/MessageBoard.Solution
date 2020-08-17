using System;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
  public class MessageBoardContext : DbContext
  {
    public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
      : base(options)
      {
      }

      public DbSet<Message> Messages { get; set; }
      public DbSet<Group> Groups { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Message>()
        .HasData(
          new Message { MessageId = 1, Title = "Hello", Body = "Hello? Hello???", Date = new DateTime(2020, 08, 16), UserName = "Test1", GroupId = 1},
          new Message { MessageId = 2, Title = "Goodbye", Body = "I don't know why you say goodbye I say hello.", Date = DateTime.Today, UserName = "Test2", GroupId = 1},
          new Message { MessageId = 3, Title = "This is only a test", Body = "This is a test of the emergency alert system.", Date = DateTime.Today, UserName = "Test3", GroupId = 2},
          new Message { MessageId = 4, Title = "If this was a real alert", Body = "You would be dead. Probably, who knows. If you saw a flash, most likely.", Date = DateTime.Today, UserName = "Test4", GroupId = 3},
          new Message { MessageId = 5, Title = "My Second Message", Body = "I couldn't stay away", Date = new DateTime(2020, 08, 18), UserName = "Test2", GroupId = 3}
        );

        builder.Entity<Group>()
        .HasData(
          new Group { GroupId = 1, Name = "The Mod Squad" },
          new Group { GroupId = 2, Name = "Mighty Morphin Power Rangers" },
          new Group { GroupId = 3, Name = "Blink 182" }
        );
      }
  }
}