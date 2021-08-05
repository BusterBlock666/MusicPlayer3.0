
namespace MusicPlayer
{
    partial class MainGUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Song = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SongList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加网易云歌单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.songlist_label = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label4 = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SongList_Link = new System.Windows.Forms.LinkLabel();
            this.Song_Link = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PlayPause_Button = new System.Windows.Forms.Button();
            this.next_song = new System.Windows.Forms.Button();
            this.last_song = new System.Windows.Forms.Button();
            this.SingleRoll_btn = new System.Windows.Forms.RadioButton();
            this.OrderRoll_btn = new System.Windows.Forms.RadioButton();
            this.RandomRoll_btn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.Volume_Bar = new System.Windows.Forms.TrackBar();
            this.Volume_label = new System.Windows.Forms.Label();
            this.songprogress_bar = new System.Windows.Forms.TrackBar();
            this.songprogress_label = new System.Windows.Forms.Label();
            this.songprogress_timer = new System.Windows.Forms.Timer(this.components);
            this.AvailableCheck_timer = new System.Windows.Forms.Timer(this.components);
            this.En_lyric = new System.Windows.Forms.RichTextBox();
            this.CN_lyric = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songprogress_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // Song
            // 
            this.Song.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Song.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Song.FormattingEnabled = true;
            this.Song.ItemHeight = 16;
            this.Song.Location = new System.Drawing.Point(12, 64);
            this.Song.Name = "Song";
            this.Song.ScrollAlwaysVisible = true;
            this.Song.Size = new System.Drawing.Size(200, 514);
            this.Song.TabIndex = 0;
            this.Song.Click += new System.EventHandler(this.Song_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "歌曲列表👇";
            // 
            // SongList
            // 
            this.SongList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SongList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SongList.FormattingEnabled = true;
            this.SongList.ItemHeight = 16;
            this.SongList.Location = new System.Drawing.Point(237, 368);
            this.SongList.Name = "SongList";
            this.SongList.ScrollAlwaysVisible = true;
            this.SongList.Size = new System.Drawing.Size(147, 210);
            this.SongList.TabIndex = 2;
            this.SongList.Click += new System.EventHandler(this.SongList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(233, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "歌单列表👇";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加网易云歌单ToolStripMenuItem});
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.添加ToolStripMenuItem.Text = "添加";
            // 
            // 添加网易云歌单ToolStripMenuItem
            // 
            this.添加网易云歌单ToolStripMenuItem.Name = "添加网易云歌单ToolStripMenuItem";
            this.添加网易云歌单ToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.添加网易云歌单ToolStripMenuItem.Text = "添加网易云歌单";
            this.添加网易云歌单ToolStripMenuItem.Click += new System.EventHandler(this.添加网易云歌单ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "歌单:";
            // 
            // songlist_label
            // 
            this.songlist_label.AutoSize = true;
            this.songlist_label.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songlist_label.ForeColor = System.Drawing.Color.Brown;
            this.songlist_label.Location = new System.Drawing.Point(437, 35);
            this.songlist_label.Name = "songlist_label";
            this.songlist_label.Size = new System.Drawing.Size(0, 19);
            this.songlist_label.TabIndex = 6;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(396, 64);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(376, 39);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(392, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "状态:";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.status_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.status_label.Location = new System.Drawing.Point(437, 341);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(0, 19);
            this.status_label.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(392, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "歌单链接:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(392, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "歌曲链接:";
            // 
            // SongList_Link
            // 
            this.SongList_Link.AutoSize = true;
            this.SongList_Link.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SongList_Link.Location = new System.Drawing.Point(463, 469);
            this.SongList_Link.Name = "SongList_Link";
            this.SongList_Link.Size = new System.Drawing.Size(0, 17);
            this.SongList_Link.TabIndex = 12;
            this.SongList_Link.Click += new System.EventHandler(this.SongList_Link_Click);
            // 
            // Song_Link
            // 
            this.Song_Link.AutoSize = true;
            this.Song_Link.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Song_Link.Location = new System.Drawing.Point(463, 503);
            this.Song_Link.Name = "Song_Link";
            this.Song_Link.Size = new System.Drawing.Size(0, 17);
            this.Song_Link.TabIndex = 13;
            this.Song_Link.Click += new System.EventHandler(this.Song_Link_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(392, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "歌曲id:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id_label.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.id_label.ForeColor = System.Drawing.Color.Green;
            this.id_label.Location = new System.Drawing.Point(462, 436);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(0, 19);
            this.id_label.TabIndex = 16;
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.author_label.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.author_label.ForeColor = System.Drawing.Color.Green;
            this.author_label.Location = new System.Drawing.Point(462, 404);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(0, 19);
            this.author_label.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(392, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "歌曲作者";
            // 
            // PlayPause_Button
            // 
            this.PlayPause_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayPause_Button.Location = new System.Drawing.Point(274, 64);
            this.PlayPause_Button.Name = "PlayPause_Button";
            this.PlayPause_Button.Size = new System.Drawing.Size(59, 39);
            this.PlayPause_Button.TabIndex = 19;
            this.PlayPause_Button.Text = "播放";
            this.PlayPause_Button.UseVisualStyleBackColor = true;
            this.PlayPause_Button.Click += new System.EventHandler(this.PlayPause_Button_Click);
            // 
            // next_song
            // 
            this.next_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_song.Location = new System.Drawing.Point(334, 71);
            this.next_song.Name = "next_song";
            this.next_song.Size = new System.Drawing.Size(61, 24);
            this.next_song.TabIndex = 20;
            this.next_song.Text = "下一首";
            this.next_song.UseVisualStyleBackColor = true;
            this.next_song.Click += new System.EventHandler(this.next_song_Click);
            // 
            // last_song
            // 
            this.last_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_song.Location = new System.Drawing.Point(213, 71);
            this.last_song.Name = "last_song";
            this.last_song.Size = new System.Drawing.Size(61, 24);
            this.last_song.TabIndex = 21;
            this.last_song.Text = "上一首";
            this.last_song.UseVisualStyleBackColor = true;
            this.last_song.Click += new System.EventHandler(this.last_song_Click);
            // 
            // SingleRoll_btn
            // 
            this.SingleRoll_btn.AutoSize = true;
            this.SingleRoll_btn.Checked = true;
            this.SingleRoll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleRoll_btn.Location = new System.Drawing.Point(259, 225);
            this.SingleRoll_btn.Name = "SingleRoll_btn";
            this.SingleRoll_btn.Size = new System.Drawing.Size(77, 19);
            this.SingleRoll_btn.TabIndex = 22;
            this.SingleRoll_btn.TabStop = true;
            this.SingleRoll_btn.Text = "单曲循环";
            this.SingleRoll_btn.UseVisualStyleBackColor = true;
            // 
            // OrderRoll_btn
            // 
            this.OrderRoll_btn.AutoSize = true;
            this.OrderRoll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderRoll_btn.Location = new System.Drawing.Point(259, 262);
            this.OrderRoll_btn.Name = "OrderRoll_btn";
            this.OrderRoll_btn.Size = new System.Drawing.Size(77, 19);
            this.OrderRoll_btn.TabIndex = 23;
            this.OrderRoll_btn.Text = "顺序播放";
            this.OrderRoll_btn.UseVisualStyleBackColor = true;
            // 
            // RandomRoll_btn
            // 
            this.RandomRoll_btn.AutoSize = true;
            this.RandomRoll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomRoll_btn.Location = new System.Drawing.Point(259, 297);
            this.RandomRoll_btn.Name = "RandomRoll_btn";
            this.RandomRoll_btn.Size = new System.Drawing.Size(77, 19);
            this.RandomRoll_btn.TabIndex = 24;
            this.RandomRoll_btn.Text = "随机播放";
            this.RandomRoll_btn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(218, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "音量";
            // 
            // Volume_Bar
            // 
            this.Volume_Bar.Location = new System.Drawing.Point(259, 109);
            this.Volume_Bar.Maximum = 100;
            this.Volume_Bar.Name = "Volume_Bar";
            this.Volume_Bar.Size = new System.Drawing.Size(136, 45);
            this.Volume_Bar.TabIndex = 26;
            this.Volume_Bar.Value = 50;
            this.Volume_Bar.Scroll += new System.EventHandler(this.Volume_Bar_Scroll);
            // 
            // Volume_label
            // 
            this.Volume_label.AutoSize = true;
            this.Volume_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volume_label.Location = new System.Drawing.Point(315, 139);
            this.Volume_label.Name = "Volume_label";
            this.Volume_label.Size = new System.Drawing.Size(23, 15);
            this.Volume_label.TabIndex = 27;
            this.Volume_label.Text = "50";
            // 
            // songprogress_bar
            // 
            this.songprogress_bar.Location = new System.Drawing.Point(221, 160);
            this.songprogress_bar.Maximum = 100;
            this.songprogress_bar.Name = "songprogress_bar";
            this.songprogress_bar.Size = new System.Drawing.Size(174, 45);
            this.songprogress_bar.TabIndex = 28;
            this.songprogress_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.songprogress_bar_MouseDown);
            this.songprogress_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.songprogress_bar_MouseUp);
            // 
            // songprogress_label
            // 
            this.songprogress_label.AutoSize = true;
            this.songprogress_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.songprogress_label.Location = new System.Drawing.Point(271, 190);
            this.songprogress_label.Name = "songprogress_label";
            this.songprogress_label.Size = new System.Drawing.Size(83, 15);
            this.songprogress_label.TabIndex = 29;
            this.songprogress_label.Text = "00:00/00:00";
            // 
            // songprogress_timer
            // 
            this.songprogress_timer.Enabled = true;
            this.songprogress_timer.Interval = 10;
            this.songprogress_timer.Tick += new System.EventHandler(this.songprogress_timer_Tick);
            // 
            // AvailableCheck_timer
            // 
            this.AvailableCheck_timer.Enabled = true;
            this.AvailableCheck_timer.Interval = 2000;
            this.AvailableCheck_timer.Tick += new System.EventHandler(this.AvailableCheck_timer_Tick);
            // 
            // En_lyric
            // 
            this.En_lyric.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.En_lyric.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.En_lyric.Location = new System.Drawing.Point(401, 110);
            this.En_lyric.Name = "En_lyric";
            this.En_lyric.ReadOnly = true;
            this.En_lyric.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.En_lyric.Size = new System.Drawing.Size(180, 206);
            this.En_lyric.TabIndex = 30;
            this.En_lyric.Text = "";
            // 
            // CN_lyric
            // 
            this.CN_lyric.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CN_lyric.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold);
            this.CN_lyric.Location = new System.Drawing.Point(592, 110);
            this.CN_lyric.Name = "CN_lyric";
            this.CN_lyric.ReadOnly = true;
            this.CN_lyric.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CN_lyric.Size = new System.Drawing.Size(180, 206);
            this.CN_lyric.TabIndex = 31;
            this.CN_lyric.Text = "";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 604);
            this.Controls.Add(this.CN_lyric);
            this.Controls.Add(this.En_lyric);
            this.Controls.Add(this.songprogress_label);
            this.Controls.Add(this.songprogress_bar);
            this.Controls.Add(this.Volume_label);
            this.Controls.Add(this.Volume_Bar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RandomRoll_btn);
            this.Controls.Add(this.OrderRoll_btn);
            this.Controls.Add(this.SingleRoll_btn);
            this.Controls.Add(this.last_song);
            this.Controls.Add(this.next_song);
            this.Controls.Add(this.PlayPause_Button);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Song_Link);
            this.Controls.Add(this.SongList_Link);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.songlist_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SongList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Song);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainGUI";
            this.Text = "网易云播放器";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songprogress_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox Song;
        public System.Windows.Forms.ListBox SongList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label songlist_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.LinkLabel SongList_Link;
        public System.Windows.Forms.LinkLabel Song_Link;
        public System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label id_label;
        public System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button PlayPause_Button;
        private System.Windows.Forms.ToolStripMenuItem 添加网易云歌单ToolStripMenuItem;
        public System.Windows.Forms.Button next_song;
        public System.Windows.Forms.Button last_song;
        public System.Windows.Forms.RadioButton SingleRoll_btn;
        public System.Windows.Forms.RadioButton OrderRoll_btn;
        public System.Windows.Forms.RadioButton RandomRoll_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar Volume_Bar;
        private System.Windows.Forms.Label Volume_label;
        private System.Windows.Forms.TrackBar songprogress_bar;
        private System.Windows.Forms.Label songprogress_label;
        private System.Windows.Forms.Timer songprogress_timer;
        private System.Windows.Forms.Timer AvailableCheck_timer;
        public System.Windows.Forms.RichTextBox En_lyric;
        public System.Windows.Forms.RichTextBox CN_lyric;
    }
}

