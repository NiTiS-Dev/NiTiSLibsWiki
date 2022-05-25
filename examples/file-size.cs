File file = new File("cat.png");
if (file.Exists())
{
	Console.WriteLine(file.Size.ToString("MB"));
}
else
{
	Console.WriteLine("File {0} not found :(", file.Path);
}