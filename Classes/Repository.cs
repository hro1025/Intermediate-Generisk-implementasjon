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
        Console.WriteLine("Enter Name");
        var userName = Console.ReadLine();
        Console.WriteLine("Enter Age");
        var userAge = Console.ReadLine();
        Int32.TryParse(userAge, out var age);
        Console.WriteLine("Enter Mail");
        var userMail = Console.ReadLine();

        var user = CreateUser(id++, userId++, userName!, age, userMail!);
        Console.WriteLine("A new user was created");
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

    public void Delete(int Id)
    {
        var userDelete = userList.FindIndex(u => u.Id == Id);
        userList.RemoveAt(userDelete);
    }

    public void Update(UserInfo user)
    {
        var userUpdate = userList.FindIndex(u => u.Id == user.Id);
        if (userUpdate >= 0)
        {
            var updatedInfo = updateInfo(user.Id);
            userList[userUpdate] = updatedInfo;
            Console.WriteLine($"User with Id {user.Id} has been successfully updated.");
        }
        else
        {
            Console.WriteLine($"Error: User with Id {user.Id} not found. Update failed.");
        }
    }

    private UserInfo updateInfo(int id)
    {
        Console.WriteLine("Enter Name");
        var userName = Console.ReadLine();
        Console.WriteLine("Enter Age");
        var userAge = Console.ReadLine();
        Int32.TryParse(userAge, out var age);
        Console.WriteLine("Enter Mail");
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

    public void Read()
    {
        foreach (var user in userList)
        {
            Console.WriteLine(
                $"ID: {user.Id}, User ID: {user.userId}, Username: {user.userName}, User age: {user.userAge}, User Email: {user.userMail}"
            );
        }
    }
}
