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
    public partial class TestMeNumbersForm : Form
    {
        public TestMeNumbersForm()
        {
            InitializeComponent();
        }
        public void putNmberDown()
        {
            if (numberValueLabel.Location.Y < itonTextLabel.Location.Y)
            {
                int yL = numberValueLabel.Location.Y;
                int yT = numberValueTextBox.Location.Y;
                numberValueLabel.Top = itonTextLabel.Location.Y;
                numberValueTextBox.Top = itonTextTextBox.Location.Y;
                itonTextLabel.Top = yL;
                itonTextTextBox.Top = yT;
            }
        }

        public void putTextDown()
        {
            if (itonTextLabel.Location.Y < numberValueLabel.Location.Y)
            {
                int yL = itonTextLabel.Location.Y;
                int yT = itonTextTextBox.Location.Y;
                itonTextLabel.Top = numberValueLabel.Location.Y;
                itonTextTextBox.Top = numberValueTextBox.Location.Y;
                numberValueLabel.Top = yL;
                numberValueTextBox.Top = yT;
            }
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
                if (readOrWriteOrHearTextBox.Text == "hearing")
                {
                    this.timer.Stop();
                }
                assessMeButton_Click(this, new EventArgs());
                Task.Delay(1000).Wait();
                testMeAgainButton_Click(this, new EventArgs());
            }
        }

        private void assessMeButton_Click(object sender, EventArgs e)
        {
            int n = 0;
            bool isNumeric = int.TryParse(propNumberValueTextBox.Text, out n);
            if ((isNumeric == false) || ((isNumeric == true) && ((n < 1) || (n > 999))))
            {
                msgBoxLabel.Text = "Error! Erreur! Numbers from 1 to 999! Nombre entre 1 et 999";
            }
            else
            {
                int s = int.Parse(scoreTextBox.Text);
                int t = int.Parse(totalTextBox.Text) + 1;
                Number numb = null;
                RangeAndValue rAndv = new RangeAndValue();
                rAndv.language = this.language;
                rAndv.propRange = propNumberRangeTextBox.Text;
                rAndv.propMyVal = n;
                numb = rAndv.generatedNumber();
                bool correctAnswer = false;
                string answer = "";
                if (readOrWriteOrHearTextBox.Text == "writing")
                {
                    correctAnswer = (itonTextTextBox.Text == numb.lang());
                    answer = numb.lang();
                    itonTextTextBox.Text = "";
                }
                if ((readOrWriteOrHearTextBox.Text == "reading") || (readOrWriteOrHearTextBox.Text == "hearing"))
                {
                    correctAnswer = (numberValueTextBox.Text == hiddenValueTextBox.Text);
                    answer = hiddenValueTextBox.Text;
                    numberValueTextBox.Text = "";
                }

                if (correctAnswer == true)
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
                    ti.Enabled = true; msgBoxLabel.Text = "Correct answer!     /     Réponse correcte";
                }
                else
                {
                    msgBoxLabel.Text = "Incorrect answer!     /     Réponse incorrecte";
                }

                if ((readOrWriteOrHearTextBox.Text == "reading") || (readOrWriteOrHearTextBox.Text == "hearing"))
                {
                    numberValueTextBox.Select();
                    numberValueTextBox.Focus();
                }
                if (readOrWriteOrHearTextBox.Text == "writing")
                {
                    itonTextTextBox.Select();
                    itonTextTextBox.Focus();
                }

                scoreTextBox.Text = s.ToString();
                totalTextBox.Text = t.ToString();

            }
        }

        private void testMeAgainButton_Click(object sender, EventArgs e)
        {
            RangeAndValue rAndv = new RangeAndValue();
            rAndv.language = this.language;
            rAndv.propRange = propNumberRangeTextBox.Text;
            rAndv.setNumberValue();
            propNumberValueTextBox.Text = rAndv.propMyVal.ToString();
            propHiddenValueTextBox.Text = rAndv.propMyVal.ToString();

            propHidenValueLabel.Visible = false;
            propHiddenValueTextBox.Visible = false;

            propNumberValueTextBox.Enabled = false;

            if (readOrWriteOrHearTextBox.Text == "hearing")
            {
                Number numb = null;
                numb = rAndv.generatedNumber();
                propNumberValueTextBox.Text = "";
                propNumberValueTextBox.Enabled = true;
                propHiddenValueTextBox.Text = numb.propValue.ToString();
                numb.setStemSounds();
                this.timer.Stop();
                this.timer = new Timer();
                this.timer.Tick += delegate
                {
                    numb.play(true);
                    Task.Delay(1000).Wait();
                };
                this.timer.Start();
               // numb.play(true);
                //propItonTextTextBox.Text = numb.iton();
                propItonTextTextBox.Enabled = false;
            }

            if (readOrWriteOrHearTextBox.Text == "reading")
            {
                Number numb = null;
                numb = rAndv.generatedNumber();
                propNumberValueTextBox.Text = "";
                propNumberValueTextBox.Enabled = true;
                propHiddenValueTextBox.Text = numb.propValue.ToString();
                propItonTextTextBox.Text = numb.lang();
                propItonTextTextBox.Enabled = false;
            }

            if (readOrWriteOrHearTextBox.Text == "writing") { itonTextTextBox.Text = ""; }

            if ((readOrWriteOrHearTextBox.Text == "reading") || (readOrWriteOrHearTextBox.Text == "hearing"))
            {
                numberValueTextBox.Select();
                numberValueTextBox.Focus();
            }
            if (readOrWriteOrHearTextBox.Text == "writing")
            {
                itonTextTextBox.Select();
                itonTextTextBox.Focus();
            }
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            int n = int.Parse(propHiddenValueTextBox.Text);
            RangeAndValue rAndv = new RangeAndValue();
            rAndv.language = this.language;
            Number numb = rAndv.generatedNumber(n);
            numb.setStemSounds();
            this.timer.Stop();
            this.timer = new Timer();
            this.timer.Tick += delegate
            {
                numb.play(true);
                Task.Delay(1000).Wait();
            };
            this.timer.Start();



            //numb.play(true);
            numberValueTextBox.Select();
            numberValueTextBox.Focus();
        }

        private void TestMeNumbersForm_Load(object sender, EventArgs e)
        {

        }

        private void TestMeNumbersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (readOrWriteOrHearTextBox.Text == "hearing")
            {
                this.timer.Stop();
            }
            previousForm.Show();
        }
    }
}
