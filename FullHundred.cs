using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasuka
{
    class FullHundred : Number
    {
        public NaturalLanguage language { get; set; }
        public override string lang()
        {
            int m = propValue / 100;
            string result =" ";
            string prefix = "";
            if (language.langaugeName=="Swati")
            {
                result = propStemSwati[10];
                if (m == 1) { result = "i" + result; }
                if ((m >= 2) && (m <= 4)) { result = "ema" + result + " ama" + propStemSwati[m - 1]; }
                if ((m >= 5) && (m <= 8)) { result = "ema" + result + " lasi" + propStemSwati[m - 1]; }
                if (m == 9) { result = "ema" + result + " la" + propStemSwati[m - 1]; }
            }
            if (language.langaugeName == "Igbo")
            {
                result = propStemIgbo[10];
                if (((m >= 2) && (m <= 4)) || ((m >= 7) && (m <= 8)))
                { result = result + " " + "a" + propStemIgbo[m - 1]; }
                if (((m >= 5) && (m <= 6)) || (m == 9))
                { result = result + " " + "i" + propStemIgbo[m - 1]; }
            }
            if (language.langaugeName == "Lingala")
            {
                result = propStemLingala[10];
                if (m == 1) { result = "nkama moko"; }

                if ((m >= 2) && (m <= 9)) { result = "nkama " + propStemLingala[m - 1]; }

            }
            if (language.langaugeName == "Mashi")
            {
                result = propStemMashi[m - 1];

                prefix = "gana";

                if (m == 1) { prefix = "i" + prefix; }
                if ((m >= 2) && (m <= 9)) { prefix = "ma" + prefix; }
                if ((m >= 2) && (m <= 5)) { prefix = prefix + " a"; }
                if (m == 1) { result = prefix; }
                if ((m >= 2) && (m <= 9)) { result = prefix + " " + result; }
            }
            if (language.langaugeName == "Zulu")
            {
                result = propStemZulu[10];
                if (m == 1) { result = "i" + result; }
                if ((m >= 2) && (m <= 5)) { result = "ama" + result + " ama" + propStemZulu[m - 1]; }
                if ((m >= 6) && (m <= 9)) { result = " ama" + result + " ayisi" + propStemZulu[m - 1]; }
            }

            if (language.langaugeName == "Iton")
            {
                m = propValue / 100;
                result = propStemIton[10];
                if ((m > 1) && (m < 7)) { result = "mi " + result + " mi " + propStemIton[m - 1]; }
                if ((m >= 7) && (m < 10)) { result = "mi " + result + " " + propStemIton[m - 1]; }
            }
            //FullTenth ft = new FullTenth();
            if (language.langaugeName == "Basaa")
            {
                result = propStemBasaa[10];
                if (m == 3) { result = "m" + result; }

                if ((m >= 2) && (m <= 9))
                {
                    result = result + " " + propStemBasaa[m - 1];
                }

            }
            return (result);
        }

        public override void setStemSounds()
        {
            propStemSounds[0] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "111" +"\\"+ language.langaugeName +"100.wav";
            propStemSounds[1] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "222" + "\\" + language.langaugeName + "200.wav";
            propStemSounds[2] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "333" + "\\" + language.langaugeName + "300.wav";
            propStemSounds[3] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "444" + "\\" + language.langaugeName + "400.wav";
            propStemSounds[4] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "555" + "\\" + language.langaugeName + "500.wav";
            propStemSounds[5] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "666" + "\\" + language.langaugeName + "600.wav";
            propStemSounds[6] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "777" + "\\" + language.langaugeName + "700.wav";
            propStemSounds[7] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "888" + "\\" + language.langaugeName + "800.wav";
            propStemSounds[8] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "999" + "\\" + language.langaugeName + "900.wav";

        }
        public override async void play(bool alone)
        {
            setStemSounds();
            string soundResult = propStemSounds[(propValue / 100) - 1];
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player = new System.Media.SoundPlayer(soundResult);
            player.PlaySync();
            await Task.Delay(2000);
        }
        
    }
}
