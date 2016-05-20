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
        #region Private Fields

        private const string playingPrefix = "Now Playing: ";
        private const string playingDefault = "< none >";

        private bool isPaused;
        private bool playlistIsShowing;

        public int selectedPlaylistIndex;

        #endregion

        #region Events

        public event EventHandler OpenSong;
        public event EventHandler PlayPauseSong;
        public event EventHandler StopSong;
        public event EventHandler PlaylistToggle;
        public event EventHandler PlaylistDoubleClick;

        #endregion

        #region Constructor

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

        #endregion

        #region Event Methods

        #region -- Open Methods

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

        public void UpdateCurrentSongLabel(string name)
        {
            lblPlaying.Text = playingPrefix + name;
        }

        #endregion

        #region -- Play Methods

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

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (StopSong != null)
            {
                StopSong(sender, e);
            }

            btnPlay.Image = Properties.Resources.play;
        }

        #endregion

        #region Playlist Actions

        private void btnDisplayPlaylist_Click(object sender, EventArgs e)
        {
            if (playlistIsShowing)
            {
                this.Left = this.Left + 305;
                tlpMaster.ColumnStyles[0] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F);
                tlpMaster.ColumnStyles[1] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F);
                btnDisplayPlaylist.Image = Properties.Resources.playlist;
                btnDisplayPlaylist.BackColor = Color.Silver;
                this.Width = 325;
            }

            else
            {
                this.Left = this.Left - 305;
                tlpMaster.ColumnStyles[0] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F);
                tlpMaster.ColumnStyles[1] = new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F);
                btnDisplayPlaylist.Image = Properties.Resources.playlist_open;
                btnDisplayPlaylist.BackColor = Color.FromArgb(64, 64, 64);
                this.Width = 630;
            }

            playlistIsShowing = !playlistIsShowing;

            if (PlaylistToggle != null)
            {
                PlaylistToggle(sender, e);
            }
        }

        public void UpdatePlaylistListBox(List<string> songs)
        {
            foreach (var item in songs.Where(x => !lbCurrentPlaylist.Items.Contains(x)))
            {
                lbCurrentPlaylist.Items.Add(item);
            }
        }

        private void lbCurrentPlaylist_DoubleClick(object sender, MouseEventArgs e)
        {
            selectedPlaylistIndex = this.lbCurrentPlaylist.IndexFromPoint(e.Location);
            if (selectedPlaylistIndex != System.Windows.Forms.ListBox.NoMatches && PlaylistDoubleClick != null)
            {
                PlaylistDoubleClick(sender, e);
            }
        }

        #endregion


    }
}
