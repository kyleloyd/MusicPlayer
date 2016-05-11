using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4.MCI
{
    public static class MCIController
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);
        public static void SetCurrentSong(string path)
        {
            var command = "open \"" + path + "\" type MPEGVideo alias file";
            mciSendString(command, null, 0, 0);
        }

        public static void PlayCurrentSong()
        {
            mciSendString("play file", null, 0, 0);
        }

        public static void PauseCurrentSong()
        {
            mciSendString("stop file", null, 0, 0);
        }

        public static void StopCurrentSong()
        {
            mciSendString("stop file", null, 0, 0);
            mciSendString("close file", null, 0, 0);
        }
    }
}
