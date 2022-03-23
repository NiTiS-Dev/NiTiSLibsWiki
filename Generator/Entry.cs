using System;

public static class Entry
{
	public static void Main() {
		var asms = AppDomain.CurrentDomain.GetAssemblies();
		foreach(var asm in asms) {
			
			foreach(var type in asm.GetTypes()) {
				//if (type.FullName.StartsWith("Microsoft.")) continue;
				//if (type.FullName.StartsWith("System.")) continue;
				Console.WriteLine(type);
			}
			
		}
	}
}
