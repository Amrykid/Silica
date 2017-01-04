using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;

namespace Silica.Core
{
    public class AudioManager
    {
        public static AudioManager Instance { get; private set; }
        internal static void CreateInstance()
        {
            Instance = new AudioManager();
        }

        internal MediaPlayer MusicPlayer { get; private set; }
        internal MediaPlayer SoundPlayer { get; private set; }
        internal MediaPlayer SpeechPlayer { get; private set; }

        private AudioManager()
        {
            MusicPlayer = new MediaPlayer();
            MusicPlayer.CommandManager.IsEnabled = false;
            MusicPlayer.AudioCategory = MediaPlayerAudioCategory.GameMedia;

            SoundPlayer = new MediaPlayer();
            SoundPlayer.CommandManager.IsEnabled = false;
            SoundPlayer.AudioCategory = MediaPlayerAudioCategory.GameEffects;

            SpeechPlayer = new MediaPlayer();
            SpeechPlayer.CommandManager.IsEnabled = false;
            SpeechPlayer.AudioCategory = MediaPlayerAudioCategory.GameChat; //not sure about this one.
        }
    }
}
