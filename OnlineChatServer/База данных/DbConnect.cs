using Microsoft.EntityFrameworkCore;

namespace OnlineChatServer.База_данных
{
  public class AppContext : DbContext
  {
    static string server = "localhost";
    static string database = "test";
    static string user = "root";
    static string password = "root";
    public DbSet<Users> Users { get; set; }
    public DbSet<Chats> Chats { get; set; }
    public DbSet<Messages> Messages { get; set; }
    public AppContext()
    {
      Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL($"Server = {server}; Database = {database}; Uid = {user}; Pwd = {password};");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Users>().Property(x => x.avatar).HasColumnType("Blob");
    }
  }
}
