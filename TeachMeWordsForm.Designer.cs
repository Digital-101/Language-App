using System.Windows.Forms;

namespace kasuka
{
    partial class TeachMeWordsForm
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
            this.replayButton = new System.Windows.Forms.Button();
            this.itonTextLabel = new System.Windows.Forms.Label();
            this.englishOrFrenchTextTextBox = new System.Windows.Forms.TextBox();
            this.assessMeButton = new System.Windows.Forms.Button();
            this.teachMeAgainButton = new System.Windows.Forms.Button();
            this.msgBoxLabel = new System.Windows.Forms.Label();
            this.msgBoxLabel2 = new System.Windows.Forms.Label();
            this.hidenValueLabel = new System.Windows.Forms.Label();
            this.hiddenValueTextBox = new System.Windows.Forms.TextBox();
            this.msgBoxLabel3 = new System.Windows.Forms.Label();
            this.hiddenOldValueLabel = new System.Windows.Forms.Label();
            this.hiddenOldValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // replayButton
            // 
            this.replayButton.BackColor = System.Drawing.Color.Black;
            this.replayButton.ForeColor = System.Drawing.Color.Red;
            this.replayButton.Location = new System.Drawing.Point(136, 108);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(143, 58);
            this.replayButton.TabIndex = 19;
            this.replayButton.Text = "New sentence\r\nNouvelle phrase";
            this.replayButton.UseVisualStyleBackColor = false;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // itonTextLabel
            // 
            this.itonTextLabel.AutoSize = true;
            this.itonTextLabel.BackColor = System.Drawing.Color.Gold;
            this.itonTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itonTextLabel.Location = new System.Drawing.Point(79, 171);
            this.itonTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itonTextLabel.Name = "itonTextLabel";
            this.itonTextLabel.Size = new System.Drawing.Size(258, 17);
            this.itonTextLabel.TabIndex = 20;
            this.itonTextLabel.Text = "English answer  /  Reponse en Francais";
            // 
            // englishOrFrenchTextTextBox
            // 
            this.englishOrFrenchTextTextBox.BackColor = System.Drawing.Color.Gold;
            this.englishOrFrenchTextTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishOrFrenchTextTextBox.ForeColor = System.Drawing.Color.Black;
            this.englishOrFrenchTextTextBox.Location = new System.Drawing.Point(11, 194);
            this.englishOrFrenchTextTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.englishOrFrenchTextTextBox.Name = "englishOrFrenchTextTextBox";
            this.englishOrFrenchTextTextBox.Size = new System.Drawing.Size(406, 23);
            this.englishOrFrenchTextTextBox.TabIndex = 21;
            this.englishOrFrenchTextTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // assessMeButton
            // 
            this.assessMeButton.BackColor = System.Drawing.Color.Red;
            this.assessMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assessMeButton.Location = new System.Drawing.Point(13, 16);
            this.assessMeButton.Margin = new System.Windows.Forms.Padding(4);
            this.assessMeButton.Name = "assessMeButton";
            this.assessMeButton.Size = new System.Drawing.Size(162, 88);
            this.assessMeButton.TabIndex = 22;
            this.assessMeButton.Text = "Check my answer\r\nVerifie ma réponse";
            this.assessMeButton.UseVisualStyleBackColor = false;
            this.assessMeButton.Visible = false;
            this.assessMeButton.Click += new System.EventHandler(this.assessMeButton_Click);
            // 
            // teachMeAgainButton
            // 
            this.teachMeAgainButton.BackColor = System.Drawing.Color.Black;
            this.teachMeAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachMeAgainButton.ForeColor = System.Drawing.Color.Red;
            this.teachMeAgainButton.Location = new System.Drawing.Point(242, 19);
            this.teachMeAgainButton.Margin = new System.Windows.Forms.Padding(4);
            this.teachMeAgainButton.Name = "teachMeAgainButton";
            this.teachMeAgainButton.Size = new System.Drawing.Size(156, 83);
            this.teachMeAgainButton.TabIndex = 23;
            this.teachMeAgainButton.Text = "Teach me again\r\nEnseigne moi encore";
            this.teachMeAgainButton.UseVisualStyleBackColor = false;
            this.teachMeAgainButton.Visible = false;
            this.teachMeAgainButton.Click += new System.EventHandler(this.teachMeAgainButton_Click);
            // 
            // msgBoxLabel
            // 
            this.msgBoxLabel.AutoSize = true;
            this.msgBoxLabel.Location = new System.Drawing.Point(4, 10);
            this.msgBoxLabel.Name = "msgBoxLabel";
            this.msgBoxLabel.Size = new System.Drawing.Size(403, 13);
            this.msgBoxLabel.TabIndex = 24;
            this.msgBoxLabel.Text = "................................................................................." +
    "...................................................";
            // 
            // msgBoxLabel2
            // 
            this.msgBoxLabel2.AutoSize = true;
            this.msgBoxLabel2.Location = new System.Drawing.Point(6, 48);
            this.msgBoxLabel2.Name = "msgBoxLabel2";
            this.msgBoxLabel2.Size = new System.Drawing.Size(403, 13);
            this.msgBoxLabel2.TabIndex = 25;
            this.msgBoxLabel2.Text = "................................................................................." +
    "...................................................";
            this.msgBoxLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.msgBoxLabel2.Click += new System.EventHandler(this.msgBoxLabel2_Click);
            // 
            // hidenValueLabel
            // 
            this.hidenValueLabel.AutoSize = true;
            this.hidenValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidenValueLabel.Location = new System.Drawing.Point(18, 150);
            this.hidenValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hidenValueLabel.Name = "hidenValueLabel";
            this.hidenValueLabel.Size = new System.Drawing.Size(73, 17);
            this.hidenValueLabel.TabIndex = 28;
            this.hidenValueLabel.Text = "HiddenVal";
            // 
            // hiddenValueTextBox
            // 
            this.hiddenValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenValueTextBox.Location = new System.Drawing.Point(300, 146);
            this.hiddenValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hiddenValueTextBox.Name = "hiddenValueTextBox";
            this.hiddenValueTextBox.Size = new System.Drawing.Size(117, 23);
            this.hiddenValueTextBox.TabIndex = 29;
            // 
            // msgBoxLabel3
            // 
            this.msgBoxLabel3.AutoSize = true;
            this.msgBoxLabel3.Location = new System.Drawing.Point(8, 82);
            this.msgBoxLabel3.Name = "msgBoxLabel3";
            this.msgBoxLabel3.Size = new System.Drawing.Size(403, 13);
            this.msgBoxLabel3.TabIndex = 30;
            this.msgBoxLabel3.Text = "................................................................................." +
    "...................................................";
            this.msgBoxLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.msgBoxLabel3.Click += new System.EventHandler(this.msgBoxLabel3_Click);
            // 
            // hiddenOldValueLabel
            // 
            this.hiddenOldValueLabel.AutoSize = true;
            this.hiddenOldValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenOldValueLabel.Location = new System.Drawing.Point(19, 125);
            this.hiddenOldValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hiddenOldValueLabel.Name = "hiddenOldValueLabel";
            this.hiddenOldValueLabel.Size = new System.Drawing.Size(95, 17);
            this.hiddenOldValueLabel.TabIndex = 31;
            this.hiddenOldValueLabel.Text = "HiddenOldVal";
            this.hiddenOldValueLabel.Visible = false;
            // 
            // hiddenOldValueTextBox
            // 
            this.hiddenOldValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenOldValueTextBox.Location = new System.Drawing.Point(300, 114);
            this.hiddenOldValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hiddenOldValueTextBox.Name = "hiddenOldValueTextBox";
            this.hiddenOldValueTextBox.Size = new System.Drawing.Size(117, 23);
            this.hiddenOldValueTextBox.TabIndex = 32;
            this.hiddenOldValueTextBox.Visible = false;
            // 
            // TeachMeWordsItonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(456, 232);
            this.Controls.Add(this.hiddenOldValueTextBox);
            this.Controls.Add(this.hiddenOldValueLabel);
            this.Controls.Add(this.msgBoxLabel3);
            this.Controls.Add(this.hiddenValueTextBox);
            this.Controls.Add(this.hidenValueLabel);
            this.Controls.Add(this.msgBoxLabel2);
            this.Controls.Add(this.msgBoxLabel);
            this.Controls.Add(this.teachMeAgainButton);
            this.Controls.Add(this.assessMeButton);
            this.Controls.Add(this.englishOrFrenchTextTextBox);
            this.Controls.Add(this.itonTextLabel);
            this.Controls.Add(this.replayButton);
            this.Name = "TeachMeWordsItonForm";
            this.Text = "Ngifundise Amagama";
            this.Load += new System.EventHandler(this.TeachMeWordsItonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Label itonTextLabel;
        private System.Windows.Forms.TextBox englishOrFrenchTextTextBox;
        private System.Windows.Forms.Button assessMeButton;
        private System.Windows.Forms.Button teachMeAgainButton;
        private System.Windows.Forms.Label msgBoxLabel;
        private System.Windows.Forms.Label msgBoxLabel2;
        private System.Windows.Forms.Label hidenValueLabel;
        private System.Windows.Forms.TextBox hiddenValueTextBox;
        private System.Windows.Forms.Label msgBoxLabel3;
        private System.Windows.Forms.Label hiddenOldValueLabel;
        private System.Windows.Forms.TextBox hiddenOldValueTextBox;

        public System.Windows.Forms.TextBox propHiddenOldValueTextBox
        {
            set { hiddenOldValueTextBox = value; }
            get { return hiddenOldValueTextBox; }
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

        public System.Windows.Forms.TextBox propEnglishOrFrenchTextTextBox
        {
            set { englishOrFrenchTextTextBox = value; }
            get { return englishOrFrenchTextTextBox; }
        }
        public NaturalLanguage language { get; set; }
        public Form previousForm { get; set; }


    }
}