using System.Collections;
using Intermediate_Generisk_implementasjon.Classes;
using Spectre.Console;

namespace Intermediate_Generisk_implementasjon;

class Program
{
    static void Main(string[] args)
    {
        var repo = new Repository<UserInfo>();
        var user = new UserInfo();
        while (true)
        {
            Console.WriteLine();
            var operation = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[bold]Choose your Operation[/]?")
                    .AddChoices(new[] { "Create", "Update", "Delete", "Show Users", "Exit" })
            );

            switch (operation)
            {
                case "Create":
                    repo.Create();
                    break;

                case "Update":
                    repo.Update(user);
                    break;

                case "Delete":
                    repo.Delete();
                    break;

                case "Show Users":
                    repo.showUsers();
                    break;

                case "Exit":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
