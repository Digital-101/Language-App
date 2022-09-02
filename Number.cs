using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasuka
{
    abstract class Number
    {
        private static NaturalLanguage nl = new NaturalLanguage();
        //TeachMeNumbersForm teachMeNumbersForm = new TeachMeNumbersForm();

        private static string soundFolder = Application.StartupPath + "\\sound\\";
        
        private static string[] stemSounds = new String[20];

       // private static string[][] stemSound = new String[5],20;
        

        private int val;

        //private string[] stem = { "nye", "bili", "tsatfu", "ne", "hlanu", "tfupha", "khombisa", "phohlongo", "yimfica", "shumi", "khulu" };
        private string[] stemSwati = { "nye", "bili", "tsatfu", "ne", "hlanu", "tfupha", "khombisa", "phohlongo", "yimfica", "shumi", "khulu" };
        private string[] stemLingala = { "moko", "mibale", "misato", "minei", "mitano", "motoba", "sambo", "mwambe", "libwa", "zomi", "nkama" };
        private string[] stemIgbo = { "otu", "buo", "to", "no", "se", "sii", "saa", "sato", "teghete", "ri", "nari" };
        private string[] stemMashi = { "guma", "biri", "sharu", "ni", "rhanu", "ndarhu", "nda", "munani", "mwenda", "ikumi", "igana" };
        private string[] stemZulu = { "nye", "bili", "thathu", "ne", "hlanu", "thupha", "khombisa", "shiyagalombili", "shiyagalolunye", "shumi", "khulu" };
        private string[] stemIton = { "mmwag", "ba", "la", "na", "tan", "samni", "zangmal", "ngmam", "ibul", "wom", "nted" };
        private string[] stemBasaa = { "yada", "ba", "aa", "na", "tan", "samal", "sambog", "djuem", "boo", "djom", "mbogol" };

        public string[] propStemBasaa
        {
            get { return stemBasaa; }
        }

        public string[] propStemIton
        {
            get { return stemIton; }
        }
        public string[] propStemSwati
        {
            get { return stemSwati; }
        }
        public string[] propStemLingala
        {
            get { return stemLingala; }
        }
        public string[] propStemIgbo
        {
            get { return stemIgbo; }
        }
        public string[] propStemMashi
        {
            get { return stemMashi; }
        }
        public string[] propStemZulu
        {
            get { return stemZulu; }
        }
        public int propValue
        {
            set { val = value; }
            get { return val; }
        }

        //public string[] propStem
        //{
        //    get { return stem; }
        //}

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

        abstract public string lang();

        abstract public void play(bool alone);

        abstract public void setStemSounds();

    }
}
