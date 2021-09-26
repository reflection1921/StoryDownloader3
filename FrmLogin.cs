using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryDownloader3
{
    public partial class FrmLogin : Form
    {

        const int VERSION = 30;

        public FrmLogin()
        {
            InitializeComponent();

            CheckVersion();

        }

        private void CheckVersion()
        {
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create("http://chihaya.kr/sdownloader/version/version.txt");
            webReq.Method = "GET";
            webReq.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

            HttpWebResponse webRes = (HttpWebResponse)webReq.GetResponse();

            string response = "";
            using (StreamReader sr = new StreamReader(webRes.GetResponseStream(), Encoding.UTF8))
            {
                response = sr.ReadToEnd();
            }

            int newVersion;

            bool parsed = Int32.TryParse(response, out newVersion);

            if (!parsed)
            {
                return;
            }

            if (VERSION < newVersion)
            {
                MessageBox.Show("Story Downloader 3가 업데이트 되어 개발자 사이트로 이동합니다. 업데이트 후 이용해주세요.", "Story Downloader 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start("explorer.exe", "http://chihaya.kr/");
                //Application.Exit();
            }

        }

        private async void webView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {

            if (webView.Source.Host == "story.kakao.com")
            {
                List<CoreWebView2Cookie> cookies = await webView.CoreWebView2.CookieManager.GetCookiesAsync("https://story.kakao.com");
                bool isLogin = cookies.Exists(x => x.Name == "_kawlt");

                string cookie = "";

                if (isLogin)
                {
                    for (int i = 0; i < cookies.Count; i++)
                    {
                        cookie += $"{cookies[i].Name}={cookies[i].Value}; ";
                    }

                    FrmMain main = new FrmMain(cookie);
                    main.Show();
                    this.Hide();
                }

            }
        }
    }
}
