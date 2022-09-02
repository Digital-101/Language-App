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
    public partial class TestMeWordsForm : Form
    {
        public TestMeWordsForm()
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
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                assessMeButton_Click(this, new EventArgs());
                Task.Delay(450).Wait();
                testMeAgainButton_Click(this, new EventArgs());
            }
        }
        private void replayButton_Click(object sender, EventArgs e)
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
            wd.play();
            englishOrFrenchTextTextBox.Select();
            englishOrFrenchTextTextBox.Focus();
        }

        private void assessMeButton_Click(object sender, EventArgs e)
        {
            int s = int.Parse(scoreTextBox.Text);
            int t = int.Parse(totalTextBox.Text) + 1;
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
            if (wd.checkIton(englishOrFrenchTextTextBox.Text.ToUpper()) == true)
            {
                s = s + 1;
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
                msgBoxLabel.Text = "Incorrect answer below";
                Task.Delay(1000).Wait();
            }
            scoreTextBox.Text = s.ToString();
            totalTextBox.Text = t.ToString();
        }

        private void testMeAgainButton_Click(object sender, EventArgs e)
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
            wd.play();
            englishOrFrenchTextTextBox.Text = "";
            englishOrFrenchTextTextBox.Select();
            englishOrFrenchTextTextBox.Focus();
        }

        private void englishOrFrenchTextTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
