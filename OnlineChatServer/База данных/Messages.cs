using System;

namespace OnlineChatServer.База_данных
{
  public class Messages
  {
    public int id_message { get; set; } 
    public int id_chat { get; set; }  
    public int id_user { get; set; }  
    public string content { get; set; }
    public DateTime send_time { get; set; }
  }
}
