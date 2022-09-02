using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasuka
{
    public partial class ChooseVerbForm : Form
    {
        public ChooseVerbForm()
        {
            InitializeComponent();
        }

        private void teachMeButton_Click(object sender, EventArgs e)
        {
            Word wd = null;
            Random rnd = new Random();
            int myVal = rnd.Next(0, 10);
            TeachMeWordsForm tmwif = new TeachMeWordsForm();
            tmwif.language = this.language;
           // tmwif.Text = this.language.;
            tmwif.propHidenValueLabel.Visible = false;
            tmwif.propHiddenValueTextBox.Text = myVal.ToString();
            tmwif.propHiddenValueTextBox.Visible = false;
            if (beRadioButton.Checked == true)
            {
                ToBe tbi = new ToBe();
                
                tbi.language = this.language;
                tbi.propValue = myVal;
                wd = tbi;
                tmwif.propHiddenValueTextBox.Text = myVal.ToString();
                tmwif.propHiddenOldValueTextBox.Text = myVal.ToString();
            }
            if (haveRadioButton.Checked == true)
            {
                ToHave thi = new ToHave();
                thi.language = this.language;
                thi.propValue = myVal;
                tmwif.propHiddenValueTextBox.Text = (myVal+10).ToString();
                tmwif.propHiddenOldValueTextBox.Text = (myVal + 10).ToString();
                wd = thi;
            }
            if (haveAndBeRadioButton.Checked == true)
            {
                Random rnd2 = new Random();
                int myVal2 = rnd.Next(0, 2);
                if (myVal2==0)
                {
                    ToBe tbi = new ToBe();
                    tbi.language = this.language;
                    tbi.propValue = myVal;
                    wd = tbi;
                    tmwif.propHiddenValueTextBox.Text = (myVal + 20).ToString();
                  
                    tmwif.propHiddenOldValueTextBox.Text = (myVal +20).ToString();
                }
                if (myVal2==1)
                {
                    ToHave thi = new ToHave();
                    thi.language = this.language;
                    thi.propValue = myVal;
                    wd = thi;
                    tmwif.propHiddenValueTextBox.Text = (myVal + 30).ToString();
                    tmwif.propHiddenOldValueTextBox.Text= (myVal + 30).ToString();
                }
            }
            wd.play();
            tmwif.propEnglishOrFrenchTextTextBox.Select();
            tmwif.propEnglishOrFrenchTextTextBox.Focus();
            tmwif.Show();
        }

        private void testMeButton_Click(object sender, EventArgs e)
        {
            Word wd = null;
            Random rnd = new Random();
            int myVal = rnd.Next(0, 10);
            TestMeWordsForm tmwif = new TestMeWordsForm();
            tmwif.language = this.language;
            tmwif.propHidenValueLabel.Visible = false;
            tmwif.propHiddenValueTextBox.Text = myVal.ToString();
            tmwif.propHiddenValueTextBox.Visible = false;
            if (beRadioButton.Checked == true)
            {
                ToBe tbi = new ToBe();
                tbi.language = this.language;
                tbi.propValue = myVal;
                wd = tbi;
                tmwif.propHiddenValueTextBox.Text = myVal.ToString();
            }
            if (haveRadioButton.Checked == true)
            {
                ToHave thi = new ToHave();
                thi.language = this.language;
                thi.propValue = myVal;
                tmwif.propHiddenValueTextBox.Text = (myVal + 10).ToString();
                wd = thi;
            }
            if (haveAndBeRadioButton.Checked == true)
            {
                Random rnd2 = new Random();
                int myVal2 = rnd.Next(0, 2);
                if (myVal2 == 0)
                {
                    ToBe tbi = new ToBe();
                    tbi.language = this.language;
                    tbi.propValue = myVal;
                    wd = tbi;
                    tmwif.propHiddenValueTextBox.Text = (myVal + 20).ToString();
                }
                if (myVal2 == 1)
                {
                    ToHave thi = new ToHave();
                    thi.language = this.language;
                    thi.propValue = myVal;
                    wd = thi;
                    tmwif.propHiddenValueTextBox.Text = (myVal + 30).ToString();
                }
            }
            wd.play();
            tmwif.propEnglishOrFrenchTextTextBox.Select();
            tmwif.propEnglishOrFrenchTextTextBox.Focus();
            tmwif.Show();
        }
    }
}
