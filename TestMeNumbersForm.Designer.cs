using System.Windows.Forms;
namespace kasuka
{
    partial class TestMeNumbersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMeNumbersForm));
            this.rangeLabel = new System.Windows.Forms.Label();
            this.numberRangeTextBox = new System.Windows.Forms.TextBox();
            this.numberValueLabel = new System.Windows.Forms.Label();
            this.numberValueTextBox = new System.Windows.Forms.TextBox();
            this.itonTextLabel = new System.Windows.Forms.Label();
            this.itonTextTextBox = new System.Windows.Forms.TextBox();
            this.assessMeButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.testMeAgainButton = new System.Windows.Forms.Button();
            this.readOrWriteOrHearLabel = new System.Windows.Forms.Label();
            this.readOrWriteOrHearTextBox = new System.Windows.Forms.TextBox();
            this.hidenValueLabel = new System.Windows.Forms.Label();
            this.hiddenValueTextBox = new System.Windows.Forms.TextBox();
            this.msgBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangeLabel.Location = new System.Drawing.Point(12, 111);
            this.rangeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(87, 17);
            this.rangeLabel.TabIndex = 1;
            this.rangeLabel.Text = "NumbRange";
            // 
            // numberRangeTextBox
            // 
            this.numberRangeTextBox.Enabled = false;
            this.numberRangeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberRangeTextBox.Location = new System.Drawing.Point(280, 110);
            this.numberRangeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberRangeTextBox.Name = "numberRangeTextBox";
            this.numberRangeTextBox.Size = new System.Drawing.Size(112, 23);
            this.numberRangeTextBox.TabIndex = 7;
            // 
            // numberValueLabel
            // 
            this.numberValueLabel.AutoSize = true;
            this.numberValueLabel.BackColor = System.Drawing.Color.Gold;
            this.numberValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberValueLabel.Location = new System.Drawing.Point(141, 141);
            this.numberValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberValueLabel.Name = "numberValueLabel";
            this.numberValueLabel.Size = new System.Drawing.Size(120, 17);
            this.numberValueLabel.TabIndex = 8;
            this.numberValueLabel.Text = "Number / Nombre";
            // 
            // numberValueTextBox
            // 
            this.numberValueTextBox.BackColor = System.Drawing.Color.Gold;
            this.numberValueTextBox.Enabled = false;
            this.numberValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberValueTextBox.ForeColor = System.Drawing.Color.Black;
            this.numberValueTextBox.Location = new System.Drawing.Point(141, 159);
            this.numberValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberValueTextBox.Name = "numberValueTextBox";
            this.numberValueTextBox.Size = new System.Drawing.Size(120, 23);
            this.numberValueTextBox.TabIndex = 9;
            this.numberValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // itonTextLabel
            // 
            this.itonTextLabel.AutoSize = true;
            this.itonTextLabel.BackColor = System.Drawing.Color.Gold;
            this.itonTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itonTextLabel.Location = new System.Drawing.Point(116, 193);
            this.itonTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itonTextLabel.Name = "itonTextLabel";
            this.itonTextLabel.Size = new System.Drawing.Size(169, 17);
            this.itonTextLabel.TabIndex = 10;
            this.itonTextLabel.Text = "Iton\'s text  /  Texte en Iton";
            // 
            // itonTextTextBox
            // 
            this.itonTextTextBox.BackColor = System.Drawing.Color.Gold;
            this.itonTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itonTextTextBox.ForeColor = System.Drawing.Color.Black;
            this.itonTextTextBox.Location = new System.Drawing.Point(9, 210);
            this.itonTextTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itonTextTextBox.Name = "itonTextTextBox";
            this.itonTextTextBox.Size = new System.Drawing.Size(383, 23);
            this.itonTextTextBox.TabIndex = 11;
            this.itonTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // assessMeButton
            // 
            this.assessMeButton.BackColor = System.Drawing.Color.Red;
            this.assessMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assessMeButton.Location = new System.Drawing.Point(10, 20);
            this.assessMeButton.Margin = new System.Windows.Forms.Padding(4);
            this.assessMeButton.Name = "assessMeButton";
            this.assessMeButton.Size = new System.Drawing.Size(128, 60);
            this.assessMeButton.TabIndex = 12;
            this.assessMeButton.Text = "Assess me\r\nCorrige moi";
            this.assessMeButton.UseVisualStyleBackColor = false;
            this.assessMeButton.Visible = false;
            this.assessMeButton.Click += new System.EventHandler(this.assessMeButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Gold;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(10, 86);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(87, 17);
            this.scoreLabel.TabIndex = 13;
            this.scoreLabel.Text = "Score / Note";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.BackColor = System.Drawing.Color.Gold;
            this.scoreTextBox.Enabled = false;
            this.scoreTextBox.ForeColor = System.Drawing.Color.Black;
            this.scoreTextBox.Location = new System.Drawing.Point(105, 82);
            this.scoreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(83, 23);
            this.scoreTextBox.TabIndex = 14;
            this.scoreTextBox.Text = "0";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Gold;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(215, 85);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(81, 17);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "Out of / Sur";
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.Color.Gold;
            this.totalTextBox.Enabled = false;
            this.totalTextBox.ForeColor = System.Drawing.Color.Black;
            this.totalTextBox.Location = new System.Drawing.Point(311, 82);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(81, 23);
            this.totalTextBox.TabIndex = 16;
            this.totalTextBox.Text = "0";
            // 
            // testMeAgainButton
            // 
            this.testMeAgainButton.BackColor = System.Drawing.Color.Black;
            this.testMeAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMeAgainButton.ForeColor = System.Drawing.Color.Red;
            this.testMeAgainButton.Location = new System.Drawing.Point(253, 19);
            this.testMeAgainButton.Margin = new System.Windows.Forms.Padding(4);
            this.testMeAgainButton.Name = "testMeAgainButton";
            this.testMeAgainButton.Size = new System.Drawing.Size(140, 61);
            this.testMeAgainButton.TabIndex = 17;
            this.testMeAgainButton.Text = "Test me again\r\nTeste moi encore";
            this.testMeAgainButton.UseVisualStyleBackColor = false;
            this.testMeAgainButton.Visible = false;
            this.testMeAgainButton.Click += new System.EventHandler(this.testMeAgainButton_Click);
            // 
            // readOrWriteOrHearLabel
            // 
            this.readOrWriteOrHearLabel.AutoSize = true;
            this.readOrWriteOrHearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOrWriteOrHearLabel.Location = new System.Drawing.Point(0, 136);
            this.readOrWriteOrHearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readOrWriteOrHearLabel.Name = "readOrWriteOrHearLabel";
            this.readOrWriteOrHearLabel.Size = new System.Drawing.Size(138, 17);
            this.readOrWriteOrHearLabel.TabIndex = 18;
            this.readOrWriteOrHearLabel.Text = "ReadOrWriteOrHear";
            // 
            // readOrWriteOrHearTextBox
            // 
            this.readOrWriteOrHearTextBox.Enabled = false;
            this.readOrWriteOrHearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOrWriteOrHearTextBox.Location = new System.Drawing.Point(13, 165);
            this.readOrWriteOrHearTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.readOrWriteOrHearTextBox.Name = "readOrWriteOrHearTextBox";
            this.readOrWriteOrHearTextBox.Size = new System.Drawing.Size(94, 23);
            this.readOrWriteOrHearTextBox.TabIndex = 19;
            // 
            // hidenValueLabel
            // 
            this.hidenValueLabel.AutoSize = true;
            this.hidenValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidenValueLabel.Location = new System.Drawing.Point(340, 137);
            this.hidenValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hidenValueLabel.Name = "hidenValueLabel";
            this.hidenValueLabel.Size = new System.Drawing.Size(53, 17);
            this.hidenValueLabel.TabIndex = 20;
            this.hidenValueLabel.Text = "Hidden";
            // 
            // hiddenValueTextBox
            // 
            this.hiddenValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenValueTextBox.Location = new System.Drawing.Point(301, 165);
            this.hiddenValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hiddenValueTextBox.Name = "hiddenValueTextBox";
            this.hiddenValueTextBox.Size = new System.Drawing.Size(92, 23);
            this.hiddenValueTextBox.TabIndex = 21;
            // 
            // msgBoxLabel
            // 
            this.msgBoxLabel.AutoSize = true;
            this.msgBoxLabel.Location = new System.Drawing.Point(5, 3);
            this.msgBoxLabel.Name = "msgBoxLabel";
            this.msgBoxLabel.Size = new System.Drawing.Size(388, 17);
            this.msgBoxLabel.TabIndex = 22;
            this.msgBoxLabel.Text = "................................................................................." +
    "..............";
            // 
            // TestMeNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(401, 234);
            this.Controls.Add(this.msgBoxLabel);
            this.Controls.Add(this.hiddenValueTextBox);
            this.Controls.Add(this.hidenValueLabel);
            this.Controls.Add(this.readOrWriteOrHearTextBox);
            this.Controls.Add(this.readOrWriteOrHearLabel);
            this.Controls.Add(this.testMeAgainButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.assessMeButton);
            this.Controls.Add(this.itonTextTextBox);
            this.Controls.Add(this.itonTextLabel);
            this.Controls.Add(this.numberValueTextBox);
            this.Controls.Add(this.numberValueLabel);
            this.Controls.Add(this.numberRangeTextBox);
            this.Controls.Add(this.rangeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestMeNumbersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testing Numbers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestMeNumbersForm_FormClosing);
            this.Load += new System.EventHandler(this.TestMeNumbersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.TextBox numberRangeTextBox;
        private System.Windows.Forms.Label numberValueLabel;
        private System.Windows.Forms.TextBox numberValueTextBox;
        private System.Windows.Forms.Label itonTextLabel;
        private System.Windows.Forms.TextBox itonTextTextBox;
        private System.Windows.Forms.Button assessMeButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button testMeAgainButton;
        private System.Windows.Forms.Label readOrWriteOrHearLabel;
        private System.Windows.Forms.TextBox readOrWriteOrHearTextBox;
        private System.Windows.Forms.Label hidenValueLabel;
        private System.Windows.Forms.TextBox hiddenValueTextBox;
        private System.Windows.Forms.Label msgBoxLabel;

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
            get { return itonTextTextBox; }
        }

        //public System.Windows.Forms.Button propReplayTextBox
        //{
        //    set { replayButton = value; }
        //    get { return replayButton; }
        //}
        public System.Windows.Forms.Label propItonTextLabel
        {
            set { itonTextLabel = value; }
            get { return itonTextLabel; }
        }
        public NaturalLanguage language { get; set; }
        public Timer timer { get; set; }
        public Form previousForm { get; set; }

    }
}