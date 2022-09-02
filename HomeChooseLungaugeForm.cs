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
    public partial class HomeChooseLungaugeForm : Form
    {
        public HomeChooseLungaugeForm()
        {
            InitializeComponent();
        }

        private void HomeChooseLungaugeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NaturalLanguage nl = new NaturalLanguage();
            if (rdbSwati.Checked == true)
            {
                nl.langaugeName = "Swati";
                nl.welcomeMessage = "Amagama noma tinombolo?";
                nl.taskChoiceMessage = "ukubhala , ukufundza noma ukutwa";
                nl.rangeChoiceMessage = "khetha tinombolo";
                nl.teachNumbersMessage = "Ngifundise tinombolo";
                nl.testNumbersMessage = "Ngihlole tinombolo";
                nl.rangeVerbMessage = "Imaphi Amagama?";

                //  nl.teachWordsMessage

            }
            if (rdbZulu.Checked == true)
            {
                nl.langaugeName = "Zulu";
                nl.welcomeMessage = "Izinombolo noma Amagama ?";
                nl.taskChoiceMessage = "Ufuna ukubhala, Ukufunda noma Ukulalela?";
                nl.rangeChoiceMessage = "Khetha uhla lwezinombolo";
                nl.teachNumbersMessage = "Khetha uhla lwezinombolo";
                nl.testNumbersMessage= "Ngihlole Ngezinombolo";
                nl.rangeVerbMessage = "Kuwaphi amagama?";
                // nl.teachWordsMessage
            }
            if (rdbMashi.Checked == true)
            {
                nl.langaugeName = "Mashi";
                nl.welcomeMessage = "Enumero erhi Izino?";
                nl.taskChoiceMessage = "Ukuandika, Ukusoma erhi Ukuyunva? ";
                nl.teachNumbersMessage="Ochagule enumero yawe";
                nl.testNumbersMessage= "ongiphime ama numero";
                nl.rangeVerbMessage = "Izino liphi ";
            }
            if (rdbIgbo.Checked == true)
            {
                nl.langaugeName = "Igbo";
                nl.welcomeMessage = "Okwu ma o bu nomba?";
                nl.taskChoiceMessage = "Guo, dee ma o bu guo?";
                nl.teachNumbersMessage = "Horo nomba gi";
                nl.testNumbersMessage = "Nwale m";
                nl.rangeVerbMessage = "Kuzie m";
                // nl.teachWordsMessage
            }
            if (rdbLingala.Checked == true)
            {
                nl.langaugeName = "Lingala";
                nl.welcomeMessage = "Numero ou Maloba?";
                nl.taskChoiceMessage = "koma tanga yoka?";
                nl.teachNumbersMessage = "Pona numero ";
                nl.testNumbersMessage = "Tuna ngai";
                nl.rangeVerbMessage="Maloba nini?";
            }
            if (rdbIton.Checked == true)
            {
                nl.langaugeName = "Iton";
                nl.welcomeMessage = "Hello its Iton";
                nl.taskChoiceMessage = "koma tanga yoka?";
                nl.teachNumbersMessage = "Pona numero ";
                nl.testNumbersMessage = "Tuna ngai";
                nl.rangeVerbMessage = "Maloba nini?";
            }
            if (rdbBasaa.Checked == true)
            {
                nl.langaugeName = "Basaa";
                nl.welcomeMessage = "Hello its Basaa";
                nl.taskChoiceMessage = "koma tanga yoka?";
                nl.teachNumbersMessage = "Pona numero ";
                nl.testNumbersMessage = "Tuna ngai";
                nl.rangeVerbMessage = "Maloba nini?";
            }
            //MessageBox.Show(nl.langaugeName + " from 1ST window" );
            ChooseNumberOrWordsForm fm = new ChooseNumberOrWordsForm();
            fm.previousForm = this;
            //fm.Text = nl.welcomeMessage;
            fm.language = nl;
            fm.Show();
        }

        private void rdbIton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
