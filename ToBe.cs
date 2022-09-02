using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasuka
{
    class ToBe : Word
    {
        public NaturalLanguage language { get; set; }
        public override void setStemSounds()
        {
            propStemSounds[0] = propSoundFolder + language.langaugeName + "\\words\\" + "ToBe\\" + language.langaugeName + "0_be.wav";
            propStemSounds[1] = propSoundFolder + language.langaugeName + "\\words\\" + "ToBe\\" + language.langaugeName + "1_be.wav";
            propStemSounds[2] = propSoundFolder + language.langaugeName + "\\words\\" + "ToBe\\" + language.langaugeName + "2_be.wav";
            propStemSounds[3] = propSoundFolder + language.langaugeName + "\\words\\" + "ToBe\\" + language.langaugeName + "3_be.wav";
            propStemSounds[4] = propSoundFolder + language.langaugeName + "\\words\\" + "ToBe\\" + language.langaugeName + "4_be.wav";
            propStemSounds[5] = propSoundFolder + language.langaugeName + "\\words\\" + "ToBe\\" + language.langaugeName + "5_be.wav";
            propStemSounds[6] = propSoundFolder + language.langaugeName + "\\words\\" + "ToBe\\" + language.langaugeName + "6_be.wav";
            propStemSounds[7] = propSoundFolder + language.langaugeName + "\\words\\" + "ToBe\\" + language.langaugeName + "7_be.wav";
            propStemSounds[8] = propSoundFolder + language.langaugeName + "\\words\\" + "ToBe\\" + language.langaugeName + "8_be.wav";
            propStemSounds[9] = propSoundFolder + language.langaugeName + "\\words\\" + "ToBe\\" + language.langaugeName + "9_be.wav";
        }

        public override void setStemEnglish()
        {
            propStemEnglish[0] = "I AM AT HOME";
            propStemEnglish[1] = "I AM NOT AT HOME";
            propStemEnglish[2] = "I WAS AT HOME";
            propStemEnglish[3] = "I WAS NOT AT HOME";
            propStemEnglish[4] = "I WILL BE AT HOME";
            propStemEnglish[5] = "I WILL NOT BE AT HOME";
            propStemEnglish[6] = "I AM USUALLY AT HOME";
            propStemEnglish[7] = "I AM NOT USUALLY AT HOME";
            propStemEnglish[8] = "I WAS USUALLY AT HOME";
            propStemEnglish[9] = "I WAS NOT USUALLY AT HOME";
        }

        public override void setStemFrench()
        {
            propStemFrench[0] = "JE SUIS À LA MAISON";
            propStemFrench[1] = "JE SUIS PAS À LA MAISON";
            propStemFrench[2] = "J'ÉTAIS À LA MAISON";
            propStemFrench[3] = "JE N'ÉTAIS À LA MAISON";
            propStemFrench[4] = "JE SERAI À LA MAISON";
            propStemFrench[5] = "JE NE SERAI PAS À LA MAISON";
            propStemFrench[6] = "JE SUIS SOUVENT À LA MAISON";
            propStemFrench[7] = "JE NE SUIS PAS SOUVENT À LA MAISON";
            propStemFrench[8] = "J'ÉTAIS SOUVENT À LA MAISON";
            propStemFrench[9] = "JE N'ÉTAIS PAS SOUVENT À LA MAISON";
        }

    }
}
