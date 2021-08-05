using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayer;
public static class Md_SongChoose
{
    public static void SongChoose()
    {
        try
        {


            MainGUI.mg.axWindowsMediaPlayer1.Ctlcontrols.stop();
            string seleteItem = MainGUI.mg.Song.SelectedItem.ToString();
            int seleteIndex = MainGUI.mg.Song.SelectedIndex;
            MainGUI.Song_get_Or_Play(seleteItem, seleteIndex);
 
        }
        catch(Exception e)
        {
            MessageBox.Show("请选择有效歌曲" + "\n错误信息\n" +
                    e.Message);
        }
    }
}