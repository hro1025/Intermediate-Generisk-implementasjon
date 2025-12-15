using System.ComponentModel;
using Intermediate_Generisk_implementasjon.Classes;

namespace Intermediate_Generisk_implementasjon;

class Program
{
    static void Main(string[] args)
    {
        var repo = new Repository<UserInfo>();
        var user = new UserInfo();

        while (true)
        {
            repo.Create();
            repo.Update(user);
            var exit = Console.ReadLine();

            if (exit == "exit")
            {
                break;
            }
        }

        repo.Read();
    }
}
