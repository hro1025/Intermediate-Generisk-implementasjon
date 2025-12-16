using Intermediate_Generisk_implementasjon.interfaces;

namespace Intermediate_Generisk_implementasjon.Models;

// sets the interface for the users info
public class UserInfo : IEntity
{
    public int Id { get; set; }
    public string userName { get; set; } = "";
    public int userAge { get; set; }
    public string userMail { get; set; } = "";
}
