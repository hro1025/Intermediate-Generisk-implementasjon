using Intermediate_Generisk_implementasjon.Classes;
using Intermediate_Generisk_implementasjon.Models;
using Spectre.Console;

namespace Intermediate_Generisk_implementasjon;

class Program
{
    static void Main(string[] args)
    {
        var repo = new Repository<UserInfo>();

        while (true)
        {
            // create the selection menu
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
                    repo.Update();
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
