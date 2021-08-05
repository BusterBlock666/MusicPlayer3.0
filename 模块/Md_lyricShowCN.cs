using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using MusicPlayer;
using Newtonsoft.Json.Linq;

public static class Md_LyricShowCN
{
    public static void LyricShowCN()
    {
        MainGUI.mg.CN_lyric.Clear();
      
        string song_path = "./Necessary_Forlder/song/" + MainGUI.mg.Song.SelectedItem.ToString()+".mp3";
        if (File.Exists(song_path))
        {
            string song_id = null;
            string path2 = "./Necessary_Forlder/list_choice.txt";
            string sLine;
            string sLine2 = null;
            int songvalue = MainGUI.mg.Song.SelectedIndex;
            int i = 0;
            using(StreamReader sr1 = new StreamReader(path2))
            {
                using (StreamReader sr2 = new StreamReader(sr1.ReadLine()))
                {
                    while((sLine = sr2.ReadLine()) != null)
                    {
                        if (i == songvalue)
                        {
                            sLine2 = sr2.ReadLine();
                            break;
                        }
                        i++;
                    }
                }
            }
            string[] sArray = Regex.Split(sLine2, @"\|\|");
            song_id = sArray[0];
            string url = string.Format("https://netease-cloud-music-api-beige-six.vercel.app/lyric?id={0}",song_id);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            string result;
            using(StreamReader sr1 = new StreamReader(stream))
            {
                result = sr1.ReadToEnd();
            }
            JObject jobj = JObject.Parse(result);
            bool isHaveLyric = true;
            try
            {
                if (jobj["nolyric"].ToString() == "true")
                {
                    isHaveLyric = false;
                }
            }
            catch
            {
            }
            if (!isHaveLyric)
            {
                MainGUI.mg.CN_lyric.AppendText("\n\n\n\t\t\t纯音乐，无歌词");
              
            }
            else
            {
               
                string cn_lrc;
                string[] cn_lrc_array;
                
                cn_lrc = jobj["tlyric"]["lyric"].ToString();
                
                cn_lrc_array = Regex.Split(cn_lrc, "\\n");
                List<string> cn_list = new List<string>(cn_lrc_array);
                for (int j = 0; j <=  cn_list.Count; j++)
                {
                    try
                    {
                        
                        int h1 = 0;
                        
                        int m1 = 0;
                        
                        int sec1 = 0;
                        bool isHaveTime_cn = true;
                       
                       
                        try
                        {
                            h1 = int.Parse(cn_list[j].Substring(1, 2));
                            m1 = int.Parse(cn_list[j].Substring(4, 2));
                            sec1 = int.Parse(cn_list[j].Substring(7, 2));
                        }
                        catch
                        {
                            isHaveTime_cn = false;
                        }
                        
                       
                        while (isHaveTime_cn)
                        {
                            if ((int)MainGUI.mg.axWindowsMediaPlayer1.Ctlcontrols.currentPosition >= (int)(h1 * 60 + m1 + sec1 / 100))
                            {
                                MainGUI.mg.CN_lyric.AppendText(cn_list[j]+"\n");
                                break;
                            }
                            if (MainGUI.mg.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                            {
                                j = 0;
                                break;
                            }
                            Thread.Sleep(100);
                        }
                       
                        MainGUI.mg.CN_lyric.Focus();
                       
                        MainGUI.mg.CN_lyric.Select(MainGUI.mg.CN_lyric.TextLength, 0);
                        
                        MainGUI.mg.CN_lyric.ScrollToCaret();
                    }
                    catch
                    {

                    }
                    if ((int) MainGUI.mg.axWindowsMediaPlayer1.Ctlcontrols.currentPosition >= (int)MainGUI.mg.axWindowsMediaPlayer1.currentMedia.duration - 5 || MainGUI.mg.axWindowsMediaPlayer1.playState==WMPLib.WMPPlayState.wmppsStopped)
                    {
                        break;
                    }
                     
                }
            }
        }
    }
}
