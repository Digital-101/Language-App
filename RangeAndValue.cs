using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasuka
{
    class RangeAndValue
    {
        private string range;
        private int myVal;
        public NaturalLanguage language { get; set; }
        public string propRange
        {
            set { range = value; }
            get { return range; }
        }

        public int propMyVal
        {
            set { myVal = value; }
            get { return myVal; }
        }

        public void setNumberValue()
        {
            Random rnd = new Random();
            
            myVal = 0;
            if (range == "Units: 1 to 9")
            {
                myVal = rnd.Next(1, 10);
            }

            if (range == "Full tenths: 10, 20, 30, 40, to 90")
            {
                myVal = 10 * (rnd.Next(1, 10));
            }

            if (range == "Half tenths: 1 to 99 not multiple of 10")
            {
                myVal = (10 * (rnd.Next(1, 10))) + rnd.Next(1, 10);
            }

            if (range == "Full hundreds: 100, 200, 300, 400, to 900")
            {
                myVal = 100 * (rnd.Next(1, 10));
            }

            if (range == "Half hundreds: 100 to 999 not multiple of 100")
            {
                myVal = (100 * (rnd.Next(1, 10))) + (10 * (rnd.Next(1, 10))) + rnd.Next(1, 10);
            }

        }

        public Number generatedNumber()
        {
            Number result = null;

            if (range == "Units: 1 to 9")
            {
                Unit unit = new Unit();
                unit.language = this.language;
                unit.propValue = myVal;
                result = unit;
            }

            if (range == "Full tenths: 10, 20, 30, 40, to 90")
            {
                FullTenth fullTen = new FullTenth();
                fullTen.language = this.language;
                fullTen.propValue = myVal;
                result = fullTen;
            }

            if (range == "Half tenths: 1 to 99 not multiple of 10")
            {
                HalfTenth halfTen = new HalfTenth();
                halfTen.language = this.language;
                halfTen.propValue = myVal;
                result = halfTen;
            }

            if (range == "Full hundreds: 100, 200, 300, 400, to 900")
            {
                FullHundred fullHun = new FullHundred();
                fullHun.language = this.language;
                fullHun.propValue = myVal;
                result = fullHun;
            }

            if (range == "Half hundreds: 100 to 999 not multiple of 100")
            {
                HalfHundred halfHun = new HalfHundred();
                halfHun.language = this.language;
                halfHun.propValue = myVal;
                result = halfHun;
            }
            return (result);
        }


        public Number generatedNumber(int n)
        {
            Number result = null;

            if ((n>=1) && (n<=9))
            {
                Unit unit = new Unit();
                unit.language = this.language;
                unit.propValue = n;
                result = unit;
            }

            if (((n%10)==0) & (n>=10) & (n<=99))
            {
                FullTenth fullTen = new FullTenth();
                fullTen.language = this.language;
                fullTen.propValue = n;
                result = fullTen;
            }

            if (((n % 10) != 0) & (n >= 10) & (n <= 99))
            {
                HalfTenth halfTen = new HalfTenth();
                halfTen.language = this.language;
                halfTen.propValue = n;
                result = halfTen;
            }

            if (((n % 100) == 0) & (n >= 100) & (n <= 999))
            {
                FullHundred fullHun = new FullHundred();
                fullHun.language = this.language;
                fullHun.propValue = n;
                result = fullHun;
            }

            if (((n % 100) != 0) & (n >= 100) & (n <= 999))
            {
                HalfHundred halfHun = new HalfHundred();
                halfHun.language = this.language;
                halfHun.propValue = n;
                result = halfHun;
            }
            return (result);
        }

    }
}
