
Dictionary<string, string> wods = new Dictionary<string, string>
{
	{ "flop", "yığılmak" },
	{ "scold", "haşlanmak" }
};


while (wods.Count > 0)
{
	Console.WriteLine($"{wods.Keys.First()} is meaning:");

	string? answer = Console.ReadLine();

	if (wods.Values.First().ToLower() != answer?.ToLower())
	{
		Console.WriteLine("It is wrong!");
		continue;
	}
	Console.WriteLine("It is correct!");
	wods.Remove(wods.Keys.First());
}

Console.ReadLine();