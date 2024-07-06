using RestSharp;
using System;
using System.IO;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace StoryDownloader3;

public class KakaoAPI(string loginCookie)
{
    private readonly static RestClient s_client = new("https://story.kakao.com");

    public string LoginID { get; set; }
    public string Nickname { get; set; }

    public async Task LoadInformation()
    {
        LoginID = await GetLoginID();
        Nickname = await GetNickname();
    }

    private async Task<string> PostStoryReq(string endpoint, string postData)
    {
        // Initialize the RestSharp client
        RestRequest request = new(endpoint, Method.Post);

        // Set headers
        request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0");
        request.AddHeader("Accept", "application/json");
        request.AddHeader("Referer", "https://story.kakao.com/");
        request.AddHeader("Accept-Language", "ko");
        request.AddHeader("X-Kakao-ApiLevel", "49");
        request.AddHeader("X-Kakao-DeviceInfo", "web:-;-;-");
        request.AddHeader("X-Requested-With", "XMLHttpRequest");
        request.AddHeader("Cookie", loginCookie);
        request.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");

        // Set the request body
        request.AddParameter("application/x-www-form-urlencoded", postData, ParameterType.RequestBody);

        // Execute the request
        RestResponse response = await s_client.ExecuteAsync(request);

        // Return the content of the response
        return response.Content;
    }

    private async Task<string> GetStoryReq(string endpoint, string referer = "")
    {
        // Initialize the RestSharp request
        RestRequest request = new(endpoint, Method.Get);

        // Set headers
        request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0");
        request.AddHeader("Accept", "application/json");
        request.AddHeader("Referer", $"https://story.kakao.com/{referer}");
        request.AddHeader("Accept-Language", "ko");
        request.AddHeader("X-Kakao-ApiLevel", "49");
        request.AddHeader("X-Kakao-DeviceInfo", "web:-;-;-");
        request.AddHeader("X-Requested-With", "XMLHttpRequest");
        request.AddHeader("Cookie", loginCookie);
        request.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");

        // Execute the request
        RestResponse response = await s_client.ExecuteAsync(request);

        // Return the content of the response
        return response.Content;
    }
    public async Task DownloadMedia(string url, string savePath)
    {
        // Create a RestRequest for the download
        RestRequest request = new(url, Method.Get);
        request.AddHeader("Referer", $"https://story.kakao.com/{LoginID}");

        // Execute the request and get the raw byte response
        byte[] response = await s_client.DownloadDataAsync(request);

        try
        {
            // Write the response to a file
            await File.WriteAllBytesAsync(savePath, response);
        }
        catch (IOException) { } // Ignore
        catch (Exception) { } // Ignore
    }


    private async Task<string> GetLoginID()
    {
        JsonNode jObj = JsonNode.Parse(await GetStoryReq("/a/settings/profile"));
        return jObj["id"].ToString();
    }

    private async Task<string> GetNickname()
    {
        JsonNode jObj = JsonNode.Parse(await GetStoryReq("/a/settings/profile"));
        return jObj["display_name"].ToString();
    }

    public async Task<JsonArray> GetArticles(string since)
    {
        JsonNode jObj = JsonNode.Parse(await GetStoryReq($"/a/profiles/{LoginID}?with=activities&since={since}"));
        return jObj["activities"].AsArray();
    }

    public async Task<JsonArray> GetComments(string articleID, string since)
    {
        return JsonNode.Parse(await GetStoryReq($"/a/activities/{articleID}/comments?lpp=30&order=asc&since={since}", articleID.Replace('.', '/'))).AsArray();
    }

    public async Task<int> GetArticleCount()
    {
        JsonNode jObj = JsonNode.Parse(await GetStoryReq("/a/settings/profile"));
        return (int)jObj["activity_count"];
    }

    public async Task<JsonArray> GetFriends()
    {
        JsonNode jObj = JsonNode.Parse(await GetStoryReq($"/a/friends"));
        return jObj["profiles"].AsArray();
    }

    public async Task<JsonArray> GetInvitations()
    {
        return JsonNode.Parse(await GetStoryReq("/a/invitations")).AsArray();
    }

    public async Task<JsonArray> GetMessages(string since)
    {
        return JsonNode.Parse(await GetStoryReq($"/a/messages?since={since}")).AsArray();
    }
}
