using System.Windows.Forms;

namespace kasuka
{
    partial class ChooseVerbForm
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
            this.beOrHaveGroupBox = new System.Windows.Forms.GroupBox();
            this.haveAndBeRadioButton = new System.Windows.Forms.RadioButton();
            this.haveRadioButton = new System.Windows.Forms.RadioButton();
            this.beRadioButton = new System.Windows.Forms.RadioButton();
            this.teachMeButton = new System.Windows.Forms.Button();
            this.testMeButton = new System.Windows.Forms.Button();
            this.beOrHaveGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // beOrHaveGroupBox
            // 
            this.beOrHaveGroupBox.BackColor = System.Drawing.Color.Gold;
            this.beOrHaveGroupBox.Controls.Add(this.haveAndBeRadioButton);
            this.beOrHaveGroupBox.Controls.Add(this.haveRadioButton);
            this.beOrHaveGroupBox.Controls.Add(this.beRadioButton);
            this.beOrHaveGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beOrHaveGroupBox.Location = new System.Drawing.Point(10, 15);
            this.beOrHaveGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.beOrHaveGroupBox.Name = "beOrHaveGroupBox";
            this.beOrHaveGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.beOrHaveGroupBox.Size = new System.Drawing.Size(261, 87);
            this.beOrHaveGroupBox.TabIndex = 3;
            this.beOrHaveGroupBox.TabStop = false;
            this.beOrHaveGroupBox.Text = "CHOSEN VERB / VERBE CHOISI";
            // 
            // haveAndBeRadioButton
            // 
            this.haveAndBeRadioButton.AutoSize = true;
            this.haveAndBeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveAndBeRadioButton.Location = new System.Drawing.Point(11, 61);
            this.haveAndBeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.haveAndBeRadioButton.Name = "haveAndBeRadioButton";
            this.haveAndBeRadioButton.Size = new System.Drawing.Size(147, 21);
            this.haveAndBeRadioButton.TabIndex = 2;
            this.haveAndBeRadioButton.Text = "To have and To be";
            this.haveAndBeRadioButton.UseVisualStyleBackColor = true;
            // 
            // haveRadioButton
            // 
            this.haveRadioButton.AutoSize = true;
            this.haveRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveRadioButton.Location = new System.Drawing.Point(11, 40);
            this.haveRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.haveRadioButton.Name = "haveRadioButton";
            this.haveRadioButton.Size = new System.Drawing.Size(78, 21);
            this.haveRadioButton.TabIndex = 1;
            this.haveRadioButton.Text = "To have";
            this.haveRadioButton.UseVisualStyleBackColor = true;
            // 
            // beRadioButton
            // 
            this.beRadioButton.AutoSize = true;
            this.beRadioButton.Checked = true;
            this.beRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beRadioButton.Location = new System.Drawing.Point(11, 18);
            this.beRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.beRadioButton.Name = "beRadioButton";
            this.beRadioButton.Size = new System.Drawing.Size(63, 21);
            this.beRadioButton.TabIndex = 0;
            this.beRadioButton.TabStop = true;
            this.beRadioButton.Text = "To be";
            this.beRadioButton.UseVisualStyleBackColor = true;
            // 
            // teachMeButton
            // 
            this.teachMeButton.BackColor = System.Drawing.Color.Black;
            this.teachMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachMeButton.ForeColor = System.Drawing.Color.Red;
            this.teachMeButton.Location = new System.Drawing.Point(9, 110);
            this.teachMeButton.Margin = new System.Windows.Forms.Padding(4);
            this.teachMeButton.Name = "teachMeButton";
            this.teachMeButton.Size = new System.Drawing.Size(126, 52);
            this.teachMeButton.TabIndex = 4;
            this.teachMeButton.Text = "Teach me\r\nEnseigne moi";
            this.teachMeButton.UseVisualStyleBackColor = false;
            this.teachMeButton.Click += new System.EventHandler(this.teachMeButton_Click);
            // 
            // testMeButton
            // 
            this.testMeButton.BackColor = System.Drawing.Color.Red;
            this.testMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMeButton.ForeColor = System.Drawing.Color.Black;
            this.testMeButton.Location = new System.Drawing.Point(143, 110);
            this.testMeButton.Margin = new System.Windows.Forms.Padding(4);
            this.testMeButton.Name = "testMeButton";
            this.testMeButton.Size = new System.Drawing.Size(130, 52);
            this.testMeButton.TabIndex = 5;
            this.testMeButton.Text = "Test me\r\nTeste moi";
            this.testMeButton.UseVisualStyleBackColor = false;
            this.testMeButton.Click += new System.EventHandler(this.testMeButton_Click);
            // 
            // ChooseVerbItonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.testMeButton);
            this.Controls.Add(this.teachMeButton);
            this.Controls.Add(this.beOrHaveGroupBox);
            this.Name = "ChooseVerbItonForm";
            this.Text = "Imaphi Amagama?";
            this.beOrHaveGroupBox.ResumeLayout(false);
            this.beOrHaveGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox beOrHaveGroupBox;
        private System.Windows.Forms.RadioButton haveRadioButton;
        private System.Windows.Forms.RadioButton beRadioButton;
        private System.Windows.Forms.Button teachMeButton;
        private System.Windows.Forms.Button testMeButton;
        private System.Windows.Forms.RadioButton haveAndBeRadioButton;
        public NaturalLanguage language { get; set; }
        public Form previousForm { get; set; }

    }
}