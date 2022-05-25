using NiTiS.Collections.Generic;
using NiTiS.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Generator;
public static class Examples
{
	private static readonly Sequence<Twosome<Data.ExampleData, string>> examples = new();
	public static IEnumerable<Twosome<Data.ExampleData, string>> GetByType(DocType type)
		=> examples.Where(s => s.Left.Type == type.FullName);
	public static void AddExample(File config, File code)
	{
		string json = config.ReadText();
		Data.ExampleData? data = JsonSerializer.Deserialize<Data.ExampleData>(json);
		if (data is null) return;
		examples.Add(new(data, code.ReadText()));
	}
}
