using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public static class Md_SongList
    {
        public static void Md_SongListRefresh()
        {
            //歌单刷新部分
            try
            {
                string songlist_path1 = @"./Necessary_Forlder/songlist";
                var files1 = Directory.GetFiles(songlist_path1, "*.txt");
                MainGUI.mg.SongList.Items.Clear();
                foreach (var file1 in files1)
                {
                    MainGUI.mg.SongList.Items.Add(Path.GetFileNameWithoutExtension(file1));
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("当前歌单可能已被清除\n无法刷新"+"\n错误信息:\n"+e.Message);
            }
        
            //End
        }
    }
}
