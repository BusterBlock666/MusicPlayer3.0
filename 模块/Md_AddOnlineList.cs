using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.模块
{
    public partial class Md_AddOnlineList : Form
    {
        private delegate void setProgressValueCal(int value, int current, int total);
        public Md_AddOnlineList()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            status_label.Text = "开始添加，请等待……   不要关闭添加窗口";
            enter_btn.Enabled = false;
            cancel_btn.Enabled = false;
            url_textb.Enabled = false;
            Thread t1 = new Thread(Add_List);
            t1.IsBackground = true;
            t1.Start();
        }
        private void ShowProgress(int value,int current,int total)
        {
            progressBar1.Value = value;
            status_label.Text = "正在添加    " + current.ToString() + "/" + total.ToString();
        }

        private void Add_List()
        {
            try
            {
                string reg1 = @"id=\d+";
                Regex reg2 = new Regex(reg1, RegexOptions.IgnoreCase | RegexOptions.Singleline, TimeSpan.FromSeconds(2));
                MatchCollection mc = reg2.Matches(url_textb.Text);
                string s1 = null;
                foreach (Match m in mc)
                {
                    s1 = m.Groups[0].Value;
                    s1 = s1.Replace("id=", string.Empty);
                }
                System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                string url1 = string.Format("https://netease-cloud-music-api-213zvran7-busterblock666.vercel.app/playlist/detail?id={0}", s1);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url1);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                string result;
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
                stream.Close();
                JObject jobj1 = JObject.Parse(result);
                string song_count = jobj1["playlist"]["trackCount"].ToString();
                int songs_count = int.Parse(song_count);
                var song_dic = new Dictionary<string, string>
                {

                };
                bool isCheck2 = true;
                bool ifCheck = true;
                string song_id = null;
                float percent = 0;
                for (int i = 0; i < songs_count; i++)
                {
                    song_id = jobj1["playlist"]["trackIds"][i]["id"].ToString();
                    song_dic["id"] = song_id;
                    string url2 = string.Format("https://autumnfish.cn/song/detail?ids={0}", song_id);
                    HttpWebRequest req1 = (HttpWebRequest)WebRequest.Create(url2);
                    HttpWebResponse resp1 = (HttpWebResponse)req1.GetResponse();
                    Stream stream1 = resp1.GetResponseStream();
                    string result1;
                    using (StreamReader reader1 = new StreamReader(stream1))
                    {
                        result1 = reader1.ReadToEnd();
                    }
                    JObject jobj2 = JObject.Parse(result1);
                    string song_name = jobj2["songs"][0]["name"].ToString();
                    string author_name = jobj2["songs"][0]["ar"][0]["name"].ToString();
                    song_dic["name"] = song_name;
                    string songlist_name = jobj1["playlist"]["name"].ToString().Replace("|", "");
                    string path1 = "./Necessary_Forlder/songlist/" + songlist_name + ".txt";
                    if ((!File.Exists(path1)) && ifCheck)
                    {
                        FileStream fs = File.Create(path1);
                        fs.Close();
                        ifCheck = false;
                    }
                    else
                    {
                        if (File.Exists(path1) && ifCheck)
                        {
                            status_label.Text = "歌单已经存储过";
                            enter_btn.Enabled = true;
                            cancel_btn.Enabled = true;
                            url_textb.Enabled = true;
                            break;
                        }
                    }
                    if (isCheck2)
                    {
                        using (StreamWriter List_STO = new StreamWriter(path1, true))
                        {
                            List_STO.Write("Online||" + s1 + "||" + songs_count + "\n");
                            isCheck2 = false;
                        }
                    }
                    using(StreamWriter List_STO2 = new StreamWriter(path1, true))
                    {
                        List_STO2.Write(song_dic["id"] + "||" + song_dic["name"] + "||" + author_name + "\n");
                        percent = (float)i / (float)songs_count;
                        setProgressValueCal showPro = new setProgressValueCal(ShowProgress);
                        this.Invoke(showPro, new object[] { (int)(percent * 100) + 1, i + 1, songs_count });
                    }
                    if(i == songs_count - 1)
                    {
                        watch.Stop();
                        string time = watch.ElapsedMilliseconds.ToString();
                        status_label.Text = "添加成功" + "耗时:" + time + "ms";
                        this.Close();
                    }
                }
            }
            catch(Exception e)
            {
                status_label.Text = "出错！！！错误信息：\n" + e.Message + e.StackTrace.Substring(e.StackTrace.IndexOf("行号"),e.StackTrace.Length-e.StackTrace.IndexOf("行号"));
                cancel_btn.Enabled = true;
                enter_btn.Enabled = true;
                url_textb.Enabled = true;
            }
        }

        private void Md_AddOnlineList_Load(object sender, EventArgs e)
        {

        }
    }
}
