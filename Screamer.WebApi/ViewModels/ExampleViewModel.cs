using System.Text.Json.Serialization;
using Screamer.Domain.Models;

namespace Screamer.WebApi.ViewModels;

public class ExampleViewModel
{
  public ExampleViewModel() { }
  public ExampleViewModel(Example example)
  {
    Id = example.Id;
    Name = example.Name;
    Age = example.Age;
  }

  [JsonPropertyName("id")]
  public int Id { get; set; }
  [JsonPropertyName("name")]
  public string? Name { get; set; }
  [JsonPropertyName("age")]
  public int Age { get; set; }
}
