using Intermediate_Generisk_implementasjon.interfaces;
using Intermediate_Generisk_implementasjon.Models;

namespace Intermediate_Generisk_implementasjon.Classes;

public class Repository<T> : IRepository<T>
{
    private List<UserInfo> userList = new List<UserInfo> // creates the the list
    {
        new UserInfo { Id = 1 }, // Sets default Id to 1
    };

    public void Create()
    {
        // Sets the next highest Id and user Id
        var id = userList.Max(u => u.Id) + 1;

        // Gets the info about the user
        Console.Write("Write the users Name: ");
        var userName = Console.ReadLine();
        Console.Write("Write the users Age: ");
        var userAge = Console.ReadLine();
        Int32.TryParse(userAge, out var age);
        Console.Write("Write the users Mail address: ");
        var userMail = Console.ReadLine();

        // Creates the user and adding it do the list
        var user = CreateUser(id, userName!, age, userMail!);
        Console.WriteLine("Your user was successfully created");
        userList.Add(user);
    }

    // Assign the different info to the user property
    public UserInfo CreateUser(int id, string username, int age, string usermail)
    {
        var user = new UserInfo
        {
            Id = id,
            userName = username,
            userAge = age,
            userMail = usermail,
        };
        return user;
    }

    public void Delete()
    {
        // Gets the id from the user and check if its an number
        Console.Write("Write the users ID to delete: ");
        var user = Console.ReadLine();
        // If its an nummber then it returns true
        var validNumber = int.TryParse(user, out var userId);

        // If it is a number AND greater than 0, then continue.
        if (validNumber && userId > 0)
        {
            // Gets the user to delete from userList
            var userDelete = userList.FindIndex(u => u.Id == userId);
            // If user exist then it deletes the user, and if not then error
            if (userDelete >= 0)
            {
                userList.RemoveAt(userDelete);
                Console.WriteLine($"User with Id {userId} has been successfully Deleted.");
            }
            else
            {
                Console.WriteLine($"Error: User with ID {userId} not found.");
            }
        }
        else
        {
            Console.WriteLine($"Error: Pls write the users ID.");
        }
    }

    public void Update()
    {
        // Gets the id from the user and checks if its an number
        Console.Write("Write the users Id: ");
        var input = Console.ReadLine();
        var validNumber = int.TryParse(input, out var userId);

        // If it is a number AND greater than 0, then continue.
        if (validNumber && userId > 0)
        {
            // Gets the user from the userList
            var userUpdate = userList.FindIndex(u => u.Id == userId);

            if (userUpdate >= 0)
            {
                // Updates the user info
                var updatedInfo = updateInfo(userId);
                userList[userUpdate] = updatedInfo;
                Console.WriteLine($"User with Id {userId} has been successfully updated.");
            }
            else
            {
                Console.WriteLine($"Error: User with Id {userId} not found. Update failed.");
            }
        }
        else
        {
            Console.WriteLine($"Error: Pls write the users ID.");
        }
    }

    private UserInfo updateInfo(int id)
    {
        // Gets the info about the user and sets the new info to the user
        Console.Write("Write the new Name: ");
        var userName = Console.ReadLine();
        Console.Write("Write the new Age: ");
        var userAge = Console.ReadLine();
        Int32.TryParse(userAge, out var age);
        Console.Write("Write the new Mail address: ");
        var userMail = Console.ReadLine();

        var user = new UserInfo
        {
            Id = id,
            userName = userName!,
            userAge = age,
            userMail = userMail!,
        };
        return user;
    }

    // shows all the user in the repository
    public void showUsers()
    {
        foreach (var user in userList)
        {
            Console.WriteLine(
                $"ID: {user.Id}, Username: {user.userName}, User age: {user.userAge}, User Email: {user.userMail}"
            );
        }
    }
}
