using DisCatSharp.CommandsNext;
using DisCatSharp.Entities;
using Sentry.Protocol;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Utils.API;

public class Initializing
{
    static readonly HttpClient client = new HttpClient();

    public static async Task CallAPI(int UID)
    {
        var baseURL = "api.mihomo.me";

        using HttpResponseMessage response = await client.GetAsync($"https://{baseURL}/sr_info_parsed/{UID}?lang=en");
        response.EnsureSuccessStatusCode();

        //Todo
        //Pass Data back to run through different Embed Generators based on the commands
        //Cache into DB to avoid API rate limits
        await response.Content.ReadFromJsonAsync<User>();

    }



}