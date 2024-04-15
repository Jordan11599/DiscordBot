using DisCatSharp.CommandsNext;
using DisCatSharp.Entities;
using DiscordBot.Models;
using Sentry.Protocol;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Utils.API;

public class Initializing
{
    static readonly HttpClient client = new HttpClient();

    public static async Task<User> CallAPI(int UID)
    {
        var baseURL = "api.mihomo.me";

        using HttpResponseMessage response = await client.GetAsync($"https://{baseURL}/sr_info_parsed/{UID}?lang=en");
        response.EnsureSuccessStatusCode();

        try
        {
            return await response.Content.ReadFromJsonAsync<User>();
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }



}