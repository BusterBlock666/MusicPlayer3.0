using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MusicPlayer;
using Newtonsoft.Json.Linq;

public static class Md_SongGETPlay
{
    public static void SongGETPlay(string seletedItem,int seletedIndex)
    {
        string sLine;
        string sLine2 = null;
        string song_id = "";
        int i = 0;
        MainGUI.mg.axWindowsMediaPlayer1.Ctlcontrols.stop();
        MainGUI.mg.status_label.Text = "正在下载……";
        //Start
        List<string> filters = new List<string>();
        filters.Add("$");
        filters.Add("(");
        filters.Add(")");
        filters.Add("&");
        filters.Add("/");
        filters.Add("-");       
        foreach(string filter in filters)
        {
            seletedItem = seletedItem.Replace(filter, "");
        }
        //End  特殊符号过滤
        string song_path = "./Necessary_Forlder/song/" + seletedItem + ".mp3";
        string songchoose_path = "./Necessary_Forlder/list_choice.txt";
        using(StreamReader sr = new StreamReader(songchoose_path))
        {
            using (StreamReader sr2 = new StreamReader(sr.ReadLine()))
            {
                while((sLine = sr2.ReadLine()) != null)
                {
                    if (i == seletedIndex)
                    {
                        sLine2 = sr2.ReadLine();
                        MainGUI.mg.status_label.Text= "正在下载:    " + sLine2;
                        break;
                    }
                    i++;
                }
            }
            string[] sArray = Regex.Split(sLine2, @"\|\|");
            song_id = sArray[0];
            string author = sArray[2];
            if (!File.Exists(song_path))
            {
                try
                {
                    string cookies = "__remember_me=true; Max-Age=1296000; Expires=Thu, 19 Aug 2021 15:04:05 GMT; Path=/;;__csrf=e752dec57623969e5d31b7b15e7f9ddd; Max-Age=1296010; Expires=Thu, 19 Aug 2021 15:04:15 GMT; Path=/;;MUSIC_U=a0d6e49e037696d0b76ed26b9daebbff4f14efb5a6e88b0653e140749ab74b2ea4d920beea3abb0e05089d36715a4a6228256efc125910a2e381395bf06ec255; Max-Age=1296000; Expires=Thu, 19 Aug 2021 15:04:05 GMT; Path=/;";
                    string url = string.Format("https://netease-cloud-music-api-invnrotkk-busterblock666.vercel.app/song/url?id={0}&br=320000", song_id);
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

                    myRequest.Headers.Add("cookie", cookies);

                    myRequest.Method = "GET";

                    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();

                    StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

                    string result = reader.ReadToEnd();

                    reader.Close();


                    JObject jobj1 = JObject.Parse(result);
                    string song_url = jobj1["data"][0]["url"].ToString();
                    WebClient wc = new WebClient();
                    wc.DownloadFile(song_url, song_path);
                    MainGUI.mg.status_label.Text = "下载完成";
                    MainGUI.mg.id_label.Text = song_id;
                    MainGUI.mg.Song_Link.Text = "https://music.163.com/#/song?id=" + song_id;
                    MainGUI.mg.author_label.Text = author;
                    MainGUI.Play(seletedItem, song_id, song_url);
                }
                catch(Exception e)
                {
                    MainGUI.mg.status_label.Text = "链接错误……，错误信息:" + e.Message;
                    MainGUI.mg.Song.SetSelected(MainGUI.mg.Song.SelectedIndex + 1, true);
                    MainGUI.Song_get_Or_Play(MainGUI.mg.Song.SelectedItem.ToString(),MainGUI.mg.Song.SelectedIndex);
                }
                
            }
            else
            {
                string cookies = "__remember_me=true; Max-Age=1296000; Expires=Thu, 19 Aug 2021 15:04:05 GMT; Path=/;;__csrf=e752dec57623969e5d31b7b15e7f9ddd; Max-Age=1296010; Expires=Thu, 19 Aug 2021 15:04:15 GMT; Path=/;;MUSIC_U=a0d6e49e037696d0b76ed26b9daebbff4f14efb5a6e88b0653e140749ab74b2ea4d920beea3abb0e05089d36715a4a6228256efc125910a2e381395bf06ec255; Max-Age=1296000; Expires=Thu, 19 Aug 2021 15:04:05 GMT; Path=/;";
                string url = string.Format("https://netease-cloud-music-api-invnrotkk-busterblock666.vercel.app/song/url?id={0}&br=320000", song_id);
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

                myRequest.Headers.Add("cookie", cookies);

                myRequest.Method = "GET";

                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();

                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

                string result = reader.ReadToEnd();

                reader.Close();


                JObject jobj1 = JObject.Parse(result);
                string song_url = jobj1["data"][0]["url"].ToString();
                MainGUI.mg.id_label.Text = song_id;
                MainGUI.mg.Song_Link.Text = "https://music.163.com/#/song?id=" + song_id;
                MainGUI.mg.author_label.Text = author;
                MainGUI.Play(seletedItem, song_id, song_url);
            }

        }

    }
}