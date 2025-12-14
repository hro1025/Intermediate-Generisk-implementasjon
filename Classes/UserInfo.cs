namespace Intermediate_Generisk_implementasjon.Classes;

public class UserInfo<T>
{
    public int userId { get; set; }
    public string userName { get; set; } = "";
    public int userAge { get; set; }
    public string userMail { get; set; } = "";
}
