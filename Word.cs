using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasuka
{
    abstract class Word
    {


        //public NaturalLanguage language { get; set; }

        private static string soundFolder = Application.StartupPath + "\\sound\\";

        private static string[] stemSounds = new String[15];

        private string[] stemEnglish = new String[15];

        private string[] stemFrench = new String[15];

        private int val;

        public int propValue
        {
            set { val = value; }
            get { return val; }
        }

        public string propSoundFolder
        {
            get { return soundFolder; }
        }

        public void setSoundFolder(string folderPathPar)
        {
            soundFolder = folderPathPar;
        }

        public string[] propStemSounds
        {
            get { return stemSounds; }
        }

        public string[] propStemEnglish
        {
            get { return stemEnglish; }
        }

        public string[] propStemFrench
        {
            get { return stemFrench; }
        }

        public bool checkIton(string s)
        {
            setStemEnglish();
            setStemFrench();
            return ((s.ToUpper()==propStemEnglish[propValue]) || (s.ToUpper() == propStemFrench[propValue]));
        }

        public async void  play()
        {
            setStemSounds();
            string soundResult = propStemSounds[propValue];
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player = new System.Media.SoundPlayer(soundResult);
            player.PlaySync();
            await Task.Delay(2000);
        }

        abstract public void setStemSounds();
        abstract public void setStemEnglish();
        abstract public void setStemFrench();

    }
}
