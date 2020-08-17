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
      public DbSet<GroupMessage> GroupMessages { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Message>()
        .HasData(
          new Message { MessageId = 1, Title = "Hello", Body = "Hello? Hello???", Date = DateTime.Today, UserName = "Test1"}
          new Message { MessageId = 2, Title = "Goodbye", Body = "I don't know why you say goodbye I say hello.", Date = DateTime.Today, UserName = "Test2"}
          new Message { MessageId = 1, Title = "This is only a test", Body = "This is a test of the emergency alert system.", Date = DateTime.Today, UserName = "Test3"}
          new Message { MessageId = 1, Title = "If this was a real alert", Body = "You would be dead. Probably, who knows. If you saw a flash most likely.", Date = DateTime.Today, UserName = "Test4"}
        )
      }
  }
}