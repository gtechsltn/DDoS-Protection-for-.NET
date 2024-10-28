// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Are you ready for test press any key");
Console.ReadKey();

var apiUrl = "https://localhost:5001/WeatherForecast"; // Example API endpoint
using var client = new HttpClient();
try
{
    for (int i = 0; i < 21; i++)
    {
        // Making the GET request
        var response = await client.GetAsync(apiUrl);

        // Ensure the request was successful
        response.EnsureSuccessStatusCode();

        // Read the response content as a string
        var content = await response.Content.ReadAsStringAsync();
        if (content != null && content.Length > 0)
            Console.WriteLine("Getting response from server ->" + i.ToString());

    }

}
catch (Exception e)
{
    Console.WriteLine($"Request error: {e.Message}");
    Console.ReadKey();
}