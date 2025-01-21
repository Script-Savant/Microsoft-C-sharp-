static async Task SummonDogLocally()
{
    Console.WriteLine("1. Summoning Dog locally ...");

    string dogText = await File.ReadAllTextAsync("dog-urls.txt");

    Console.WriteLine($"2. Dog Summoned Locally \n{dogText}");
}

// await SummonDogLocally();

static async Task SummonDogFromURL(string URL)
{
    Console.WriteLine("1. Summoning Dog from URL");

    using (var httpClient = new HttpClient())
    {
        string result = await httpClient.GetStringAsync(URL);
        Console.WriteLine($"2. Dog Summoned from URL \n{result}");
    }
}

await SummonDogFromURL("https://i.kinja-img.com/gawker-media/image/upload/s--pRSisy9n--/c_scale,f_auto,fl_progressive,q_80,w_800/qcsny75ocrnawafhs8pj.jpg");