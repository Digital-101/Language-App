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
    public partial class TeachMeNumbersForm : Form
    {
        public TeachMeNumbersForm()
        {
            InitializeComponent();
            if (readOrWriteOrHearTextBox.Text == "hearing")
            {
                itonTextLabel.Visible = false;
                itonTextTextBox.Visible = false;

            }
            //replayButton.
            // itonTextLabel.Text =this.language.langaugeName + "Text";
        }

        private void VeMaNkatOtillForm_Load(object sender, EventArgs e)
        {

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
        private void OurReplayButton()
        {
            if (!msgBoxLabel.Text.Contains("....") && !msgBoxLabel2.Text.Contains("....")
                && msgBoxLabel.Text != "" && msgBoxLabel2.Text != "")
            {
                int n = int.Parse(hiddenOldValueTextBox.Text);
                RangeAndValue rAndv = new RangeAndValue();
                rAndv.language = this.language;
                Number numb = rAndv.generatedNumber(n);
                numb.setStemSounds();
                //numb.play(true);
                this.timer.Stop();
                this.timer = new Timer();
                this.timer.Tick += delegate
                {
                    numb.play(true);
                    Task.Delay(1000).Wait();
                };
                this.timer.Start();
                numberValueTextBox.Select();
                numberValueTextBox.Focus();
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
               
                propNumberValueTextBox.Text = "";
                propNumberValueTextBox.Enabled = true;

                Number numb = null;
                numb = rAndv.generatedNumber();
                propHiddenValueTextBox.Text = numb.propValue.ToString();
                numb.setStemSounds();
               // this.timer.Stop();
                this.timer = new Timer();

                this.timer.Tick += delegate
                {
                    numb.play(true);
                    Task.Delay(1000).Wait();
                };
                this.timer.Start();
                if (hiddenOldValueLabel.Text == "correct")
                {

                    //numb.play(true);
                }
              


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

        private void assessMeButton_Click(object sender, EventArgs e)
        {
            int n = 0;
            bool isNumeric = int.TryParse(propNumberValueTextBox.Text, out n);
            if ((isNumeric == false) || ((isNumeric == true) && ((n < 1) || (n > 999))))
            {
                msgBoxLabel.Text = "Error!!! Please enter a number between 1 and 999";
                msgBoxLabel2.Text = "Erreur!! S'il vous plait tapez un nombre entre 1 et 999";
            }
            else
            {
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
                if ( (readOrWriteOrHearTextBox.Text == "reading") || (readOrWriteOrHearTextBox.Text == "hearing"))
                {
                    correctAnswer = (numberValueTextBox.Text == hiddenValueTextBox.Text);
                    answer = hiddenValueTextBox.Text;
                    numberValueTextBox.Text = "";
                }

                if (correctAnswer == true)
                {
                    hiddenOldValueLabel.Text = "correct";
                    msgBoxLabel2.Text = "";
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
                   
                    msgBoxLabel.Text = "Incorrect/e! correct answer below / voir reponse ci-bas";
                    msgBoxLabel2.Font = new Font(msgBoxLabel2.Font.Name, 12, FontStyle.Bold | FontStyle.Underline);
                    if (readOrWriteOrHearTextBox.Text == "writing")
                    {
                        itonTextTextBox.Select();
                        msgBoxLabel2.Text = numb.propValue + " : " + answer;
                    }
                    if (readOrWriteOrHearTextBox.Text == "reading")
                    {
                        itonTextTextBox.Select();
                        msgBoxLabel2.Text = hiddenValueTextBox.Text + " : " + itonTextTextBox.Text;
                    }
                    if (readOrWriteOrHearTextBox.Text == "hearing")
                    {
                        msgBoxLabel.Text = "Incorrect/e! click answer below / Click reponse ci-bas";
                        msgBoxLabel2.Text = hiddenValueTextBox.Text; 
                        hiddenOldValueTextBox.Text = hiddenValueTextBox.Text;
                        hiddenOldValueLabel.Text = "incorrect";
                    }

                }
                if ((readOrWriteOrHearTextBox.Text == "reading") || (readOrWriteOrHearTextBox.Text == "hearing"))
                {
                    if(readOrWriteOrHearTextBox.Text == "hearing")
                        {
                        itonTextLabel.Visible = false;
                        itonTextTextBox.Visible = false;
                         }
                    numberValueTextBox.Select();
                    numberValueTextBox.Focus();
                }
                if (readOrWriteOrHearTextBox.Text == "writing")
                {
                    itonTextTextBox.Select();
                    itonTextTextBox.Focus();
                }
            }
        }

        private void hiddenValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
            int n = int.Parse(propHiddenValueTextBox.Text);
            RangeAndValue rAndv = new RangeAndValue();
            rAndv.language = this.language;
            Number numb = rAndv.generatedNumber(n);
            numb.setStemSounds();
            //numb.play(true);
            
            this.timer = new Timer();
            this.timer.Tick += delegate
            {
                numb.play(true);
                Task.Delay(1000).Wait();
            };
            this.timer.Start();
            numberValueTextBox.Select();
            numberValueTextBox.Focus();
        }

        private void msgBoxLabel2_Click(object sender, EventArgs e)
        {
            if (readOrWriteOrHearTextBox.Text == "hearing")
            {
                OurReplayButton();
            }
        }

        private void msgBoxLabel_Click(object sender, EventArgs e)
        {
            if (readOrWriteOrHearTextBox.Text == "hearing")
            {
                OurReplayButton();
            }
        }

        private void numberValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeachMeNumbersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (readOrWriteOrHearTextBox.Text == "hearing")
            {
                this.timer.Stop();
            }
            previousForm.Show();
        }

        private void buttonNextnumber_Click(object sender, EventArgs e)
        {
            int n = 0;
            string range = "";
            range = setRangeAndValue().propRange;
            n = setRangeAndValue().propMyVal;
            if (readOrWriteOrHearTextBox.Text == "hearing")
            {
                this.timer.Stop();
                // ymof.propReadOrWriteOrHearTextBox.Text = "hearing";
                ///ymof.propReplayTextBox.Visible = true;
                RangeAndValue rAndv = new RangeAndValue();
                rAndv.propRange = range;
                rAndv.propMyVal = n;
                rAndv.language = this.language;
                Number numb = null;
                numb = rAndv.generatedNumber();
                //numb=rAndv.
               this.propNumberValueTextBox.Text = "";
               this.propNumberValueTextBox.Enabled = true;
               this.propHiddenValueTextBox.Text = n.ToString();
               this.propNumberValueTextBox.Enabled = true;
 
                msgBoxLabel.Text = numb.lang();
                msgBoxLabel2.Text = n.ToString();
                this.propHiddenValueTextBox.Text = n.ToString();
                this.propItonTextTextBox.Text = numb.lang();
                this.propHiddenOldValueTextBox.Text = n.ToString();
                
               this.timer = new Timer();
               this.timer.Tick += delegate
                {
                    numb.play(true);
                    //var del=  Task.Delay(2000);
                    Task.Delay(1000).Wait();
                    //await del;
                };
                // ymof.timer.
                this.timer.Start();
                this.propItonTextTextBox.Enabled = false;
            }
        }
        private RangeAndValue setRangeAndValue()
        {
            string range = "";
            int n = 0;
            RangeAndValue rAndv = new RangeAndValue();
            rAndv.language = this.language;
            Random rnd = new Random();
            ChooseRangeForm rangeForm = new ChooseRangeForm();
            
            if (previousForm.propunitsRadioButton.Checked == true)
            {
                range = "Units: 1 to 9";
                n = rnd.Next(1, 10);
            }

            if (previousForm.propfullTenthsRadioButton.Checked == true)
            {
                range = "Full tenths: 10, 20, 30, 40, to 90";
                n = 10 * (rnd.Next(1, 10));
            }

            if (previousForm.prophalfTenthsRadioButton.Checked == true)
            {
                range = "Half tenths: 1 to 99 not multiple of 10";
                n = (10 * (rnd.Next(1, 10))) + rnd.Next(1, 10);
            }

            if (previousForm.propfullHundredsRadioButton.Checked == true)
            {
                range = "Full hundreds: 100, 200, 300, 400, to 900";
                n = 100 * (rnd.Next(1, 10));
            }
            //this.language
            if (previousForm.prophalfHundredsRadioButton.Checked == true)
            {
                range = "Half hundreds: 100 to 999 not multiple of 100";
                n = (100 * (rnd.Next(1, 10))) + (10 * (rnd.Next(1, 10))) + rnd.Next(1, 10);
            }

            rAndv.propRange = range;
            rAndv.propMyVal = n;
            return (rAndv);
        }
        public static void CenterHorizontally(Control control)
        {
            Rectangle parentRect = control.Parent.ClientRectangle;
            control.Left = (parentRect.Width - control.Width) / 2;
        }
    }
}
