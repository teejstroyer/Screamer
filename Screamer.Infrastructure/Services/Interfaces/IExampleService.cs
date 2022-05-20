
using Screamer.Domain.Models;

namespace Screamer.Infrastructure.Services.Interfaces
{
	public interface IExampleService {
    int Add(Example example);
    void Delete(int id);
    void Update(Example example);
    IEnumerable<Example> GetAll();
    Example GetById(int id);
	}
}
