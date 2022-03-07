using System;

namespace OnlineChatServer.База_данных
{
  public class Users
  {
    public int id { get; set; }
    public string login { get; set; }
    public string password { get; set; }
    public string name { get; set; }
    public DateTime last_seen { get; set; }
    public byte[] avatar { get; set; }
  }
}
