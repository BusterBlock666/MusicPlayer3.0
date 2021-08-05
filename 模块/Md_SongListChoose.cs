using MusicPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Md_SongListChoice
{
    public static void SongListChoice()  //歌单选择器
    {
        string path1 = "./Necessary_Forlder/list_choice.txt";
        using (StreamWriter sr = new StreamWriter(path1, false))
        {
            sr.Write("./Necessary_Forlder/songlist/"+MainGUI.mg.SongList.SelectedItem.ToString()+".txt");
        }
        MainGUI.Refresh();
    }
}
