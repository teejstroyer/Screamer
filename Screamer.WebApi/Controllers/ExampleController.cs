using Microsoft.AspNetCore.Mvc;
using Screamer.Infrastructure.Services.Interfaces;
using Screamer.WebApi.ViewModels;

namespace Screamer.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{

  private readonly ILogger<ExampleController> _logger;
  private readonly IExampleService _service;

  // Argument to be made that service layer should be in api project if you believe the business logic involves genrating view models. It might
  public ExampleController(IExampleService service, ILogger<ExampleController> logger)
  {
    _service = service;
    _logger = logger;
  }

  [HttpGet(Name = "GetAll")]
  public ListViewModel<ExampleViewModel> Get()
  {
    var examples = _service.GetAll().Select(i => new ExampleViewModel(i));
    return new ListViewModel<ExampleViewModel>(examples);
  }

}
