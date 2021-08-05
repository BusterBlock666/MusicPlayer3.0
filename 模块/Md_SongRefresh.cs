using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public static class Md_Song
    {
        public static void Md_SongRefresh()   //歌曲刷新函数
        {
            try
            {
                
                string list_id = null;
                string songlist_name = null;
                string path1 = "./Necessary_Forlder/list_choice.txt";
                if (!File.Exists(path1))
                {
                    FileStream fs1 = File.Create(path1);
                    fs1.Close();
                }
                using(StreamReader sr = new StreamReader(path1))
                {
                    string songchoice_path = sr.ReadLine();
                    if (File.Exists(songchoice_path))
                    {
                        using (StreamReader sr2 = new StreamReader(songchoice_path))
                        {
                            songlist_name = Path.GetFileNameWithoutExtension(songchoice_path);
                            list_id = Regex.Split(sr2.ReadLine(), @"\|\|")[1];
                            MainGUI.mg.SongList_Link.Text = "https://music.163.com/#/playlist?id=" + list_id.ToString();
                            string song;
                            MainGUI.mg.Song.Items.Clear();
                            while((song=sr2.ReadLine())!= null)
                            {
                                try
                                {
                                    string[] sArray = Regex.Split(song, @"\|\|", RegexOptions.IgnoreCase);
                                    MainGUI.mg.Song.Items.Add(sArray[1]);
                                }
                                catch
                                {

                                }
                            }
                        }
                        List<string> songs = new List<string>(File.ReadAllLines(songchoice_path));
                        if (Regex.Split(songs[0], @"\|\|")[0] == "Create")
                        {
                            songs.RemoveAt(0);
                            songs.Insert(0, "Create||None||" + (MainGUI.mg.Song.Items.Count));
                        }
                        else if (Regex.Split(songs[0], @"\|\|")[0] == "Online")
                        {
                            songs.RemoveAt(0);
                            songs.Insert(0, "Online||" + list_id + "||" + (MainGUI.mg.Song.Items.Count));
                        }
                            File.WriteAllLines(songchoice_path, songs.ToArray());
                        MainGUI.mg.songlist_label.Text = songlist_name;
                    }
                    else
                    {
                        MainGUI.mg.songlist_label.Text = "未找到当前选择歌单";
                    }
                   
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("错误信息:\n" + e.Message);
            }
        }
    }
}
