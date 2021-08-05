using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicPlayer;

public static class Md_Play
{
    public static void Play(string song_name,string song_id,string url2)
    {
        string song_path = "./Necessary_Forlder/song/" + song_name + ".mp3";
        MainGUI.mg.axWindowsMediaPlayer1.Ctlcontrols.stop();
        MainGUI.mg.axWindowsMediaPlayer1.URL = song_path;     
        MainGUI.mg.axWindowsMediaPlayer1.Ctlcontrols.play();
        MainGUI.mg.PlayPause_Button.Text = "暂停";
        MainGUI.mg.status_label.Text = "正在播放     " + song_name;
        MainGUI.lyric_show();
    }
}