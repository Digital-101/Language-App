using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasuka
{
    class Unit : Number
    {
        public NaturalLanguage language { get; set; }
        public override string lang()
        {
            FullTenth fullTen = new FullTenth();
            fullTen.language = this.language;
            string result ="";
            if (language.langaugeName=="Swati")
            {
                result = propStemSwati[propValue - 1];
                if ((propValue >= 1) && (propValue <= 4))
                { result = "ku" + result; }
                if ((propValue >= 5) && (propValue <= 8))
                { result = "si" + result; }
            }
            if (language.langaugeName == "Zulu")
            {
                result = propStemZulu[propValue - 1];

                if ((propValue >= 1) && (propValue <= 5))
                { result = "ku" + result; }
                if ((propValue >= 5) && (propValue <= 9))
                { result = "isi" + result; }
            }
            if (language.langaugeName == "Igbo")
            {
                 result = propStemIgbo[propValue - 1];
                if (((propValue >= 2) && (propValue <= 4)) || ((propValue >= 7) && (propValue <= 8)))
                { result = "a" + result; }
                if (((propValue >= 5) && (propValue <= 6)) || (propValue >= 9))
                { result = "i" + result; }
            }
            if (language.langaugeName == "Lingala")
            {
               result = propStemLingala[propValue - 1];
            }
            if (language.langaugeName == "Mashi")
            {
                result = propStemMashi[propValue - 1];
            }

            if (language.langaugeName == "Basaa")
            {
                result = propStemBasaa[propValue - 1];

                if (propValue == 3) { result = "b" + result; }
                if (propValue == 2) { result = "bi" + result; }
                if (propValue == 4) { result = "bi" + result; }
                if (propValue == 5) { result = "bi" + result; }
                if (propValue == 6) { result = "bi" + result; }


            }
            if (language.langaugeName == "Iton")
            {
                result = propStemIton[propValue - 1];
                if ((propValue >= 2) && (propValue <= 6))
                { result = "be" + " " + result; }
            }


            return (result);
        }
        
        public override void setStemSounds()
        {
            
                propStemSounds[0] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName +  "111" + "\\" + language.langaugeName + "1.wav";
                propStemSounds[1] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "222" + "\\" + language.langaugeName + "2.wav";
                propStemSounds[2] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "333" + "\\" + language.langaugeName + "3.wav";
                propStemSounds[3] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "444" + "\\" + language.langaugeName + "4.wav";
                propStemSounds[4] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "555" + "\\" + language.langaugeName + "5.wav";
                propStemSounds[5] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "666" + "\\" + language.langaugeName + "6.wav";
                propStemSounds[6] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "777" + "\\" + language.langaugeName + "7.wav";
                propStemSounds[7] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "888" + "\\" + language.langaugeName + "8.wav";
                propStemSounds[8] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "999" + "\\" + language.langaugeName + "9.wav";

                propStemSounds[9] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "111" + "\\" + language.langaugeName + "_1.wav";
                propStemSounds[10] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "222" + "\\" + language.langaugeName + "_2.wav";
                propStemSounds[11] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "333" + "\\" + language.langaugeName + "_3.wav";
                propStemSounds[12] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "444" + "\\" + language.langaugeName + "_4.wav";
                propStemSounds[13] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "555" + "\\" + language.langaugeName + "_5.wav";
                propStemSounds[14] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "666" + "\\" + language.langaugeName + "_6.wav";
                propStemSounds[15] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "777" + "\\" + language.langaugeName + "_7.wav";
                propStemSounds[16] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "888" + "\\" + language.langaugeName + "_8.wav";
                propStemSounds[17] = propSoundFolder + language.langaugeName + "\\numbers" + "\\" + language.langaugeName + "999" + "\\" + language.langaugeName + "_9.wav";
            
        }

        public override async void play(bool alone)
        {
            setStemSounds();
            string soundResult = propStemSounds[propValue - 1];
            if (alone == false) { soundResult = propStemSounds[9 + propValue - 1];}
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player = new System.Media.SoundPlayer(soundResult);
            player.PlaySync();
            await Task.Delay(2000);
        }

    }
}
