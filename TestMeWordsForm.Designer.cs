using System.Windows.Forms;

namespace kasuka
{
    partial class TestMeWordsForm
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
            this.assessMeButton = new System.Windows.Forms.Button();
            this.testMeAgainButton = new System.Windows.Forms.Button();
            this.msgBoxLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.itonTextLabel = new System.Windows.Forms.Label();
            this.englishOrFrenchTextTextBox = new System.Windows.Forms.TextBox();
            this.hidenValueLabel = new System.Windows.Forms.Label();
            this.hiddenValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // assessMeButton
            // 
            this.assessMeButton.BackColor = System.Drawing.Color.Red;
            this.assessMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assessMeButton.Location = new System.Drawing.Point(19, 23);
            this.assessMeButton.Margin = new System.Windows.Forms.Padding(4);
            this.assessMeButton.Name = "assessMeButton";
            this.assessMeButton.Size = new System.Drawing.Size(128, 60);
            this.assessMeButton.TabIndex = 13;
            this.assessMeButton.Text = "Assess me\r\nCorrige moi";
            this.assessMeButton.UseVisualStyleBackColor = false;
            this.assessMeButton.Visible = false;
            this.assessMeButton.Click += new System.EventHandler(this.assessMeButton_Click);
            // 
            // testMeAgainButton
            // 
            this.testMeAgainButton.BackColor = System.Drawing.Color.Black;
            this.testMeAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMeAgainButton.ForeColor = System.Drawing.Color.Red;
            this.testMeAgainButton.Location = new System.Drawing.Point(263, 22);
            this.testMeAgainButton.Margin = new System.Windows.Forms.Padding(4);
            this.testMeAgainButton.Name = "testMeAgainButton";
            this.testMeAgainButton.Size = new System.Drawing.Size(140, 61);
            this.testMeAgainButton.TabIndex = 18;
            this.testMeAgainButton.Text = "Test me again\r\nTeste moi encore";
            this.testMeAgainButton.UseVisualStyleBackColor = false;
            this.testMeAgainButton.Visible = false;
            this.testMeAgainButton.Click += new System.EventHandler(this.testMeAgainButton_Click);
            // 
            // msgBoxLabel
            // 
            this.msgBoxLabel.AutoSize = true;
            this.msgBoxLabel.Location = new System.Drawing.Point(18, 9);
            this.msgBoxLabel.Name = "msgBoxLabel";
            this.msgBoxLabel.Size = new System.Drawing.Size(385, 13);
            this.msgBoxLabel.TabIndex = 23;
            this.msgBoxLabel.Text = "................................................................................." +
    ".............................................";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Gold;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(22, 97);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(87, 17);
            this.scoreLabel.TabIndex = 24;
            this.scoreLabel.Text = "Score / Note";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.BackColor = System.Drawing.Color.Gold;
            this.scoreTextBox.Enabled = false;
            this.scoreTextBox.ForeColor = System.Drawing.Color.Black;
            this.scoreTextBox.Location = new System.Drawing.Point(114, 95);
            this.scoreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(83, 20);
            this.scoreTextBox.TabIndex = 25;
            this.scoreTextBox.Text = "0";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Gold;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(232, 95);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(81, 17);
            this.totalLabel.TabIndex = 26;
            this.totalLabel.Text = "Out of / Sur";
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.Color.Gold;
            this.totalTextBox.Enabled = false;
            this.totalTextBox.ForeColor = System.Drawing.Color.Black;
            this.totalTextBox.Location = new System.Drawing.Point(322, 94);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(81, 20);
            this.totalTextBox.TabIndex = 27;
            this.totalTextBox.Text = "0";
            // 
            // itonTextLabel
            // 
            this.itonTextLabel.AutoSize = true;
            this.itonTextLabel.BackColor = System.Drawing.Color.Gold;
            this.itonTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itonTextLabel.Location = new System.Drawing.Point(74, 189);
            this.itonTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itonTextLabel.Name = "itonTextLabel";
            this.itonTextLabel.Size = new System.Drawing.Size(258, 17);
            this.itonTextLabel.TabIndex = 29;
            this.itonTextLabel.Text = "English answer  /  Reponse en Francais";
            // 
            // englishOrFrenchTextTextBox
            // 
            this.englishOrFrenchTextTextBox.BackColor = System.Drawing.Color.Gold;
            this.englishOrFrenchTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishOrFrenchTextTextBox.ForeColor = System.Drawing.Color.Black;
            this.englishOrFrenchTextTextBox.Location = new System.Drawing.Point(16, 209);
            this.englishOrFrenchTextTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.englishOrFrenchTextTextBox.Name = "englishOrFrenchTextTextBox";
            this.englishOrFrenchTextTextBox.Size = new System.Drawing.Size(383, 23);
            this.englishOrFrenchTextTextBox.TabIndex = 30;
            this.englishOrFrenchTextTextBox.TextChanged += new System.EventHandler(this.englishOrFrenchTextTextBox_TextChanged);
            this.englishOrFrenchTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // hidenValueLabel
            // 
            this.hidenValueLabel.AutoSize = true;
            this.hidenValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidenValueLabel.Location = new System.Drawing.Point(20, 157);
            this.hidenValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hidenValueLabel.Name = "hidenValueLabel";
            this.hidenValueLabel.Size = new System.Drawing.Size(53, 17);
            this.hidenValueLabel.TabIndex = 31;
            this.hidenValueLabel.Text = "Hidden";
            // 
            // hiddenValueTextBox
            // 
            this.hiddenValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenValueTextBox.Location = new System.Drawing.Point(311, 157);
            this.hiddenValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hiddenValueTextBox.Name = "hiddenValueTextBox";
            this.hiddenValueTextBox.Size = new System.Drawing.Size(92, 23);
            this.hiddenValueTextBox.TabIndex = 32;
            // 
            // TestMeWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(409, 237);
            this.Controls.Add(this.hiddenValueTextBox);
            this.Controls.Add(this.hidenValueLabel);
            this.Controls.Add(this.englishOrFrenchTextTextBox);
            this.Controls.Add(this.itonTextLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.msgBoxLabel);
            this.Controls.Add(this.testMeAgainButton);
            this.Controls.Add(this.assessMeButton);
            this.Name = "TestMeWordsForm";
            this.Text = "Ngihlole Amagama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button assessMeButton;
        private System.Windows.Forms.Button testMeAgainButton;
        private System.Windows.Forms.Label msgBoxLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label itonTextLabel;
        private System.Windows.Forms.TextBox englishOrFrenchTextTextBox;
        private System.Windows.Forms.Label hidenValueLabel;
        private System.Windows.Forms.TextBox hiddenValueTextBox;

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
        public System.Windows.Forms.TextBox propEnglishOrFrenchTextTextBox
        {
            set { englishOrFrenchTextTextBox = value; }
            get { return englishOrFrenchTextTextBox; }
        }
        public NaturalLanguage language { get; set; }
        public Form previousForm { get; set; }
    }
}