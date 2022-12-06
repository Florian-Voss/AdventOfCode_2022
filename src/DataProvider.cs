public class DataProvider
{
    public static async Task<string> GetDataFromDay(int day)
    {
        if (File.Exists(@$"InputData\Day{day}.txt"))
        {
            return await File.ReadAllTextAsync(@$"InputData\Day{day}.txt");
        }
        else
        {
            using (var client = new HttpClient())
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"https://adventofcode.com/2022/day/{day}/input");
                requestMessage.Headers.Add("cookie", $"session={Constants.SESSION_COOKIE}");
                var response = await client.SendAsync(requestMessage);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                await File.WriteAllTextAsync(@$"InputData\Day{day}.txt", data);
                return data;
            }
        }
    }
}