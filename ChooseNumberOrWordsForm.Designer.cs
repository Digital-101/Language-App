using System.Windows.Forms;

namespace kasuka
{
    partial class ChooseNumberOrWordsForm
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
            this.readOrWriteGroupBox = new System.Windows.Forms.GroupBox();
            this.wordsRadioButton = new System.Windows.Forms.RadioButton();
            this.numbersRadioButton = new System.Windows.Forms.RadioButton();
            this.tilItonButton = new System.Windows.Forms.Button();
            this.readOrWriteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // readOrWriteGroupBox
            // 
            this.readOrWriteGroupBox.BackColor = System.Drawing.Color.Gold;
            this.readOrWriteGroupBox.Controls.Add(this.wordsRadioButton);
            this.readOrWriteGroupBox.Controls.Add(this.numbersRadioButton);
            this.readOrWriteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOrWriteGroupBox.Location = new System.Drawing.Point(12, 15);
            this.readOrWriteGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.readOrWriteGroupBox.Name = "readOrWriteGroupBox";
            this.readOrWriteGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.readOrWriteGroupBox.Size = new System.Drawing.Size(252, 72);
            this.readOrWriteGroupBox.TabIndex = 3;
            this.readOrWriteGroupBox.TabStop = false;
            this.readOrWriteGroupBox.Text = "I WANT  /  JE VEUX LES";
            // 
            // wordsRadioButton
            // 
            this.wordsRadioButton.AutoSize = true;
            this.wordsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsRadioButton.Location = new System.Drawing.Point(6, 41);
            this.wordsRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.wordsRadioButton.Name = "wordsRadioButton";
            this.wordsRadioButton.Size = new System.Drawing.Size(242, 21);
            this.wordsRadioButton.TabIndex = 1;
            this.wordsRadioButton.Text = "Small Sentences / Petites Phrases";
            this.wordsRadioButton.UseVisualStyleBackColor = true;
            // 
            // numbersRadioButton
            // 
            this.numbersRadioButton.AutoSize = true;
            this.numbersRadioButton.Checked = true;
            this.numbersRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersRadioButton.Location = new System.Drawing.Point(6, 18);
            this.numbersRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.numbersRadioButton.Name = "numbersRadioButton";
            this.numbersRadioButton.Size = new System.Drawing.Size(160, 21);
            this.numbersRadioButton.TabIndex = 0;
            this.numbersRadioButton.TabStop = true;
            this.numbersRadioButton.Text = "Numbers  /  Nombres";
            this.numbersRadioButton.UseVisualStyleBackColor = true;
            // 
            // tilItonButton
            // 
            this.tilItonButton.BackColor = System.Drawing.Color.Black;
            this.tilItonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilItonButton.ForeColor = System.Drawing.Color.Red;
            this.tilItonButton.Location = new System.Drawing.Point(7, 99);
            this.tilItonButton.Margin = new System.Windows.Forms.Padding(4);
            this.tilItonButton.Name = "tilItonButton";
            this.tilItonButton.Size = new System.Drawing.Size(259, 86);
            this.tilItonButton.TabIndex = 4;
            this.tilItonButton.Text = "START / DEBUT";
            this.tilItonButton.UseVisualStyleBackColor = false;
            this.tilItonButton.Click += new System.EventHandler(this.tilItonButton_Click);
            // 
            // ChooseNumberOrWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(275, 191);
            this.Controls.Add(this.tilItonButton);
            this.Controls.Add(this.readOrWriteGroupBox);
            this.Name = "ChooseNumberOrWordsForm";
            this.Text = "choose numbers / sentences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseNumberOrWordsForm_FormClosing);
            this.readOrWriteGroupBox.ResumeLayout(false);
            this.readOrWriteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox readOrWriteGroupBox;
        private System.Windows.Forms.RadioButton wordsRadioButton;
        private System.Windows.Forms.RadioButton numbersRadioButton;
        private System.Windows.Forms.Button tilItonButton;
       public NaturalLanguage language { get; set; }
      
       public Form previousForm { get; set; }


    }
}