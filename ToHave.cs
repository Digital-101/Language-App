using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasuka
{
    class ToHave : Word

    {
        public NaturalLanguage language { get; set; }
        public override void setStemSounds()
        {
            propStemSounds[0] = propSoundFolder+language.langaugeName+ "\\words\\" + "ToHave\\" + language.langaugeName + "0_have.wav";
            propStemSounds[1] = propSoundFolder + language.langaugeName + "\\words\\" + "ToHave\\" + language.langaugeName + "1_have.wav";
            propStemSounds[2] = propSoundFolder + language.langaugeName + "\\words\\" + "ToHave\\" + language.langaugeName + "2_have.wav";
            propStemSounds[3] = propSoundFolder + language.langaugeName + "\\words\\" + "ToHave\\" + language.langaugeName + "3_have.wav";
            propStemSounds[4] = propSoundFolder + language.langaugeName + "\\words\\" + "ToHave\\" + language.langaugeName + "4_have.wav";
            propStemSounds[5] = propSoundFolder + language.langaugeName + "\\words\\" + "ToHave\\" + language.langaugeName + "5_have.wav";
            propStemSounds[6] = propSoundFolder + language.langaugeName + "\\words\\" + "ToHave\\" + language.langaugeName + "6_have.wav";
            propStemSounds[7] = propSoundFolder + language.langaugeName + "\\words\\" + "ToHave\\" + language.langaugeName + "7_have.wav";
            propStemSounds[8] = propSoundFolder + language.langaugeName + "\\words\\" + "ToHave\\" + language.langaugeName + "8_have.wav";
            propStemSounds[9] = propSoundFolder + language.langaugeName + "\\words\\" + "ToHave\\" + language.langaugeName + "9_have.wav";
        }

        public override void setStemEnglish()
        {
            propStemEnglish[0] = "I HAVE A HOME";
            propStemEnglish[1] = "I DO NOT HAVE A HOME";
            propStemEnglish[2] = "I HAD A HOME";
            propStemEnglish[3] = "I DID NOT HAVE A HOME";
            propStemEnglish[4] = "I WILL HAVE A HOME";
            propStemEnglish[5] = "I WILL NOT HAVE A HOME";
            propStemEnglish[6] = "I USUALLY HAVE A HOME";
            propStemEnglish[7] = "I DO NOT USUALLY HAVE A HOME";
            propStemEnglish[8] = "I USUALLY HAD A HOME";
            propStemEnglish[9] = "I DID NOT USUALLY HAVE A HOME";
        }

        public override void setStemFrench()
        {
            propStemFrench[0] = "J'AI UN DOMICILE";
            propStemFrench[1] = "JE N'AI PAS DE DOMICILE";
            propStemFrench[2] = "J'AVAIS UN DOMICILE";
            propStemFrench[3] = "JE N'AVAIS PAS DE DOMICILE";
            propStemFrench[4] = "J'AURAI UN DOMICILE";
            propStemFrench[5] = "JE N'AURAI PAS DE DOMICILE";
            propStemFrench[6] = "J'AI SOUVENT UN DOMICILE";
            propStemFrench[7] = "JE N'AI PAS SOUVENT DE DOMICILE";
            propStemFrench[8] = "J'AVAIS SOUVENT UN DOMICILE";
            propStemFrench[9] = "JE N'AVAIS PAS SOUVENT DE DOMICILE";
        }

    }
}
