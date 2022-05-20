
using Screamer.Domain.Models;
using Screamer.Infrastructure.Repositories.Interfaces;
using Screamer.Infrastructure.Services.Interfaces;

namespace Screamer.Infrastructure.Services
{
	public class ExampleService : IExampleService
	{
		readonly IExampleRepository _repository;

		public ExampleService(IExampleRepository repository)
		{
			_repository = repository;
		}

		public int Add(Example example) => _repository.Add(example);
		public void Delete(int id) => _repository.Delete(id);
		public IEnumerable<Example> GetAll() => _repository.GetAll();
		public Example GetById(int id) => _repository.GetById(id);
		public void Update(Example example) => _repository.Update(example);
	}
}
