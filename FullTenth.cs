using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasuka
{
    class FullTenth : Number
    {
        public NaturalLanguage language { get; set; }
       // public NaturalLanguage language { get; set; }
        public override string lang()
        {
            int m = propValue / 10;
            string result = "";
            string prefix = "";
            HalfTenth halfTenth = new HalfTenth();
            halfTenth.language = this.language;
            if (language.langaugeName=="Swati")
            {
                result = propStemSwati[9];
                prefix = propStemSwati[m - 1];
                if (m == 1) { result = "i" + result; }//"i" shumi
                if ((m >= 2) && (m <= 9)) { result = "ema" + result; }//amashumi "ama"
                if ((m >= 2) && (m <= 4)) { result = result + " lama"; }
                if ((m >= 5) && (m < 9)) { result = result + " lasi"; }//'amashumi'+ "lasi"
                if ((m >= 5) && (m == 9)) { result = result + " la"; }
                if ((m >= 2) && (m <= 9)) { result = result + prefix; }
            }
            if (language.langaugeName == "Igbo")
            {
                 result = "i" + propStemIgbo[9];
                if (((m >= 2) && (m <= 4)) || ((m >= 7) && (m <= 8)))
                { result = result + " " + "a" + propStemIgbo[m - 1]; }
                if (((m >= 5) && (m <= 6)) || (m == 9))
                { result = result + " " + "i" + propStemIgbo[m - 1]; }
            }
            if (language.langaugeName == "Lingala")
            {
                result = propStemLingala[9];
                prefix = propStemLingala[m - 1];

                if (m == 1) { result = "zomi"; }
                if ((m >= 2) && (m <= 9)) { result = "ntuku " + prefix; }
            }
            if (language.langaugeName == "Mashi")
            {
                prefix = "kumi ";
               // int m = propValue / 10;
                if (m == 1) { prefix = "i" + prefix; }
                if ((m >= 2) && (m <= 5)) { prefix = "ma " + prefix + "a"; }
                if ((m >= 6) && (m <= 9)) { prefix = "ma " + prefix + "gali "; }

               result = propStemMashi[m - 1];

                if (m == 1) { result = ""; }
                result = prefix + result;
            }
            if (language.langaugeName == "Zulu")
            {
                result = propStemZulu[9];

                 prefix = propStemZulu[m - 1];

                if (m == 1) { result = "i" + result; }//"i" shumi

                if ((m >= 2) && (m <= 9)) { result = "ama" + result; }//amashumi "ama"
                if ((m >= 2) && (m <= 5)) { result = result + " ama"; }
                if ((m >= 6) && (m <= 9)) { result = result + " ayisi"; }//'amashumi'+ "ayisi"
                if ((m >= 2) && (m <= 9)) { result = result + prefix; }
            }
            if (language.langaugeName == "Basaa")
            {
                result = propStemBasaa[9];
                prefix = propStemBasaa[m - 1];
                //if(m==3) { result = "m" + result; }
                if ((m >= 2) && (m <= 9)) { result = "ni" + result + ""; }
                //if ((m >= 2) && (m <= 9)) { result = " " + result; }
                if ((m >= 2) && (m <= 5)) { result = result + " mom"; }
                if ((m >= 2) && (m <= 9)) { result = result + prefix; }

            }
            if (language.langaugeName == "Iton")
            {
                m = propValue / 10;
                result = propStemIton[m - 1];
                prefix = propStemIton[9];
                if (m == 1) { prefix = "le " + prefix; }
                if ((m == 7) || (m == 8)) { prefix = "wo"; }
                if (m == 9) { prefix = "we"; }
                if ((m >= 2) && (m <= 9)) { prefix = "me " + prefix; }
                if (m == 1) { result = prefix; }
                if ((m > 1) && (m < 10)) { result = prefix + " " + result; }
            }

            return (result);
        }

        public override void setStemSounds()
        {
            propStemSounds[0] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "111" + "\\" + language.langaugeName + "10.wav";
            propStemSounds[1] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "222" + "\\" + language.langaugeName + "20.wav";
            propStemSounds[2] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "333" + "\\" + language.langaugeName + "30.wav";
            propStemSounds[3] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "444" + "\\" + language.langaugeName + "40.wav";
            propStemSounds[4] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "555" + "\\" + language.langaugeName + "50.wav";
            propStemSounds[5] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "666" + "\\" + language.langaugeName + "60.wav";
            propStemSounds[6] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "777" + "\\" + language.langaugeName + "70.wav";
            propStemSounds[7] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "888" + "\\" + language.langaugeName + "80.wav";
            propStemSounds[8] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "999" + "\\" + language.langaugeName + "90.wav";

            propStemSounds[9] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "111" + "\\" + language.langaugeName + "11.wav";
            propStemSounds[10] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "222" + "\\" + language.langaugeName + "22.wav";
            propStemSounds[11] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "333" + "\\" + language.langaugeName + "33.wav";
            propStemSounds[12] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "444" + "\\" + language.langaugeName + "44.wav";
            propStemSounds[13] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "555" + "\\" + language.langaugeName + "55.wav";
            propStemSounds[14] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "666" + "\\" + language.langaugeName + "66.wav";
            propStemSounds[15] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "777" + "\\" + language.langaugeName + "77.wav";
            propStemSounds[16] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "888" + "\\" + language.langaugeName + "88.wav";
            propStemSounds[17] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "999" + "\\"+ language.langaugeName + "99.wav";
        }
        public override async void play(bool alone)
        {
            setStemSounds();
            string soundResult = propStemSounds[(propValue / 10) - 1];
            if (alone == false) { soundResult = propStemSounds[9 + (propValue / 10) - 1]; }
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player = new System.Media.SoundPlayer(soundResult);
            player.PlaySync();
            await Task.Delay(2000);
        }

    }
}
