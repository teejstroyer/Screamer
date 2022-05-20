using Screamer.Domain.Models;

namespace Screamer.Infrastructure.Repositories.Interfaces
{
  public interface IExampleRepository
  {
    int Add(Example example);
    void Delete(int id);
    void Update(Example example);
    IEnumerable<Example> GetAll();
    Example GetById(int id);
  }
}
