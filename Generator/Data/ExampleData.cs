using System.Text.Json;
using System.Text.Json.Serialization;

namespace Generator.Data;


public class ExampleData
{
	[JsonPropertyName("lang")]
	public string Language { get; set; }
	[JsonPropertyName("title")]
	public string Title { get; set; }
	[JsonPropertyName("description")]
	public string Description { get; set; }
	[JsonPropertyName("type")]
	public string Type { get; set; }
	public ExampleData()
	{

	}
}
