using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasuka
{
    class HalfTenth : Number
    {
        public NaturalLanguage language { get; set; }
        public override string lang()
        {
            int m = propValue / 10;
            int n = propValue % 10;
            string s1 = "";
            string s2 = "";
            FullTenth ft = new FullTenth();
            Unit un = new Unit();
            ft.language = this.language;
            //Unit un = new Unit();
            un.language = this.language;
            string prefix = " ";
            string result = "";
            if (this.language.langaugeName=="Swati")
            {
                if (n == 1) { prefix = prefix + " na"; }
                if (n == 2) { prefix = prefix + " na"; }
                if (n == 3) { prefix = prefix + " na"; }
                if (n == 4) { prefix = prefix + " na"; }
                if ((n >= 5) && (n <= 9)) { prefix = " ne"; }
                ft.propValue = m * 10;
                un.propValue = n;
                s1 = un.lang();
                s2 = s1;
                result = ft.lang() + prefix + s1;
                if (n == 9) { result = ft.lang() + prefix + "mfica"; }
            }
            if (language.langaugeName == "Igbo")
            {
                prefix = " na ";
                ft.propValue = m * 10;
                un.propValue = n;
                result = ft.lang() + prefix + un.lang();
            }
            if (language.langaugeName == "Lingala")
            {
                prefix = " na ";
                ft.propValue = m * 10;
                un.propValue = n;
                result = ft.lang() + prefix + un.lang();
            }
            if (language.langaugeName == "Mashi")
            {
                prefix = " makumi";
                if (n == 1) { prefix = " ikumi"; }
                ft.propValue = m * 10;
                un.propValue = n;
                result = ft.lang() + "na" + un.lang();
            }
            if (language.langaugeName == "Zulu")
            {
                if (n == 1) { prefix = prefix + " na"; }
                if (n == 2) { prefix = prefix + " nam"; }
                if (n == 3) { prefix = prefix + " nant"; }
                if (n == 4) { prefix = prefix + " na"; }
                if ((n >= 5) && (n <= 9)) { prefix = " nesi"; }

                ft.propValue = m * 10;
                un.propValue = n;
                s1 = un.lang();
                s2 = s1;
                if (n == 3) { s2 = s1.Substring(2, s1.Length - 2); }

                result = ft.lang() + prefix + s2;
            }

            if (language.langaugeName == "Iton")
            {
                m = propValue / 10;
                n = propValue % 10;
                //FullTenth ft = new FullTenth();
                //Unit un = new Unit();
                prefix = " eyi ";
                if (n == 1) { prefix = " ehe "; }
                ft.propValue = m * 10;
                un.propValue = n;
                result = ft.lang() + prefix + un.lang();
            }
            if (language.langaugeName == "Basaa")
            {
                if (n == 3) { prefix = " m "; }

                if ((n >= 1) && (n <= 9)) { prefix = " ni" ; }

                ft.propValue = m * 10;
                un.propValue = n;
                result = ft.lang() + prefix + un.lang();

            }
            return (result);
        }
        public override void setStemSounds()
        {
        }
        public override void play(bool alone)
        {
            int m = propValue / 10;
            int n = propValue % 10;
            FullTenth ft = new FullTenth();
            ft.language = this.language;
            Unit un = new Unit();
            un.language= this.language;
            ft.propValue = m * 10;
            un.propValue = n;

            if (alone == true) { ft.play(true); }
            if (alone == false) { ft.play(false); }
            un.play(false);
        }

    }
}
