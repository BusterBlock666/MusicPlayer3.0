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

public static class Md_LyricShowEN
{
    public static void LyricShowEN()
    {
        
        MainGUI.mg.En_lyric.Clear();
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
                
                MainGUI.mg.En_lyric.AppendText("\n\n\n\t\t\t纯音乐，无歌词");
            }
            else
            {
                string en_lrc;
                string[] en_lrc_array;
               
                en_lrc = jobj["lrc"]["lyric"].ToString();
                
                en_lrc_array = Regex.Split(en_lrc, "\\n");
                List<string> en_list = new List<string>(en_lrc_array);
                
                for (int j = 0; j <= en_list.Count; j++)
                {
                    try
                    {
                        int h = 0;
                        
                        int m = 0;
                        
                        int sec = 0;
                        
                        
                        bool isHaveTime_en = true;
                        try
                        {
                            h = int.Parse(en_list[j].Substring(1, 2));                         
                            m = int.Parse(en_list[j].Substring(4, 2));                           
                            sec = int.Parse(en_list[j].Substring(7, 2));                    
                            
                        }
                        catch
                        {
                            isHaveTime_en = false;
                        }
                        
                        
                        while (isHaveTime_en)
                        {
                            if ((int)MainGUI.mg.axWindowsMediaPlayer1.Ctlcontrols.currentPosition >= (int)(h * 60 + m + sec / 100))
                            {
                                MainGUI.mg.En_lyric.AppendText(en_list[j]+"\n");
                                break;
                            }
                            if(MainGUI.mg.axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                            {
                                j = 0;
                                break;
                            }
                            Thread.Sleep(100);
                        }
                       
                        MainGUI.mg.En_lyric.Focus();
                        
                        MainGUI.mg.En_lyric.Select(MainGUI.mg.En_lyric.TextLength, 0);
                        
                        MainGUI.mg.En_lyric.ScrollToCaret();
                        
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
