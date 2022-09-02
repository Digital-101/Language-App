using System.Windows.Forms;
namespace kasuka
{
    partial class TeachMeNumbersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachMeNumbersForm));
            this.rangeLabel = new System.Windows.Forms.Label();
            this.numberValueTextBox = new System.Windows.Forms.TextBox();
            this.numberValueLabel = new System.Windows.Forms.Label();
            this.assessMeButton = new System.Windows.Forms.Button();
            this.itonTextLabel = new System.Windows.Forms.Label();
            this.itonTextTextBox = new System.Windows.Forms.TextBox();
            this.numberRangeTextBox = new System.Windows.Forms.TextBox();
            this.testMeAgainButton = new System.Windows.Forms.Button();
            this.readOrWriteOrHearLabel = new System.Windows.Forms.Label();
            this.readOrWriteOrHearTextBox = new System.Windows.Forms.TextBox();
            this.hidenValueLabel = new System.Windows.Forms.Label();
            this.hiddenValueTextBox = new System.Windows.Forms.TextBox();
            this.msgBoxLabel = new System.Windows.Forms.Label();
            this.msgBoxLabel2 = new System.Windows.Forms.Label();
            this.hiddenOldValueLabel = new System.Windows.Forms.Label();
            this.hiddenOldValueTextBox = new System.Windows.Forms.TextBox();
            this.btnNextNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeLabel.Location = new System.Drawing.Point(7, 132);
            this.rangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(87, 17);
            this.rangeLabel.TabIndex = 0;
            this.rangeLabel.Text = "NumbRange";
            // 
            // numberValueTextBox
            // 
            this.numberValueTextBox.BackColor = System.Drawing.Color.Gold;
            this.numberValueTextBox.Enabled = false;
            this.numberValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberValueTextBox.ForeColor = System.Drawing.Color.Black;
            this.numberValueTextBox.Location = new System.Drawing.Point(150, 161);
            this.numberValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberValueTextBox.Name = "numberValueTextBox";
            this.numberValueTextBox.Size = new System.Drawing.Size(117, 23);
            this.numberValueTextBox.TabIndex = 1;
            this.numberValueTextBox.TextChanged += new System.EventHandler(this.numberValueTextBox_TextChanged);
            this.numberValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // numberValueLabel
            // 
            this.numberValueLabel.AutoSize = true;
            this.numberValueLabel.BackColor = System.Drawing.Color.Gold;
            this.numberValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberValueLabel.Location = new System.Drawing.Point(148, 142);
            this.numberValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberValueLabel.Name = "numberValueLabel";
            this.numberValueLabel.Size = new System.Drawing.Size(120, 17);
            this.numberValueLabel.TabIndex = 2;
            this.numberValueLabel.Text = "Number / Nombre";
            // 
            // assessMeButton
            // 
            this.assessMeButton.BackColor = System.Drawing.Color.Red;
            this.assessMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assessMeButton.Location = new System.Drawing.Point(6, 5);
            this.assessMeButton.Margin = new System.Windows.Forms.Padding(4);
            this.assessMeButton.Name = "assessMeButton";
            this.assessMeButton.Size = new System.Drawing.Size(176, 102);
            this.assessMeButton.TabIndex = 3;
            this.assessMeButton.Text = "Check my answer\r\nVerifie ma réponse";
            this.assessMeButton.UseVisualStyleBackColor = false;
            this.assessMeButton.Visible = false;
            this.assessMeButton.Click += new System.EventHandler(this.assessMeButton_Click);
            // 
            // itonTextLabel
            // 
            this.itonTextLabel.AutoSize = true;
            this.itonTextLabel.BackColor = System.Drawing.Color.Gold;
            this.itonTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itonTextLabel.Location = new System.Drawing.Point(121, 198);
            this.itonTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itonTextLabel.Name = "itonTextLabel";
            this.itonTextLabel.Size = new System.Drawing.Size(173, 17);
            this.itonTextLabel.TabIndex = 4;
            this.itonTextLabel.Text = "Iton\'s text  /  Texte en Iton ";
            // 
            // itonTextTextBox
            // 
            this.itonTextTextBox.BackColor = System.Drawing.Color.Gold;
            this.itonTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itonTextTextBox.ForeColor = System.Drawing.Color.Black;
            this.itonTextTextBox.Location = new System.Drawing.Point(4, 216);
            this.itonTextTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itonTextTextBox.Name = "itonTextTextBox";
            this.itonTextTextBox.Size = new System.Drawing.Size(406, 23);
            this.itonTextTextBox.TabIndex = 5;
            this.itonTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // numberRangeTextBox
            // 
            this.numberRangeTextBox.Enabled = false;
            this.numberRangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberRangeTextBox.Location = new System.Drawing.Point(293, 137);
            this.numberRangeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberRangeTextBox.Name = "numberRangeTextBox";
            this.numberRangeTextBox.Size = new System.Drawing.Size(117, 23);
            this.numberRangeTextBox.TabIndex = 6;
            // 
            // testMeAgainButton
            // 
            this.testMeAgainButton.BackColor = System.Drawing.Color.Black;
            this.testMeAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMeAgainButton.ForeColor = System.Drawing.Color.Red;
            this.testMeAgainButton.Location = new System.Drawing.Point(232, 6);
            this.testMeAgainButton.Margin = new System.Windows.Forms.Padding(4);
            this.testMeAgainButton.Name = "testMeAgainButton";
            this.testMeAgainButton.Size = new System.Drawing.Size(178, 101);
            this.testMeAgainButton.TabIndex = 7;
            this.testMeAgainButton.Text = "Teach me again\r\nEnseigne moi encore";
            this.testMeAgainButton.UseVisualStyleBackColor = false;
            this.testMeAgainButton.Visible = false;
            this.testMeAgainButton.Click += new System.EventHandler(this.testMeAgainButton_Click);
            // 
            // readOrWriteOrHearLabel
            // 
            this.readOrWriteOrHearLabel.AutoSize = true;
            this.readOrWriteOrHearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOrWriteOrHearLabel.Location = new System.Drawing.Point(6, 160);
            this.readOrWriteOrHearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readOrWriteOrHearLabel.Name = "readOrWriteOrHearLabel";
            this.readOrWriteOrHearLabel.Size = new System.Drawing.Size(138, 17);
            this.readOrWriteOrHearLabel.TabIndex = 8;
            this.readOrWriteOrHearLabel.Text = "ReadOrWriteOrHear";
            // 
            // readOrWriteOrHearTextBox
            // 
            this.readOrWriteOrHearTextBox.Enabled = false;
            this.readOrWriteOrHearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOrWriteOrHearTextBox.Location = new System.Drawing.Point(40, 187);
            this.readOrWriteOrHearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.readOrWriteOrHearTextBox.Name = "readOrWriteOrHearTextBox";
            this.readOrWriteOrHearTextBox.Size = new System.Drawing.Size(58, 23);
            this.readOrWriteOrHearTextBox.TabIndex = 9;
            // 
            // hidenValueLabel
            // 
            this.hidenValueLabel.AutoSize = true;
            this.hidenValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidenValueLabel.Location = new System.Drawing.Point(337, 164);
            this.hidenValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hidenValueLabel.Name = "hidenValueLabel";
            this.hidenValueLabel.Size = new System.Drawing.Size(73, 17);
            this.hidenValueLabel.TabIndex = 10;
            this.hidenValueLabel.Text = "HiddenVal";
            // 
            // hiddenValueTextBox
            // 
            this.hiddenValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenValueTextBox.Location = new System.Drawing.Point(328, 185);
            this.hiddenValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hiddenValueTextBox.Name = "hiddenValueTextBox";
            this.hiddenValueTextBox.Size = new System.Drawing.Size(82, 23);
            this.hiddenValueTextBox.TabIndex = 11;
            this.hiddenValueTextBox.TextChanged += new System.EventHandler(this.hiddenValueTextBox_TextChanged);
            // 
            // msgBoxLabel
            // 
            this.msgBoxLabel.AutoSize = true;
            this.msgBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBoxLabel.Location = new System.Drawing.Point(1, 12);
            this.msgBoxLabel.Name = "msgBoxLabel";
            this.msgBoxLabel.Size = new System.Drawing.Size(612, 26);
            this.msgBoxLabel.TabIndex = 12;
            this.msgBoxLabel.Text = "................................................................................." +
    "...................";
            this.msgBoxLabel.Click += new System.EventHandler(this.msgBoxLabel_Click);
            // 
            // msgBoxLabel2
            // 
            this.msgBoxLabel2.AutoSize = true;
            this.msgBoxLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBoxLabel2.Location = new System.Drawing.Point(5, 73);
            this.msgBoxLabel2.Name = "msgBoxLabel2";
            this.msgBoxLabel2.Size = new System.Drawing.Size(612, 26);
            this.msgBoxLabel2.TabIndex = 13;
            this.msgBoxLabel2.Text = "................................................................................." +
    "...................";
            this.msgBoxLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.msgBoxLabel2.Click += new System.EventHandler(this.msgBoxLabel2_Click);
            // 
            // hiddenOldValueLabel
            // 
            this.hiddenOldValueLabel.AutoSize = true;
            this.hiddenOldValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenOldValueLabel.Location = new System.Drawing.Point(13, 114);
            this.hiddenOldValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hiddenOldValueLabel.Name = "hiddenOldValueLabel";
            this.hiddenOldValueLabel.Size = new System.Drawing.Size(95, 17);
            this.hiddenOldValueLabel.TabIndex = 32;
            this.hiddenOldValueLabel.Text = "HiddenOldVal";
            this.hiddenOldValueLabel.Visible = false;
            // 
            // hiddenOldValueTextBox
            // 
            this.hiddenOldValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenOldValueTextBox.Location = new System.Drawing.Point(290, 111);
            this.hiddenOldValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hiddenOldValueTextBox.Name = "hiddenOldValueTextBox";
            this.hiddenOldValueTextBox.Size = new System.Drawing.Size(117, 23);
            this.hiddenOldValueTextBox.TabIndex = 33;
            this.hiddenOldValueTextBox.Visible = false;
            // 
            // btnNextNumber
            // 
            this.btnNextNumber.BackColor = System.Drawing.Color.Black;
            this.btnNextNumber.ForeColor = System.Drawing.Color.Red;
            this.btnNextNumber.Location = new System.Drawing.Point(140, 142);
            this.btnNextNumber.Name = "btnNextNumber";
            this.btnNextNumber.Size = new System.Drawing.Size(143, 42);
            this.btnNextNumber.TabIndex = 34;
            this.btnNextNumber.Text = "New number\r\nNouveau nombre";
            this.btnNextNumber.UseVisualStyleBackColor = false;
            this.btnNextNumber.Click += new System.EventHandler(this.buttonNextnumber_Click);
            // 
            // TeachMeNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(465, 241);
            this.Controls.Add(this.btnNextNumber);
            this.Controls.Add(this.hiddenOldValueTextBox);
            this.Controls.Add(this.hiddenOldValueLabel);
            this.Controls.Add(this.msgBoxLabel2);
            this.Controls.Add(this.msgBoxLabel);
            this.Controls.Add(this.hiddenValueTextBox);
            this.Controls.Add(this.hidenValueLabel);
            this.Controls.Add(this.readOrWriteOrHearTextBox);
            this.Controls.Add(this.readOrWriteOrHearLabel);
            this.Controls.Add(this.testMeAgainButton);
            this.Controls.Add(this.numberRangeTextBox);
            this.Controls.Add(this.itonTextTextBox);
            this.Controls.Add(this.itonTextLabel);
            this.Controls.Add(this.assessMeButton);
            this.Controls.Add(this.numberValueLabel);
            this.Controls.Add(this.numberValueTextBox);
            this.Controls.Add(this.rangeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeachMeNumbersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "learning Numbers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeachMeNumbersForm_FormClosing);
            this.Load += new System.EventHandler(this.VeMaNkatOtillForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.TextBox numberValueTextBox;
        private System.Windows.Forms.Label numberValueLabel;
        private System.Windows.Forms.Button assessMeButton;
        private System.Windows.Forms.Label itonTextLabel;
        private System.Windows.Forms.TextBox itonTextTextBox;
        private System.Windows.Forms.TextBox numberRangeTextBox;
        private System.Windows.Forms.Button testMeAgainButton;
        private System.Windows.Forms.Label readOrWriteOrHearLabel;
        private System.Windows.Forms.TextBox readOrWriteOrHearTextBox;
        private System.Windows.Forms.Label hidenValueLabel;
        private System.Windows.Forms.TextBox hiddenValueTextBox;
        private System.Windows.Forms.Label msgBoxLabel;
        private System.Windows.Forms.Label msgBoxLabel2;
        private System.Windows.Forms.Label hiddenOldValueLabel;
        private System.Windows.Forms.TextBox hiddenOldValueTextBox;
        private Button btnNextNumber;

        public System.Windows.Forms.TextBox propHiddenOldValueTextBox
        {
            set { hiddenOldValueTextBox = value; }
            get { return hiddenOldValueTextBox; }
        }

        public System.Windows.Forms.TextBox propNumberRangeTextBox
        {
            set { numberRangeTextBox = value; }
            get { return numberRangeTextBox; }
        }

        public System.Windows.Forms.Label propNumberRangeLabel
        {
            set { rangeLabel = value; }
            get { return rangeLabel; }
        }

        public System.Windows.Forms.TextBox propNumberValueTextBox
        {
            set { numberValueTextBox = value; }
            get { return numberValueTextBox; }

        }

        public System.Windows.Forms.TextBox propReadOrWriteOrHearTextBox
        {
            set { readOrWriteOrHearTextBox = value; }
            get { return readOrWriteOrHearTextBox; }
        }

        public System.Windows.Forms.Label propReadOrWriteOrHearLabel
        {
            set { readOrWriteOrHearLabel = value; }
            get { return readOrWriteOrHearLabel; }
        }

        public System.Windows.Forms.TextBox propHiddenValueTextBox
        {
            set { hiddenValueTextBox = value; }
            get { return hiddenValueTextBox; }
        }

        public System.Windows.Forms.Label propHidenValueLabel
        {
            set { hidenValueLabel = value; }
            get { return hidenValueLabel; }
        }

        public System.Windows.Forms.TextBox propItonTextTextBox
        {
            set { itonTextTextBox = value; }
            get { return itonTextTextBox;  }
        }
        //public System.Windows.Forms.Button propReplayTextBox
        //{
        //    set { replayButton = value; }
        //    get { return replayButton; }
        //}
       public System.Windows.Forms.Label propmsgBoxLabel
        {
            set { msgBoxLabel = value; }
            get { return msgBoxLabel; }
        }
       public Button propbtnNextNumber
        {
            set {btnNextNumber = value; }
            get { return btnNextNumber; }
        }
        public System.Windows.Forms.Label propmsgBoxLabel2
        {
            set { msgBoxLabel2 = value; }
            get { return msgBoxLabel2; }
        }
        public System.Windows.Forms.Label propItonTextLabel
        {

            set { itonTextLabel = value; }
            get { return itonTextLabel; }
        }
        public NaturalLanguage language { get; set; }
        public Timer timer { get; set; }
        public ChooseRangeForm previousForm { get; set; }

    }
}