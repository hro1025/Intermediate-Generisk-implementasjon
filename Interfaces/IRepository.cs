using Intermediate_Generisk_implementasjon.Classes;

namespace Intermediate_Generisk_implementasjon.interfaces;

// sets the interface for the repository
public interface IRepository<T>
{
    void Create();

    void showUsers();

    void Update();

    void Delete();
}
