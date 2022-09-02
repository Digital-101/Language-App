using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasuka
{
    class HalfHundred : Number
    {
        public NaturalLanguage language { get; set; }
        public override string lang()
        {
            int m = propValue / 100;
            int n = propValue % 100;
            FullHundred fh = new FullHundred();
            FullTenth ft = new FullTenth();
            HalfTenth ht = new HalfTenth();
            ht.language = this.language;
            ft.language = this.language;
            fh.language = this.language;
            Number numb = null;
            string prefix = " "; 
            string result = " ";
            string s1 = "";
            string s2 = "";
            if (language.langaugeName=="Swati")
            {
                prefix = " nalokung";
                fh.propValue = m * 100;
                if ((n % 10) == 0)
                {
                    ft.propValue = n;
                    numb = ft;
                }
                else
                {
                    ht.propValue = n;
                    numb = ht;
                }
                if ((n >= 11) && (n <= 19)) { prefix = " ne"; }
                s1 = numb.lang();
                s2 = s1;
                if ((n >= 11) && (n <= 19)) { s2 = s1.Substring(1, s1.Length - 1); }
                result = fh.lang() + prefix + s2;
            }
            if (language.langaugeName == "Igbo")
            {
                prefix = "na";
                //NumberIgbo numb = null;
                fh.propValue = m * 100;
                if ((n % 10) == 0)
                {
                     ft.propValue = n;
                    numb = ft;
                }
                else
                {
                    ht.propValue = n;
                    numb = ht;
                }
                result = fh.lang() + " " + prefix + " " + numb.lang();

            }
            if (language.langaugeName == "Lingala")
            {
                prefix = " na ";
                fh.propValue = m * 100;

                if ((n % 10) == 0)
                {
                    ft.propValue = n;
                    numb = ft;
                }
                else
                {
                    ht.propValue = n;
                    numb = ht;
                }
                result = fh.lang() + prefix + numb.lang();
            }
            if (language.langaugeName == "Mashi")
            {
                fh.propValue = m * 100;
                if ((n % 10) == 0)
                {
                    ft.propValue = n;
                    numb = ft;
                }
                else
                {
                    ht.propValue = n;
                    numb = ht;
                }
              result = fh.lang() + " na " + numb.lang();
            }
            if (language.langaugeName == "Zulu")
            {
                prefix = " nam";
                
                if ((n % 10) == 0)
                {
                    ft.propValue = n;
                    numb = ft;
                }
                else
                {
                    ht.propValue = n;
                    numb = ht;
                }

                if ((n >= 11) && (n <= 19)) { prefix = " ne"; }
                s1 = numb.lang();
                s2 = s1;
                if ((n >= 11) && (n <= 19)) { s2 = s1.Substring(1, s1.Length - 1); }
                result = fh.lang() + prefix + s2;
            }

            if (language.langaugeName == "Iton")
            {
                m = propValue / 100;
                n = propValue % 100;
                //FullHundred fh = new FullHundred();
                //Number numb = null;
                prefix = " eyi ";
                if (n == 1) { prefix = " ehe "; }
                fh.propValue = m * 100;

                if ((n % 10) == 0)
                {
                    //   FullTenth ft = new FullTenth();
                    ft.propValue = n;
                    numb = ft;
                }
                else
                {
                    // HalfTenth ht = new HalfTenth();
                    ht.propValue = n;
                    numb = ht;
                }
                result = fh.lang() + prefix + numb.lang();
            }
            if (language.langaugeName == "Basaa")
            {
                prefix = " ni mom ";
                if (n == 1) { prefix = " "; }
                if (n == 3) { prefix = " m "; }
                if ((n % 10) == 0)
                {
                    ft.propValue = n;
                    numb = ft;
                }
                else
                {
                    ht.propValue = n;
                    numb = ht;
                }
                result = fh.lang() + " " + propStemBasaa[m - 1] + prefix + numb.lang();

            }

            return (result);
        }

        public override void setStemSounds()
        {
        }
        public override  void play(bool alone)
        {
            int m = propValue / 100;
            int n = propValue % 100;
            FullHundred fh = new FullHundred();
            fh.language= this.language;
            Number numb = null;

            fh.propValue = m * 100;

            if ((n % 10) == 0)
            {
                FullTenth ft = new FullTenth();
                ft.language= this.language;
                ft.propValue = n;
                numb = ft;
            }
            else
            {
                HalfTenth ht = new HalfTenth();
                ht.language= this.language;
                ht.propValue = n;
                numb = ht;
            }
            fh.play(true);
            numb.play(false);
        }

        /*
        public override void play()
        {
        }
        */
    }
}
