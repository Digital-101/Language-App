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
    public partial class ChooseRangeForm : Form
    {
        Timer timer = new Timer();
        public ChooseRangeForm()
        {
            InitializeComponent();
        }

        private void setLearnForm(TeachMeNumbersForm ymofPar, string rangePar, int valPar)
        {
            ymofPar.propNumberRangeTextBox.Text = rangePar;
            ymofPar.propNumberValueTextBox.Text = valPar.ToString();

        }

        private void setTeachForm(TestMeNumbersForm vmnofPar, string rangePar, int valPar)
        {
            vmnofPar.propNumberRangeTextBox.Text = rangePar;
            vmnofPar.propNumberValueTextBox.Text = valPar.ToString();

        }

        private RangeAndValue setRangeAndValue()
        {
            string range = "";
            int n = 0;
            RangeAndValue rAndv = new RangeAndValue();
            rAndv.language = this.language;
            Random rnd = new Random();
            if (unitsRadioButton.Checked == true)
            {
                range = "Units: 1 to 9";
                n = rnd.Next(1, 10);
            }

            if (fullTenthsRadioButton.Checked == true)
            {
                range = "Full tenths: 10, 20, 30, 40, to 90";
                n = 10 * (rnd.Next(1, 10));
            }

            if (halfTenthsRadioButton.Checked == true)
            {
                range = "Half tenths: 1 to 99 not multiple of 10";
                n = (10 * (rnd.Next(1, 10))) + rnd.Next(1, 10);
            }

            if (fullHundredsRadioButton.Checked == true)
            {
                range = "Full hundreds: 100, 200, 300, 400, to 900";
                n = 100 * (rnd.Next(1, 10));
            }

            if (halfHundredsRadioButton.Checked == true)
            {
                range = "Half hundreds: 100 to 999 not multiple of 100";
                n = (100 * (rnd.Next(1, 10))) + (10 * (rnd.Next(1, 10))) + rnd.Next(1, 10);
            }

            rAndv.propRange = range;
            rAndv.propMyVal = n;
            return (rAndv);
        }

        private void teachMeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MessageBox.Show(language.langaugeName + " from 4th windows");
            int n = 0;
            string range = "";
            range = setRangeAndValue().propRange;
            n = setRangeAndValue().propMyVal;

            TeachMeNumbersForm ymof = new TeachMeNumbersForm();
            ymof.previousForm = this;
            ymof.language = this.language;
            //ymof.Text = language.teachNumbersMessage;
            ymof.propHidenValueLabel.Visible = false;
            ymof.propHiddenValueTextBox.Visible = false;
            setLearnForm(ymof, range, n);
            ymof.propNumberValueTextBox.Enabled = false;
            ymof.propItonTextLabel.Text = this.language.langaugeName +"'s text  /  Texte en "+this.language.langaugeName ;

            if (readOrWriteOrHearTextBox.Text == "hearing")
            {
                 

               
                ymof.propReadOrWriteOrHearTextBox.Text = "hearing";
               // ymof.propReplayTextBox.Visible = true;
                RangeAndValue rAndv = new RangeAndValue();
                rAndv.propRange = range;
                rAndv.propMyVal = n;
                rAndv.language = this.language;
                Number numb = null;
                numb = rAndv.generatedNumber();
                //numb=rAndv.
                ymof.propmsgBoxLabel.Text = numb.lang();
                ymof.propmsgBoxLabel2.Text = n.ToString();
                ymof.propNumberValueTextBox.Text = "";
               ymof.propItonTextLabel.Visible = false;
                ymof.propItonTextTextBox.Visible = false;
                ymof.propNumberValueTextBox.Enabled = true;
                ymof.propHiddenValueTextBox.Text = n.ToString();

                ymof.propHiddenOldValueTextBox.Text = n.ToString();
                ymof.timer = new Timer();
                ymof.timer.Tick += delegate
                {
                    numb.play(true);
                    //var del=  Task.Delay(2000);
                    Task.Delay(1000).Wait();
                    //await del;
                };
               // ymof.timer.
                ymof.timer.Start();
                ymof.propItonTextTextBox.Enabled = false;
            }

            if (readOrWriteOrHearTextBox.Text == "reading")
            {
                ymof.propReadOrWriteOrHearTextBox.Text = "reading";
               // ymof.propReplayTextBox.Visible = false;
                RangeAndValue rAndv = new RangeAndValue();
                ymof.propbtnNextNumber.Visible = false;
                rAndv.language = this.language;
                rAndv.propRange = range;
                rAndv.propMyVal = n;
                Number numb = null;
                numb = rAndv.generatedNumber();

                ymof.propNumberValueTextBox.Text = "";
                ymof.propNumberValueTextBox.Enabled = true;
                ymof.propHiddenValueTextBox.Text = n.ToString();
                ymof.propItonTextTextBox.Text = numb.lang();
                ymof.propItonTextTextBox.Enabled = false;
            }

            if (readOrWriteOrHearTextBox.Text == "writing")
            {
                ymof.propReadOrWriteOrHearTextBox.Text = "writing";
                ymof.propbtnNextNumber.Visible = false;
               // ymof.propReplayTextBox.Visible = false;
            }

            if (readOrWriteOrHearTextBox.Text == "reading")
            {
                ymof.putNmberDown();
                ymof.propNumberValueTextBox.Select();
            }
            if (readOrWriteOrHearTextBox.Text == "writing")
            {
                ymof.putTextDown();
                ymof.propItonTextTextBox.Select();
            }

            ymof.propReadOrWriteOrHearTextBox.Hide();
            ymof.propReadOrWriteOrHearLabel.Hide();
            ymof.propNumberRangeLabel.Hide();
            ymof.propNumberRangeTextBox.Hide();
           // ymof.Hide();
            ymof.Show();
        }

        private void testMeButton_Click(object sender, EventArgs e)
        {
            int n = 0;
            string range = "";
            range = setRangeAndValue().propRange;
            n = setRangeAndValue().propMyVal;

            TestMeNumbersForm vmnof = new TestMeNumbersForm();
            vmnof.language = this.language;
           // vmnof.Text = this.language.testNumbersMessage;
            vmnof.propHidenValueLabel.Visible = false;
            vmnof.propHiddenValueTextBox.Visible = false;
            setTeachForm(vmnof, range, n);
            vmnof.propNumberValueTextBox.Enabled = false;
           

            if (readOrWriteOrHearTextBox.Text == "hearing")
            {
                vmnof.propReadOrWriteOrHearTextBox.Text = "hearing";
                //vmnof.propReplayTextBox.Visible = true;
                RangeAndValue rAndv = new RangeAndValue();
                rAndv.language = this.language;
                rAndv.propRange = range;
                rAndv.propMyVal = n;
                Number numb = null;
                numb = rAndv.generatedNumber();
                vmnof.propItonTextTextBox.Visible = false;
                vmnof.propItonTextLabel.Visible = false;
                vmnof.propNumberValueTextBox.Text = "";
                vmnof.propNumberValueTextBox.Enabled = true;
                vmnof.propHiddenValueTextBox.Text = n.ToString();
               
                vmnof.timer = new Timer();
                vmnof.timer.Start();
                vmnof.timer.Tick += delegate
                {
                   numb.play(true);
                   Task.Delay(1000).Wait();
                };
               
                vmnof.propItonTextTextBox.Enabled = false;
               

            }

            if (readOrWriteOrHearTextBox.Text == "reading")
            {
                vmnof.propReadOrWriteOrHearTextBox.Text = "reading";
                //vmnof.propReplayTextBox.Visible = false;
                RangeAndValue rAndv = new RangeAndValue();
                rAndv.language = this.language;
                rAndv.propRange = range;
                rAndv.propMyVal = n;
                Number numb = null;
                numb = rAndv.generatedNumber();

                vmnof.propNumberValueTextBox.Text = "";
                vmnof.propNumberValueTextBox.Enabled = true;
                vmnof.propHiddenValueTextBox.Text = n.ToString();
                vmnof.propItonTextTextBox.Text = numb.lang();
                vmnof.propItonTextTextBox.Enabled = false;

            }

            if (readOrWriteOrHearTextBox.Text == "writing")
            {
                vmnof.propReadOrWriteOrHearTextBox.Text = "writing";
                //vmnof.propReplayTextBox.Visible = false;
            }

            if ( (readOrWriteOrHearTextBox.Text == "reading") || (readOrWriteOrHearTextBox.Text == "hearing"))
            {
                vmnof.putNmberDown();
                vmnof.propNumberValueTextBox.Select();
            }
            if (readOrWriteOrHearTextBox.Text == "writing")
            {
                vmnof.putTextDown();
                vmnof.propItonTextTextBox.Select();
            }
            vmnof.propReadOrWriteOrHearTextBox.Hide();
            vmnof.propReadOrWriteOrHearLabel.Hide();
            vmnof.propNumberRangeLabel.Hide();
            vmnof.propNumberRangeTextBox.Hide();
            vmnof.previousForm = this;
            this.Hide();
            vmnof.Show();
        }

        private void TilItonForm_Load(object sender, EventArgs e)
        {

        }

        private void ChooseRangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ChooseHearReadWriteForm readWriteForm = new ChooseHearReadWriteForm();
            //readWriteForm.language = this.language; 
            //readWriteForm.Show();
            previousForm.Show();
        }
    }
}
