using System.Windows.Forms;

namespace kasuka
{
    partial class ChooseHearReadWriteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseHearReadWriteForm));
            this.tilItonButton = new System.Windows.Forms.Button();
            this.readOrWriteGroupBox = new System.Windows.Forms.GroupBox();
            this.hearRadioButton = new System.Windows.Forms.RadioButton();
            this.readRadioButton = new System.Windows.Forms.RadioButton();
            this.writeRadioButton = new System.Windows.Forms.RadioButton();
            this.readOrWriteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tilItonButton
            // 
            this.tilItonButton.BackColor = System.Drawing.Color.Black;
            this.tilItonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilItonButton.ForeColor = System.Drawing.Color.Red;
            this.tilItonButton.Location = new System.Drawing.Point(13, 111);
            this.tilItonButton.Margin = new System.Windows.Forms.Padding(4);
            this.tilItonButton.Name = "tilItonButton";
            this.tilItonButton.Size = new System.Drawing.Size(263, 86);
            this.tilItonButton.TabIndex = 1;
            this.tilItonButton.Text = "CONTINUE(R)";
            this.tilItonButton.UseVisualStyleBackColor = false;
            this.tilItonButton.Click += new System.EventHandler(this.tilItonButton_Click);
            // 
            // readOrWriteGroupBox
            // 
            this.readOrWriteGroupBox.BackColor = System.Drawing.Color.Gold;
            this.readOrWriteGroupBox.Controls.Add(this.hearRadioButton);
            this.readOrWriteGroupBox.Controls.Add(this.readRadioButton);
            this.readOrWriteGroupBox.Controls.Add(this.writeRadioButton);
            this.readOrWriteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOrWriteGroupBox.Location = new System.Drawing.Point(13, 13);
            this.readOrWriteGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.readOrWriteGroupBox.Name = "readOrWriteGroupBox";
            this.readOrWriteGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.readOrWriteGroupBox.Size = new System.Drawing.Size(261, 90);
            this.readOrWriteGroupBox.TabIndex = 2;
            this.readOrWriteGroupBox.TabStop = false;
            this.readOrWriteGroupBox.Text = "I WANT TO / JE VEUX";
            // 
            // hearRadioButton
            // 
            this.hearRadioButton.AutoSize = true;
            this.hearRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hearRadioButton.Location = new System.Drawing.Point(11, 21);
            this.hearRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.hearRadioButton.Name = "hearRadioButton";
            this.hearRadioButton.Size = new System.Drawing.Size(202, 21);
            this.hearRadioButton.TabIndex = 2;
            this.hearRadioButton.Text = "Hear Swati  / Ecouter l\'Swati";
            this.hearRadioButton.UseVisualStyleBackColor = true;
            // 
            // readRadioButton
            // 
            this.readRadioButton.AutoSize = true;
            this.readRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readRadioButton.Location = new System.Drawing.Point(11, 41);
            this.readRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.readRadioButton.Name = "readRadioButton";
            this.readRadioButton.Size = new System.Drawing.Size(209, 21);
            this.readRadioButton.TabIndex = 1;
            this.readRadioButton.Text = "Read in Swati  / Lire en Swati";
            this.readRadioButton.UseVisualStyleBackColor = true;
            // 
            // writeRadioButton
            // 
            this.writeRadioButton.AutoSize = true;
            this.writeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeRadioButton.Location = new System.Drawing.Point(11, 61);
            this.writeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeRadioButton.Name = "writeRadioButton";
            this.writeRadioButton.Size = new System.Drawing.Size(217, 21);
            this.writeRadioButton.TabIndex = 0;
            this.writeRadioButton.Text = "Write in Swati / Ecrire en Swati";
            this.writeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChooseHearReadWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(335, 213);
            this.Controls.Add(this.readOrWriteGroupBox);
            this.Controls.Add(this.tilItonButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseHearReadWriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a Task ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseHearReadWriteForm_FormClosing);
            this.readOrWriteGroupBox.ResumeLayout(false);
            this.readOrWriteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button tilItonButton;
        private System.Windows.Forms.GroupBox readOrWriteGroupBox;
        private System.Windows.Forms.RadioButton readRadioButton;
        private System.Windows.Forms.RadioButton writeRadioButton;
        private System.Windows.Forms.RadioButton hearRadioButton;


        public System.Windows.Forms.RadioButton propReadRadioButton
        {
            get { return readRadioButton; }
        }
        public System.Windows.Forms.RadioButton propWriteRadioButton
        {
            get { return writeRadioButton; }
        }
        public System.Windows.Forms.RadioButton propHearRadioButton
        {
            get { return hearRadioButton; }
        }
        public NaturalLanguage language { get; set; }
        public Form previousForm { get; set; }
    }
}

