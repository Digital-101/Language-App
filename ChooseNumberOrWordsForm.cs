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
    public partial class ChooseNumberOrWordsForm : Form
    {
        public ChooseNumberOrWordsForm()
        {
            InitializeComponent();
        }

        private void tilItonButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NaturalLanguage nl = new NaturalLanguage();
            nl.langaugeName = this.Text;
            nl.welcomeMessage = this.Text;

            if (numbersRadioButton.Checked == true)
            {
                // NaturalLanguage nl = new NaturalLanguage();
               // MessageBox.Show(language.langaugeName + " from 2nd windows");
                ChooseHearReadWriteForm chcinif = new ChooseHearReadWriteForm();
                chcinif.previousForm = this;
                chcinif.language = this.language;
               // chcinif.Text = this.language.rangeChoiceMessage;
                chcinif.propWriteRadioButton.Text = "Write in "+this.language.langaugeName+" / Ecrire en "+ this.language.langaugeName;
                chcinif.propReadRadioButton.Text = "Read in " + this.language.langaugeName + "  / Lire en " + this.language.langaugeName;
                chcinif.propHearRadioButton.Text = "Hear "+ this.language.langaugeName+"  / Ecouter l' "+ this.language.langaugeName;
                chcinif.Show();
            }
            if (wordsRadioButton.Checked == true)
            {
                HomeChooseLungaugeForm hl = new HomeChooseLungaugeForm();
                if (language.langaugeName=="Zulu")
                {
                    Form1 bodyForm = new Form1();
                    bodyForm.previousForm = this;
                    bodyForm.language = this.language;
                    bodyForm.Show();
                }
                else
                {
                    MessageBox.Show("Learning Small sentences for " +language.langaugeName+ " is not yet available");
                }

                //ChooseVerbForm cvif = new ChooseVerbForm();
                               
                //cvif.language = this.language;
                //cvif.Text = language.rangeVerbMessage;
                //cvif.Show();
            }

        }

        private void ChooseNumberOrWordsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }
    }
}
