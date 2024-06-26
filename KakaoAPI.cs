using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StoryDownloader3;

public class KakaoAPI(string _loginCookie)
{
    public string LoginID { get; set; }
    public string Nickname { get; set; }

    public async Task LoadInformation()
    {
        LoginID = await GetLoginID();
        Nickname = await GetNickname(LoginID);
    }

    private async Task<string> PostStoryReq(string url, string postData)
    {
        HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(url);
        webReq.Method = "POST";
        webReq.Host = "story.kakao.com";
        webReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0";
        webReq.Accept = "application/json";
        webReq.Referer = "https://story.kakao.com/";
        webReq.Headers["Accept-Language"] = "ko";
        webReq.Headers["X-Kakao-ApiLevel"] = "49";
        webReq.Headers["X-Kakao-DeviceInfo"] = "web:-;-;-";
        webReq.Headers["X-Requested-With"] = "XMLHttpRequest";
        webReq.Headers["Cookie"] = _loginCookie;
        webReq.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

        using (StreamWriter stDataParams = new StreamWriter(await webReq.GetRequestStreamAsync()))
        {
            await stDataParams.WriteAsync(postData);
        }

        HttpWebResponse webRes = (HttpWebResponse)await webReq.GetResponseAsync();

        string response = "";
        using (StreamReader sr = new StreamReader(webRes.GetResponseStream(), Encoding.UTF8))
        {
            response = sr.ReadToEnd();
        }

        return response;

    }

    private async Task<string> GetStoryReq(string url, string referer = "")
    {
        HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(url);
        webReq.Method = "GET";
        webReq.Host = "story.kakao.com";
        webReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:35.0) Gecko/20100101 Firefox/35.0";
        webReq.Accept = "application/json";
        webReq.Referer = $"https://story.kakao.com/{referer}";
        webReq.Headers["Accept-Language"] = "ko";
        webReq.Headers["X-Kakao-ApiLevel"] = "49";
        webReq.Headers["X-Kakao-DeviceInfo"] = "web:-;-;-";
        webReq.Headers["X-Requested-With"] = "XMLHttpRequest";
        webReq.Headers["Cookie"] = _loginCookie;
        webReq.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

        HttpWebResponse webRes = (HttpWebResponse)await webReq.GetResponseAsync();

        string response = "";
        using (StreamReader sr = new StreamReader(webRes.GetResponseStream(), Encoding.UTF8))
        {
            response = sr.ReadToEnd();
        }

        return response;
    }

    public async Task DownloadMedia(string url, string savePath)
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                client.Headers.Add("Referer", $"https://story.kakao.com/{LoginID}");
                await client.DownloadFileTaskAsync(new Uri(url), savePath);
            }
            catch (IOException ex) { return; }
            catch (Exception ex) { return; }
        }
    }

    private async Task<string> GetLoginID()
    {
        JObject jObj = JObject.Parse(await GetStoryReq("https://story.kakao.com/a/settings/profile"));
        return jObj["id"].ToString();
    }

    private async Task<string> GetNickname(string userid)
    {
        JObject jObj = JObject.Parse(await GetStoryReq("https://story.kakao.com/a/settings/profile"));
        return jObj["display_name"].ToString();
    }

    public async Task<JArray> GetArticles(string since)
    {
        JObject jObj = JObject.Parse(await GetStoryReq($"https://story.kakao.com/a/profiles/{LoginID}?with=activities&since={since}"));
        return (JArray)jObj["activities"];
    }

    public async Task<JArray> GetComments(string articleID, string since)
    {
        return JArray.Parse(await GetStoryReq($"https://story.kakao.com/a/activities/{articleID}/comments?lpp=30&order=asc&since={since}", articleID.Replace(".", "/")));
    }

    public async Task<int> GetArticleCount()
    {
        JObject jObj = JObject.Parse(await GetStoryReq("https://story.kakao.com/a/settings/profile"));
        return (int)jObj["activity_count"];
    }

    public async Task<JArray> GetFriends()
    {
        JObject jObj = JObject.Parse(await GetStoryReq($"https://story.kakao.com/a/friends"));
        return (JArray)jObj["profiles"];
    }

    public async Task<JArray> GetInvitations()
    {
        return JArray.Parse(await GetStoryReq("https://story.kakao.com/a/invitations"));
    }

    public async Task<JArray> GetMessages(string since)
    {
        return JArray.Parse(await GetStoryReq($"https://story.kakao.com/a/messages?since={since}"));
    }
}
