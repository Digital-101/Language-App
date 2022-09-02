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
    public partial class TeachMeWordsForm : Form
    {
        public TeachMeWordsForm()
        {
            InitializeComponent();
        }

        private void blinkTextbox(object sender, EventArgs e)
        {
            if (msgBoxLabel.BackColor == Color.Gold)
            { msgBoxLabel.BackColor = Color.Green; }
            else
            { msgBoxLabel.BackColor = Color.Gold; }
        }

        private void blinkTextbox2(object sender, EventArgs e)
        {
            if (msgBoxLabel2.BackColor == Color.Gold)
            { msgBoxLabel2.BackColor = Color.Green; }
            else
            { msgBoxLabel2.BackColor = Color.Gold; }
        }

        private void blinkTextbox3(object sender, EventArgs e)
        {
            if (msgBoxLabel3.BackColor == Color.Gold)
            { msgBoxLabel3.BackColor = Color.Green; }
            else
            { msgBoxLabel3.BackColor = Color.Gold; }
        }
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                assessMeButton_Click(this, new EventArgs());
                Task.Delay(450).Wait();
                teachMeAgainButton_Click(this, new EventArgs());
            }
        }

        private void OurReplayButton()
        {
            if (!msgBoxLabel3.Text.Contains("....") && !msgBoxLabel2.Text.Contains("....")
                   && msgBoxLabel3.Text != "" && msgBoxLabel2.Text != "")
            {
                Word wd = null;
                int n = int.Parse(hiddenOldValueTextBox.Text);
                if (((n >= 0) && (n <= 9)) || ((n >= 20) && (n <= 29)))
                {
                    ToBe tbi = new ToBe();
                    tbi.language = this.language;
                    if ((n >= 0) && (n <= 9)) { tbi.propValue = n; };
                    if ((n >= 20) && (n <= 29)) { tbi.propValue = n - 20; }
                    wd = tbi;
                }
                if (((n >= 10) && (n <= 19)) || ((n >= 30) && (n <= 39)))
                {
                    ToHave thi = new ToHave();
                    thi.language = this.language;
                    if ((n >= 10) && (n <= 19)) { thi.propValue = n - 10; }
                    if ((n >= 30) && (n <= 39)) { thi.propValue = n - 30; }
                    wd = thi;
                }
                wd.play();
                englishOrFrenchTextTextBox.Select();
                englishOrFrenchTextTextBox.Focus();
            }
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            Word wd = null;
            int n = int.Parse(propHiddenValueTextBox.Text);
            if (((n>=0) && (n<=9)) || ((n >= 20) && (n <= 29)))
            {
                ToBe tbi = new ToBe();
                tbi.language = this.language;
                if ((n >= 0) && (n <= 9)) { tbi.propValue = n; };
                if ((n >= 20) && (n <= 29)) { tbi.propValue = n-20; }
                wd = tbi;
            }
            if (((n>=10) && (n<=19)) || ((n >= 30) && (n <= 39)))
            {
                ToHave thi = new ToHave();
                thi.language = this.language;
                if ((n >= 10) && (n <= 19)) { thi.propValue = n - 10; }
                if ((n >= 30) && (n <= 39)) { thi.propValue = n - 30; }
                wd = thi;
            }
            wd.play();
            englishOrFrenchTextTextBox.Select();
            englishOrFrenchTextTextBox.Focus();
        }

        private void assessMeButton_Click(object sender, EventArgs e)
        {
            Word wd = null;
            int n = int.Parse(propHiddenValueTextBox.Text);
            if (((n >= 0) && (n <= 9)) || ((n >= 20) && (n <= 29)))
            {
                ToBe tbi = new ToBe();
                tbi.language = this.language;
                if ((n >= 0) && (n <= 9)) { tbi.propValue = n; };
                if ((n >= 20) && (n <= 29)) { tbi.propValue = n - 20; }
                wd = tbi;
            }
            if (((n >= 10) && (n <= 19)) || ((n >= 30) && (n <= 39)))
            {
                ToHave thi = new ToHave();
                thi.language = this.language;
                if ((n >= 10) && (n <= 19)) { thi.propValue = n - 10; }
                if ((n >= 30) && (n <= 39)) { thi.propValue = n - 30; }
                wd = thi;
            }
            if (wd.checkIton(englishOrFrenchTextTextBox.Text.ToUpper()) ==true)
            {
                hiddenOldValueLabel.Text = "correct";
                msgBoxLabel2.Text = "";
                msgBoxLabel3.Text = "";
                if (msgBoxLabel.BackColor == Color.Gold)
                { msgBoxLabel.BackColor = Color.Green; }
                else
                { msgBoxLabel.BackColor = Color.Gold; }
                msgBoxLabel.Text = "Correct";
                Timer ti = new Timer();
                ti.Tick += blinkTextbox;
                ti.Interval = 450;
                ti.Enabled = true;

            }
            if (wd.checkIton(englishOrFrenchTextTextBox.Text.ToUpper()) == false)
            {
                hiddenOldValueLabel.Text = "incorrect";
                msgBoxLabel.Text = "Incorrect: Click answer below / Click reponse ci-bas";
                msgBoxLabel2.Text = wd.propStemEnglish[wd.propValue];
                msgBoxLabel3.Text = wd.propStemFrench[wd.propValue];
                hiddenOldValueTextBox.Text = n.ToString();
            }
        }

        private void teachMeAgainButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int myVal = rnd.Next(0, 10);
            Word wd = null;
            int n = int.Parse(propHiddenValueTextBox.Text);
            if ((n >= 0) && (n <= 9))
            {
                ToBe tbi = new ToBe();
                tbi.language = this.language;
                tbi.propValue = myVal;
                wd = tbi;
                propHiddenValueTextBox.Text = myVal.ToString();
            }
            if ((n >= 10) && (n <= 19))
            {
                ToHave thi = new ToHave();
                thi.language = this.language;
                thi.propValue = myVal;
                wd = thi;
                propHiddenValueTextBox.Text = (myVal + 10).ToString();
            }
            if ((n >= 20) && (n <= 39))
            {
                Random rnd2 = new Random();
                int myVal2 = rnd.Next(0, 2);
                if (myVal2 == 0)
                {
                    ToBe tbi = new ToBe();
                    tbi.language = this.language;
                    tbi.propValue = myVal;
                    wd = tbi;
                    propHiddenValueTextBox.Text = (myVal + 20).ToString();
                }
                if (myVal2 == 1)
                {
                    ToHave thi = new ToHave();
                    thi.language = this.language;
                    thi.propValue = myVal;
                    wd = thi;
                    propHiddenValueTextBox.Text = (myVal + 30).ToString();
                }
            }
            if (hiddenOldValueLabel.Text == "correct") { wd.play(); }
           
            englishOrFrenchTextTextBox.Text = "";
            englishOrFrenchTextTextBox.Select();
            englishOrFrenchTextTextBox.Focus();
        }

        private void msgBoxLabel2_Click(object sender, EventArgs e)
        {
            OurReplayButton();
        }

        private void msgBoxLabel3_Click(object sender, EventArgs e)
        {
            OurReplayButton();
        }

        private void TeachMeWordsItonForm_Load(object sender, EventArgs e)
        {

        }
    }
}
