using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace StoryDownloader3
{
    public partial class FrmMain : Form
    {

        KakaoAPI kapi;
        private bool isRun;

        public FrmMain()
        {
            InitializeComponent();            
            kapi = new KakaoAPI(File.ReadAllText("test.txt"));
        }

        private async Task DoBackup()
        {
            await BackupArticles();
        }

        private async Task BackupComments(string articleID, string createdTime, string saveDirectory)
        {
            string since = "";

            while (true)
            {
                JArray commentsArray = await kapi.GetComments(articleID, since);

                if (commentsArray.Count == 0)
                {
                    break;
                }

                since = commentsArray[commentsArray.Count - 1]["id"].ToString();
                using (StreamWriter sw = new StreamWriter($"{labelSavePath.Text}\\{saveDirectory}\\{createdTime}{articleID}_comments.txt", true))
                {
                    for (int i = 0; i < commentsArray.Count; i++)
                    {
                        DateTime createdDateTime = TimeZoneInfo.ConvertTimeFromUtc((DateTime)commentsArray[i]["created_at"], TimeZoneInfo.Local);
                        string commentTime = createdDateTime.ToString("yyyy.MM.dd HH:mm:ss");
                        string commentAuthor = commentsArray[i]["writer"]["display_name"].ToString();
                        string commentID = commentsArray[i]["id"].ToString();
                        JArray contentsArray = (JArray)commentsArray[i]["decorators"];
                        for (int j = 0; j < contentsArray.Count; j++)
                        {
                            string contentType = contentsArray[j]["type"].ToString();
                            string contents = "";
                            if (contentType.Equals("image"))
                            {
                                string downloadURL = contentsArray[j]["media"]["origin_url"].ToString();
                                Uri uri = new Uri(downloadURL);
                                string downloadExt = Path.GetExtension(uri.LocalPath);
                                string saveFileName = $"{createdTime}{articleID}_{commentID}_{j}{downloadExt}";
                                await kapi.DownloadMedia(downloadURL, $"{labelSavePath.Text}\\{saveDirectory}\\{saveFileName}");
                                contents += ("(" + saveFileName + ")\r\n");
                            } else { contents += (contentsArray[j]["text"].ToString() + "\r\n"); }
                            
                            await sw.WriteLineAsync(commentAuthor);
                            await sw.WriteLineAsync(commentTime);
                            await sw.WriteLineAsync(contents);

                        }
                    }
                }
            }

            return;
        }

        private async Task BackupArticles()
        {
            progressStatus.ValueNumber = 0;
            int articleCount = await kapi.GetArticleCount();
            int curCount = 0;

            string since = "";
            while (true)
            {
                JArray jArr = await kapi.GetArticles(since);
                if (jArr.Count == 0)
                {
                    break;
                }

                for (int i = 0; i < jArr.Count; i++)
                {
                    string content = jArr[i]["content"].ToString();
                    string articleID = jArr[i]["id"].ToString();
                    DateTime createdDateTime = TimeZoneInfo.ConvertTimeFromUtc((DateTime)jArr[i]["created_at"], TimeZoneInfo.Local);
                    string saveTime = createdDateTime.ToString("yyyyMMdd_HHmmss");
                    string saveDirectory = createdDateTime.ToString("yyyyMMdd");
                    string saveFileName = saveTime + articleID;

                    if (!Directory.Exists($"{labelSavePath.Text}\\{saveDirectory}\\"))
                    {
                        Directory.CreateDirectory($"{labelSavePath.Text}\\{saveDirectory}\\");
                    }

                    File.WriteAllText($"{labelSavePath.Text}\\{saveDirectory}\\{saveFileName}.txt", content, Encoding.UTF8);

                    if (jArr[i]["media"] != null)
                    {
                        JArray mediaArr = (JArray)jArr[i]["media"];
                        for (int j = 0; j < mediaArr.Count; j++)
                        {
                            string extension = GetExtension(mediaArr[j]["content_type"].ToString());
                            string downloadType = "origin_url";

                            if (extension == "mp4")
                            {
                                downloadType = "url";
                            }

                            string contentsURL = mediaArr[j][downloadType].ToString();
                            await kapi.DownloadMedia(contentsURL, $"{labelSavePath.Text}\\{saveDirectory}\\{saveFileName}_{j}.{extension}");
                        }
                    }

                    if (chkComments.Checked)
                    {
                        await BackupComments(articleID, saveTime, saveDirectory);
                    }

                    curCount += 1;
                    float pVal = (float)curCount / (float)articleCount * 100;
                    labelStatus.Text = $"게시글 {articleCount}개 중 {curCount}개 다운로드";
                    labelStatus.Invalidate();
                    progressStatus.ValueNumber = (int)pVal;
                    progressStatus.Invalidate();
                }

                since = jArr[jArr.Count - 1]["id"].ToString();
                
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    labelSavePath.Text = fbd.SelectedPath;
                    labelSavePath.Invalidate();
                }
            }
        }

        private string GetExtension(string type)
        {
            switch(type)
            {
                case "image/jpeg":
                    return "jpg";
                case "image/png":
                    return "png";
                case "image/gif":
                    return "gif";
                case "video/mp4":
                    return "mp4";
            }

            return "jpg";

        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            await kapi.LoadInformation();
            SetText(labelNickname, kapi.nickname + "님");  
        }

        private void SetText(Control label, string str)
        {
            label.Text = str;
            label.Invalidate();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            await DoBackup();
        }
    }
}
