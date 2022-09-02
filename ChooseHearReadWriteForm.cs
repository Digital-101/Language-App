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
    public partial class ChooseHearReadWriteForm : Form
    {
        public ChooseHearReadWriteForm()
        {
            InitializeComponent();
            //writeRadioButton.Text = "Write in "+this.language.langaugeName+" / Ecrire en "+ this.language.langaugeName;
            //readRadioButton.Text = "Read in " + this.language.langaugeName + "  / Lire en " + this.language.langaugeName;
            //hearRadioButton.Text = "Hear "+ this.language.langaugeName+"  / Ecouter l' "+ this.language.langaugeName;

        }

        private void tilItonButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MessageBox.Show(language.langaugeName + " from 3rd window");
            ChooseRangeForm tNWF = new ChooseRangeForm();
            tNWF.previousForm = this;
            tNWF.language = this.language;

            //tNWF.Text = language.taskChoiceMessage;
            if (readRadioButton.Checked == true) { tNWF.propReadOrWriteOrHearTextBox.Text = "reading" ; }
            if (writeRadioButton.Checked == true) { tNWF.propReadOrWriteOrHearTextBox.Text = "writing"; }
            if (hearRadioButton.Checked == true) { tNWF.propReadOrWriteOrHearTextBox.Text = "hearing"; }
            tNWF.propReadOrWriteOrHearLabel.Hide();
            tNWF.propReadOrWriteOrHearTextBox.Hide();
            tNWF.Show();
        }

        private void ChooseHearReadWriteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Show();
        }
    }
}
