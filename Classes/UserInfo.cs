using Intermediate_Generisk_implementasjon.interfaces;

namespace Intermediate_Generisk_implementasjon.Classes;

public class UserInfo : IEntity
{
    public int Id { get; set; }
    public int userId { get; set; }
    public string userName { get; set; } = "";
    public int userAge { get; set; }
    public string userMail { get; set; } = "";
}
