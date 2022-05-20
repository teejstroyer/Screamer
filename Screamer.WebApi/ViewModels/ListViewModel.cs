using System.Text.Json.Serialization;

namespace Screamer.WebApi.ViewModels;

public class ListViewModel<T>
{
	public ListViewModel(IEnumerable<T> items)
	{
		Items = items;
	}

	[JsonPropertyName ("items")]
	public IEnumerable<T> Items {get;set;} 

	[JsonPropertyName ("items-count")]
	public int ItemCount {get => Items.Count();}
}
