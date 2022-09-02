using System.Windows.Forms;

namespace kasuka
{
    partial class ChooseRangeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseRangeForm));
            this.teachMeButton = new System.Windows.Forms.Button();
            this.testMeButton = new System.Windows.Forms.Button();
            this.numberRangeChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.halfHundredsRadioButton = new System.Windows.Forms.RadioButton();
            this.fullHundredsRadioButton = new System.Windows.Forms.RadioButton();
            this.halfTenthsRadioButton = new System.Windows.Forms.RadioButton();
            this.fullTenthsRadioButton = new System.Windows.Forms.RadioButton();
            this.unitsRadioButton = new System.Windows.Forms.RadioButton();
            this.readOrWriteOrHearLabel = new System.Windows.Forms.Label();
            this.readOrWriteOrHearTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numberRangeChoiceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teachMeButton
            // 
            this.teachMeButton.BackColor = System.Drawing.Color.Black;
            this.teachMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachMeButton.ForeColor = System.Drawing.Color.Red;
            this.teachMeButton.Location = new System.Drawing.Point(5, 209);
            this.teachMeButton.Margin = new System.Windows.Forms.Padding(4);
            this.teachMeButton.Name = "teachMeButton";
            this.teachMeButton.Size = new System.Drawing.Size(126, 52);
            this.teachMeButton.TabIndex = 1;
            this.teachMeButton.Text = "Teach me\r\nEnseigne moi";
            this.teachMeButton.UseVisualStyleBackColor = false;
            this.teachMeButton.Click += new System.EventHandler(this.teachMeButton_Click);
            // 
            // testMeButton
            // 
            this.testMeButton.BackColor = System.Drawing.Color.Red;
            this.testMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMeButton.ForeColor = System.Drawing.Color.Black;
            this.testMeButton.Location = new System.Drawing.Point(209, 208);
            this.testMeButton.Margin = new System.Windows.Forms.Padding(4);
            this.testMeButton.Name = "testMeButton";
            this.testMeButton.Size = new System.Drawing.Size(130, 52);
            this.testMeButton.TabIndex = 2;
            this.testMeButton.Text = "Test me\r\nTeste moi";
            this.testMeButton.UseVisualStyleBackColor = false;
            this.testMeButton.Click += new System.EventHandler(this.testMeButton_Click);
            // 
            // numberRangeChoiceGroupBox
            // 
            this.numberRangeChoiceGroupBox.BackColor = System.Drawing.Color.Gold;
            this.numberRangeChoiceGroupBox.Controls.Add(this.halfHundredsRadioButton);
            this.numberRangeChoiceGroupBox.Controls.Add(this.fullHundredsRadioButton);
            this.numberRangeChoiceGroupBox.Controls.Add(this.halfTenthsRadioButton);
            this.numberRangeChoiceGroupBox.Controls.Add(this.fullTenthsRadioButton);
            this.numberRangeChoiceGroupBox.Controls.Add(this.unitsRadioButton);
            this.numberRangeChoiceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberRangeChoiceGroupBox.Location = new System.Drawing.Point(7, 25);
            this.numberRangeChoiceGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberRangeChoiceGroupBox.Name = "numberRangeChoiceGroupBox";
            this.numberRangeChoiceGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.numberRangeChoiceGroupBox.Size = new System.Drawing.Size(329, 173);
            this.numberRangeChoiceGroupBox.TabIndex = 3;
            this.numberRangeChoiceGroupBox.TabStop = false;
            this.numberRangeChoiceGroupBox.Text = "RANGES   /  GAMMES";
            // 
            // halfHundredsRadioButton
            // 
            this.halfHundredsRadioButton.AutoSize = true;
            this.halfHundredsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfHundredsRadioButton.Location = new System.Drawing.Point(10, 140);
            this.halfHundredsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.halfHundredsRadioButton.Name = "halfHundredsRadioButton";
            this.halfHundredsRadioButton.Size = new System.Drawing.Size(306, 21);
            this.halfHundredsRadioButton.TabIndex = 4;
            this.halfHundredsRadioButton.Text = "101, 102, ..., 109, 111, 112, ..., 119, ...., 999";
            this.halfHundredsRadioButton.UseVisualStyleBackColor = true;
            // 
            // fullHundredsRadioButton
            // 
            this.fullHundredsRadioButton.AutoSize = true;
            this.fullHundredsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullHundredsRadioButton.Location = new System.Drawing.Point(10, 111);
            this.fullHundredsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.fullHundredsRadioButton.Name = "fullHundredsRadioButton";
            this.fullHundredsRadioButton.Size = new System.Drawing.Size(214, 21);
            this.fullHundredsRadioButton.TabIndex = 3;
            this.fullHundredsRadioButton.Text = "100,  200,  300, ....,  800, 900";
            this.fullHundredsRadioButton.UseVisualStyleBackColor = true;
            // 
            // halfTenthsRadioButton
            // 
            this.halfTenthsRadioButton.AutoSize = true;
            this.halfTenthsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfTenthsRadioButton.Location = new System.Drawing.Point(10, 81);
            this.halfTenthsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.halfTenthsRadioButton.Name = "halfTenthsRadioButton";
            this.halfTenthsRadioButton.Size = new System.Drawing.Size(250, 21);
            this.halfTenthsRadioButton.TabIndex = 2;
            this.halfTenthsRadioButton.Text = "11,  12, ... 19, 21, 22, ..., 29, ...  99 ";
            this.halfTenthsRadioButton.UseVisualStyleBackColor = true;
            // 
            // fullTenthsRadioButton
            // 
            this.fullTenthsRadioButton.AutoSize = true;
            this.fullTenthsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullTenthsRadioButton.Location = new System.Drawing.Point(10, 52);
            this.fullTenthsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.fullTenthsRadioButton.Name = "fullTenthsRadioButton";
            this.fullTenthsRadioButton.Size = new System.Drawing.Size(190, 21);
            this.fullTenthsRadioButton.TabIndex = 1;
            this.fullTenthsRadioButton.Text = "10,  20,  30, 40, ..., 80, 90";
            this.fullTenthsRadioButton.UseVisualStyleBackColor = true;
            // 
            // unitsRadioButton
            // 
            this.unitsRadioButton.AutoSize = true;
            this.unitsRadioButton.Checked = true;
            this.unitsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsRadioButton.Location = new System.Drawing.Point(9, 23);
            this.unitsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.unitsRadioButton.Name = "unitsRadioButton";
            this.unitsRadioButton.Size = new System.Drawing.Size(146, 21);
            this.unitsRadioButton.TabIndex = 0;
            this.unitsRadioButton.TabStop = true;
            this.unitsRadioButton.Text = "1, 2, 3, 4, ....., 8, 9 ";
            this.unitsRadioButton.UseVisualStyleBackColor = true;
            // 
            // readOrWriteOrHearLabel
            // 
            this.readOrWriteOrHearLabel.AutoSize = true;
            this.readOrWriteOrHearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOrWriteOrHearLabel.Location = new System.Drawing.Point(7, 4);
            this.readOrWriteOrHearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readOrWriteOrHearLabel.Name = "readOrWriteOrHearLabel";
            this.readOrWriteOrHearLabel.Size = new System.Drawing.Size(116, 17);
            this.readOrWriteOrHearLabel.TabIndex = 4;
            this.readOrWriteOrHearLabel.Text = "I am interested in";
            // 
            // readOrWriteOrHearTextBox
            // 
            this.readOrWriteOrHearTextBox.Enabled = false;
            this.readOrWriteOrHearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOrWriteOrHearTextBox.Location = new System.Drawing.Point(122, 1);
            this.readOrWriteOrHearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.readOrWriteOrHearTextBox.Name = "readOrWriteOrHearTextBox";
            this.readOrWriteOrHearTextBox.Size = new System.Drawing.Size(214, 23);
            this.readOrWriteOrHearTextBox.TabIndex = 5;
            // 
            // ChooseRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(346, 268);
            this.Controls.Add(this.readOrWriteOrHearTextBox);
            this.Controls.Add(this.readOrWriteOrHearLabel);
            this.Controls.Add(this.numberRangeChoiceGroupBox);
            this.Controls.Add(this.testMeButton);
            this.Controls.Add(this.teachMeButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseRangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose a Number";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseRangeForm_FormClosing);
            this.Load += new System.EventHandler(this.TilItonForm_Load);
            this.numberRangeChoiceGroupBox.ResumeLayout(false);
            this.numberRangeChoiceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button teachMeButton;
        private System.Windows.Forms.Button testMeButton;
        private System.Windows.Forms.GroupBox numberRangeChoiceGroupBox;
        private System.Windows.Forms.RadioButton fullTenthsRadioButton;
        private System.Windows.Forms.RadioButton unitsRadioButton;
        private System.Windows.Forms.RadioButton halfTenthsRadioButton;
        private System.Windows.Forms.RadioButton halfHundredsRadioButton;
        private System.Windows.Forms.RadioButton fullHundredsRadioButton;
        private System.Windows.Forms.Label readOrWriteOrHearLabel;
        private System.Windows.Forms.TextBox readOrWriteOrHearTextBox;
        private System.Windows.Forms.Timer timer1;

        public System.Windows.Forms.TextBox propReadOrWriteOrHearTextBox
        {
            set {readOrWriteOrHearTextBox = value; }
            get { return readOrWriteOrHearTextBox; }
        }

        public System.Windows.Forms.Label propReadOrWriteOrHearLabel
        {
            set { readOrWriteOrHearLabel = value; }
            get { return readOrWriteOrHearLabel; }
        }
        public System.Windows.Forms.RadioButton propfullTenthsRadioButton
        {
            set { fullTenthsRadioButton = value; }
            get { return fullTenthsRadioButton; }
        }
        public System.Windows.Forms.RadioButton propunitsRadioButton
        {
            set { unitsRadioButton = value; }
            get { return unitsRadioButton; }
        }
        public System.Windows.Forms.RadioButton prophalfTenthsRadioButton
        {
            set { halfTenthsRadioButton = value; }
            get { return halfTenthsRadioButton; }
        }
        public System.Windows.Forms.RadioButton prophalfHundredsRadioButton
        {
            set { halfHundredsRadioButton = value; }
            get { return halfHundredsRadioButton; }
        }
        public System.Windows.Forms.RadioButton propfullHundredsRadioButton
        {
            set { fullHundredsRadioButton = value; }
            get { return fullHundredsRadioButton; }
        }

        // private System.Windows.Forms.RadioButton fullTenthsRadioButton;
        //private System.Windows.Forms.RadioButton unitsRadioButton;
        //private System.Windows.Forms.RadioButton halfTenthsRadioButton;
        // private System.Windows.Forms.RadioButton halfHundredsRadioButton;
       // private System.Windows.Forms.RadioButton fullHundredsRadioButton;


        public NaturalLanguage language { get; set; }
        public Form previousForm { get; set; }


    }
}