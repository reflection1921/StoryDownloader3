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

        public FrmMain()
        {
            InitializeComponent();            
            kapi = new KakaoAPI(File.ReadAllText("test.txt"));
        }

        private async Task DoBackup()
        {
            string commentBackup = "";
            if (chkComments.Checked)
            {
                commentBackup = ", 댓글";
            }

            SetText(labelStatusMain, $"게시글(게시글, 사진, 동영상{commentBackup}) 백업 중...");
            await BackupArticles();

            progressStatusMain.ValueNumber = 25;
            progressStatusMain.Invalidate();

            SetText(labelStatusMain, "친구목록 백업 중...");
            await BackupFriends();

            progressStatusMain.ValueNumber = 50;
            progressStatusMain.Invalidate();

            SetText(labelStatusMain, "친구신청 목록 백업 중...");
            await BackupInvitations();

            progressStatusMain.ValueNumber = 75;
            progressStatusMain.Invalidate();

            SetText(labelStatusMain, "쪽지 백업 중...");
            await BackupMessages();

            progressStatusMain.ValueNumber = 100;
            progressStatusMain.Invalidate();
        }

        private async Task BackupMessages()
        {
            if (!chkMessages.Checked) { return; }

            string since = "";

            if (!Directory.Exists($"{labelSavePath.Text}\\Messages"))
            {
                Directory.CreateDirectory($"{labelSavePath.Text}\\Messages");
            }

            while (true)
            {
                JArray messageArr = await kapi.GetMessages(since);

                if (messageArr.Count > 0)
                {
                    since = messageArr[messageArr.Count - 1]["id"].ToString();
                } else
                {
                    break;
                }

                for (int i = 0; i < messageArr.Count; i++)
                {
                    DateTime createdDateTime = TimeZoneInfo.ConvertTimeFromUtc((DateTime)messageArr[i]["created_at"], TimeZoneInfo.Local);
                    string messageTime = createdDateTime.ToString("yyyy.MM.dd HH:mm:ss");
                    string saveFileName = "";
                    bool isSend = (messageArr[i]["type"].ToString() == "send") ? true : false;
                    string summary = messageArr[i]["summary"].ToString();
                    string content = "";

                    if (isSend)
                    {
                        string recvUser = messageArr[i]["receivers"][0]["display_name"].ToString();
                        string receiverID = messageArr[i]["receivers"][0]["id"].ToString();
                        saveFileName = $"{ReplaceNotAllowedChars(recvUser)}_{receiverID}";
                        content = $"[보낸 쪽지]\r\n수신자: {messageTime}\r\n발신일: {messageTime}\r\n{summary}\r\n";
                    } else
                    {
                        string sendUser = messageArr[i]["sender"]["display_name"].ToString();
                        string senderID = messageArr[i]["sender"]["id"].ToString();
                        saveFileName = $"{ReplaceNotAllowedChars(sendUser)}_{senderID}";
                        content = $"[받은 쪽지]\r\n발신자: {sendUser}\r\n수신일: {messageTime}\r\n{summary}\r\n";
                    }

                    using (StreamWriter sw = new StreamWriter($"{labelSavePath.Text}\\Messages\\{saveFileName}.txt", true))
                    {
                        await sw.WriteLineAsync(content);
                    }
                }

            }
            
        }

        private string ReplaceNotAllowedChars(string str)
        {
            return str.Replace("\\", "").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("\"", "").Replace("<", "").Replace(">", "").Replace("|", "");
        }

        private async Task BackupInvitations()
        {

            if (!chkInvitations.Checked) { return; }

            JArray inviteArr = await kapi.GetInvitations();
            StreamWriter swSent = new StreamWriter($"{labelSavePath.Text}\\보낸 친구신청목록.txt", true);
            StreamWriter swRecv = new StreamWriter($"{labelSavePath.Text}\\받은 친구신청목록.txt", true);

            for (int i = 0; i < inviteArr.Count; i++)
            {
                string nickname = inviteArr[i]["display_name"].ToString();
                string userid = inviteArr[i]["user_id"].ToString();
                string type = inviteArr[i]["type"].ToString();

                if (type.Equals("sent"))
                {
                    await swSent.WriteLineAsync($"{nickname} : {userid}");
                } else
                {
                    await swRecv.WriteLineAsync($"{nickname} : {userid}");
                }

            }

            swSent.Close();
            swRecv.Close();
        }

        private async Task BackupFriends()
        {
            if (!chkFriends.Checked) { return; }

            JArray friendsArr = await kapi.GetFriends();
            int friendCount = friendsArr.Count;
            progressStatus.ValueNumber = 0;
            progressStatus.Invalidate();
            SetText(labelStatus, "친구목록 백업 중...");


            using (StreamWriter sw = new StreamWriter($"{labelSavePath.Text}\\친구목록.txt", true))
            {
                for (int i = 0; i < friendCount; i++)
                {
                    string nickname = friendsArr[i]["display_name"].ToString();
                    string userid = friendsArr[i]["id"].ToString();
                    string channelPrefix = "";
                    if (userid.StartsWith("@"))
                    {
                        channelPrefix = "[#채널]";
                    }
                    await sw.WriteLineAsync($"{channelPrefix}{nickname} : {userid}");

                }

                progressStatus.ValueNumber = 100;
                progressStatus.Invalidate();
            }
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

                        if (contentsArray == null)
                        {
                            continue;
                        }

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

            progressStatus.ValueNumber = 100;
            progressStatus.Invalidate();
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

        private void SetText(Control control, string str)
        {
            control.Text = str;
            control.Invalidate();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (labelSavePath.Text.Equals("경로를 설정하세요."))
            {
                MessageBox.Show("경로를 먼저 설정하세요.", "Story Downloader 3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await DoBackup();
            //await BackupFriends();
        }
    }
}
