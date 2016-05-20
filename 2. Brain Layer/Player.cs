using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _2.Brain_Layer.ViewModels;
using _3.Interface_Layer;
using _4.MCI;

namespace _2.Brain_Layer
{
    public class Player
    {
        #region Private Variables

        private MusicPlayerMainForm mainForm;
        private PlaylistVM currentPlaylist;
        private SongVM currentSong;
        private bool isPlaying;
        private bool playlistIsActive;

        #endregion

        #region Constructor

        public Player ()
        {
            mainForm = new MusicPlayerMainForm();
            currentPlaylist = new PlaylistVM();

            isPlaying = false;
            playlistIsActive = false;

            InitializeEvents();

            mainForm.ShowDialog();
        }

        private void InitializeEvents()
        {
            mainForm.OpenSong += mainForm_OpenSong;
            mainForm.PlayPauseSong += mainForm_PlayPauseSong;
            mainForm.StopSong += mainForm_StopSong;
            mainForm.PlaylistToggle += mainForm_PlaylistToggle;
            mainForm.PlaylistDoubleClick += mainForm_PlaylistDoubleClick;
        }

        #endregion

        #region Event Methods

        private void mainForm_OpenSong(object sender, EventArgs e)
        {
            var result = mainForm.OpenNewSong();

            if (result != null)
            {
                if (playlistIsActive)
                {
                    currentPlaylist.AddSong(new SongVM(result));
                    currentSong = currentPlaylist.CurrentSong;

                    var songNames = new List<string>();
                    foreach (var song in currentPlaylist.Songs)
                    {
                        songNames.Add(song.Name);
                    }

                    mainForm.UpdatePlaylistListBox(songNames);
                }

                else
                {
                    currentSong = new SongVM(result);
                }

                mainForm.UpdateCurrentSongLabel(currentSong.Name);
            }
        }

        private void mainForm_PlayPauseSong(object sender, EventArgs e)
        {
            if (currentSong != null)
            {
                try
                {
                    PlayPauseSong();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void mainForm_StopSong(object sender, EventArgs e)
        {
            isPlaying = false;
            MCIController.StopCurrentSong();
        }

        private void mainForm_PlaylistToggle(object sender, EventArgs e)
        {
            playlistIsActive = !playlistIsActive;
        }

        private void mainForm_PlaylistDoubleClick(object sender, EventArgs e)
        {
            currentSong = currentPlaylist.CurrentSong = currentPlaylist.Songs[mainForm.selectedPlaylistIndex];
            mainForm.UpdateCurrentSongLabel(currentSong.Name);
            PlayPauseSong();
        }

        #endregion

        private void PlayPauseSong()
        {
            if (!isPlaying)
            {
                MCIController.SetCurrentSong(currentSong.Path);
                MCIController.PlayCurrentSong();
            }

            else
            {
                MCIController.PauseCurrentSong();
            }

            isPlaying = !isPlaying;
            mainForm.SwapPlayPauseButtonImage();
        }
    }
}
