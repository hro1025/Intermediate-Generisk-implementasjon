using System.Diagnostics.CodeAnalysis;
using Intermediate_Generisk_implementasjon.interfaces;

namespace Intermediate_Generisk_implementasjon.Classes;

public class Repository<T> : IRepository<T>
{
    private List<UserInfo> userList = new List<UserInfo>
    {
        new UserInfo { Id = 1, userId = 1 },
    };

    public void Create()
    {
        var id = userList.Max(u => u.Id) + 1;
        var userId = userList.Max(u => u.userId) + 1;
        Console.Write("Write the users Name: ");
        var userName = Console.ReadLine();
        Console.Write("Write the users Age: ");
        var userAge = Console.ReadLine();
        Int32.TryParse(userAge, out var age);
        Console.Write("Write the users Mail address: ");
        var userMail = Console.ReadLine();

        var user = CreateUser(id++, userId++, userName!, age, userMail!);
        Console.WriteLine("Your user was successfully created");
        userList.Add(user);
    }

    public UserInfo CreateUser(int id, int userId, string username, int age, string usermail)
    {
        var user = new UserInfo
        {
            Id = id,
            userId = userId,
            userName = username,
            userAge = age,
            userMail = usermail,
        };
        return user;
    }

    public void Delete()
    {
        Console.Write("Write the users ID to delete: ");
        var user = Console.ReadLine();
        Int32.TryParse(user, out var userId);

        if (userId >= 0)
        {
            var userDelete = userList.FindIndex(u => u.Id == userId);

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

    public void Update(UserInfo user)
    {
        Console.Write("Write the users Id: ");
        var input = Console.ReadLine();
        Int32.TryParse(input, out var userId);
        if (userId >= 0)
        {
            var userUpdate = userList.FindIndex(u => u.Id == userId);
            if (userUpdate >= 0)
            {
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
            userId = id,
            userName = userName!,
            userAge = age,
            userMail = userMail!,
        };
        return user;
    }

    public void showUsers()
    {
        foreach (var user in userList)
        {
            Console.WriteLine(
                $"ID: {user.Id}, User ID: {user.userId}, Username: {user.userName}, User age: {user.userAge}, User Email: {user.userMail}"
            );
        }
    }
}
