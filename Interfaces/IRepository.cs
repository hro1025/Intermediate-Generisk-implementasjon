using Intermediate_Generisk_implementasjon.Classes;

namespace Intermediate_Generisk_implementasjon.interfaces;

public interface IRepository<T>
{
    void Create();

    void showUsers();

    void Update(UserInfo user);

    void Delete();
}
