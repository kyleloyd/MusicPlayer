using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _3.Interface_Layer
{
    public partial class MusicPlayerMainForm : Form
    {
        #region String Constants
        private const string playingPrefix = "Now Playing: ";
        private const string playingDefault = "< none >";
        private bool isPaused;
        private bool playlistIsShowing;
        #endregion

        #region Events
        public event EventHandler OpenSong;
        public event EventHandler PlayPauseSong;
        public event EventHandler StopSong;
        #endregion

        public MusicPlayerMainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            lblPlaying.Text = String.Format("{0}{1}", playingPrefix, playingDefault);
            btnPlay.Image = Properties.Resources.play;
            isPaused = false;
            playlistIsShowing = false;
        }

        public void UpdateCurrentSongLabel(string name)
        {
            lblPlaying.Text = playingPrefix + name;
        }

        #region Open
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (OpenSong != null)
            {
                OpenSong(sender, e);
            }
        }

        public string OpenNewSong()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog1.FileName;
            }

            return null;
        }
        #endregion

        #region Play
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (PlayPauseSong != null)
            {
                PlayPauseSong(sender, e);
            }
        }

        public void SwapPlayPauseButtonImage()
        {
            if (isPaused)
            {
                btnPlay.Image = Properties.Resources.play;
            }

            else
            {
                btnPlay.Image = Properties.Resources.pause;
            }

            isPaused = !isPaused;
        }
        #endregion

        #region Stop
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (StopSong != null)
            {
                StopSong(sender, e);
            }

            btnPlay.Image = Properties.Resources.play;
        }

        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            if (playlistIsShowing)
            {
                this.Left = this.Left + 305;
                tlpMaster.ColumnStyles[0] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F);
                tlpMaster.ColumnStyles[1] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F);
                btnPlaylist.Image = Properties.Resources.playlist_open;
                btnPlaylist.BackColor = Color.FromArgb(64, 64, 64);
                this.Width = 325;
            }

            else
            {
                this.Left = this.Left - 305;
                tlpMaster.ColumnStyles[0] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F);
                tlpMaster.ColumnStyles[1] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F);
                btnPlaylist.Image = Properties.Resources.playlist;
                btnPlaylist.BackColor = Color.Silver;
                this.Width = 630;
            }

            playlistIsShowing = !playlistIsShowing;
        }
    }
}
