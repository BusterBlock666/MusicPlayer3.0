using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayer;
using MusicPlayer.模块;

namespace MusicPlayer
{
    public partial class MainGUI : Form
    {
        public static MainGUI mg;
       
        public MainGUI()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            mg = this;
        }
        
        private void MainGUI_Load(object sender, EventArgs e)
        {
            //窗体启动初始化
            songlist_label.Text = "等待选择中……";
            status_label.Text = "等待中……";
            Refresh();
        }
        public static void Refresh()       //歌单列表刷新
        {
           
            Thread t1 = new Thread(Md_SongList.Md_SongListRefresh);
            t1.IsBackground = true;
            t1.Start();
            Thread t2 = new Thread(Md_Song.Md_SongRefresh);
            t2.IsBackground = true;
            t2.Start();
        }
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)      //刷新按钮控制
        {
            刷新ToolStripMenuItem.Enabled = false;
            Refresh();  //歌单列表刷新
            刷新ToolStripMenuItem.Enabled = true;
        }

    
        private void SongList_Click(object sender, EventArgs e)
        {
            //歌单选择器
            Thread t1 = new Thread(Md_SongListChoice.SongListChoice);
            t1.IsBackground = true;
            t1.Start();
        }

        private void Song_Click(object sender, EventArgs e)
        {
            //歌曲选择器
            Md_SongChoose.SongChoose();
        }
        public static void Song_get_Or_Play(string seletedItem,int seletedIndex)    //音乐获取或播放
        {
            Thread t1 = new Thread(() => Md_SongGETPlay.SongGETPlay(seletedItem, seletedIndex));
            t1.IsBackground = true;
            t1.Start();
            
        }
        public static void Play(string song_name,string song_id,string url2)
        {
            Thread t1 = new Thread(() => Md_Play.Play(song_name, song_id, url2));
            t1.IsBackground = true;
            t1.Start();
        }

        private void PlayPause_Button_Click(object sender, EventArgs e)
        {
            if (PlayPause_Button.Text == "暂停")
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                PlayPause_Button.Text = "播放";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                PlayPause_Button.Text = "暂停";
            }
        }
        private void songchange_mode()
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            if (SingleRoll_btn.Checked)
            {
                Song_get_Or_Play(Song.SelectedItem.ToString(), Song.SelectedIndex);
            }
            if (OrderRoll_btn.Checked)
            {
                try
                {

                    Song.SetSelected(Song.SelectedIndex + 1, true);
                    Song_get_Or_Play(Song.SelectedItem.ToString(), Song.SelectedIndex);
                }
                catch
                {
                    Song.SetSelected(0, true);
                    Song_get_Or_Play(Song.SelectedItem.ToString(), Song.SelectedIndex);
                }
            }
            if (RandomRoll_btn.Checked)
            {
                Random rd = new Random();
                Song.SetSelected(rd.Next(0, Song.Items.Count), true);
                Song_get_Or_Play(Song.SelectedItem.ToString(), Song.SelectedIndex);
            }
        }
        private void 添加网易云歌单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Md_AddOnlineList a1 = new Md_AddOnlineList();
            a1.Show();
        }

        private void next_song_Click(object sender, EventArgs e)
        {
            if (Song.SelectedIndex != Song.Items.Count-1)
            {
                if (SingleRoll_btn.Checked)
                {
                    Song.SetSelected(Song.SelectedIndex + 1, true);
                    Song_get_Or_Play(Song.SelectedItem.ToString(),Song.SelectedIndex);
                }
                else
                {
                    songchange_mode();
                }
            }
        }

        private void last_song_Click(object sender, EventArgs e)
        {
            if (Song.SelectedIndex != 0)
            {
                Song.SetSelected(Song.SelectedIndex - 1, true);
                Song_get_Or_Play(Song.SelectedItem.ToString(), Song.SelectedIndex);
            }
        }

        private void songprogress_timer_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                double current_time = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                string current_time_tx = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                double duration_time = axWindowsMediaPlayer1.currentMedia.duration;
                string duration_time_tx = axWindowsMediaPlayer1.currentMedia.durationString;
                float progress_show_per = (float)current_time / (float)duration_time;
                songprogress_bar.Value = (int)(progress_show_per * 100) + 1;
                songprogress_label.Text = current_time_tx + "/" + duration_time_tx;
                if ((int)current_time == (int)duration_time)
                {
                    songchange_mode();
                }
            }
        }

        private void songprogress_bar_MouseDown(object sender, MouseEventArgs e)
        {
            songprogress_timer.Enabled = false;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            
        }

        private void songprogress_bar_MouseUp(object sender, MouseEventArgs e)
        {
            double dovalue = ((float)songprogress_bar.Value / 100) * axWindowsMediaPlayer1.currentMedia.duration;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = dovalue;
            En_lyric.Clear();
            CN_lyric.Clear();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            songprogress_timer.Enabled = true;
        }

        private void AvailableCheck_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr1 = new StreamReader("./Necessary_Forlder/list_choice.txt"))
                {
                    string path = sr1.ReadLine();
                    using(StreamReader sr2 = new StreamReader(path))
                    {
                        
                    }
                }
            }
            catch(Exception e1)
            {
                status_label.Text = "读取失败" + "\n错误信息\n" + e1.Message;
            }
        }

        private void SongList_Link_Click(object sender, EventArgs e)
        {
            Process.Start(SongList_Link.Text);
        }

        private void Song_Link_Click(object sender, EventArgs e)
        {
            Process.Start(Song_Link.Text);
        }


        private void Volume_Bar_Scroll(object sender, EventArgs e)
        {
            Volume_label.Text = (Volume_Bar.Value.ToString());
            axWindowsMediaPlayer1.settings.volume = Volume_Bar.Value;
        }
        public static void lyric_show()
        {
            Thread t1 = new Thread(Md_LyricShowCN.LyricShowCN);
            t1.IsBackground = true;
            t1.Start();
            Thread t2 = new Thread(Md_LyricShowEN.LyricShowEN);
            t2.IsBackground = true;
            t2.Start();

        }
    }
   
}
