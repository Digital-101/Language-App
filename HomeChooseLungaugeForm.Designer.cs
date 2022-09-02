namespace kasuka
{
    partial class HomeChooseLungaugeForm
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
            this.rdbLingala = new System.Windows.Forms.RadioButton();
            this.rdbIgbo = new System.Windows.Forms.RadioButton();
            this.rdbMashi = new System.Windows.Forms.RadioButton();
            this.rdbZulu = new System.Windows.Forms.RadioButton();
            this.rdbSwati = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbBasaa = new System.Windows.Forms.RadioButton();
            this.rdbIton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdbLingala
            // 
            this.rdbLingala.AutoSize = true;
            this.rdbLingala.Location = new System.Drawing.Point(262, 44);
            this.rdbLingala.Name = "rdbLingala";
            this.rdbLingala.Size = new System.Drawing.Size(59, 17);
            this.rdbLingala.TabIndex = 12;
            this.rdbLingala.TabStop = true;
            this.rdbLingala.Text = "Lingala";
            this.rdbLingala.UseVisualStyleBackColor = true;
            // 
            // rdbIgbo
            // 
            this.rdbIgbo.AutoSize = true;
            this.rdbIgbo.Location = new System.Drawing.Point(262, 79);
            this.rdbIgbo.Name = "rdbIgbo";
            this.rdbIgbo.Size = new System.Drawing.Size(46, 17);
            this.rdbIgbo.TabIndex = 11;
            this.rdbIgbo.TabStop = true;
            this.rdbIgbo.Text = "Igbo";
            this.rdbIgbo.UseVisualStyleBackColor = true;
            // 
            // rdbMashi
            // 
            this.rdbMashi.AutoSize = true;
            this.rdbMashi.Location = new System.Drawing.Point(113, 77);
            this.rdbMashi.Name = "rdbMashi";
            this.rdbMashi.Size = new System.Drawing.Size(53, 17);
            this.rdbMashi.TabIndex = 10;
            this.rdbMashi.TabStop = true;
            this.rdbMashi.Text = "Mashi";
            this.rdbMashi.UseVisualStyleBackColor = true;
            // 
            // rdbZulu
            // 
            this.rdbZulu.AutoSize = true;
            this.rdbZulu.Location = new System.Drawing.Point(188, 142);
            this.rdbZulu.Name = "rdbZulu";
            this.rdbZulu.Size = new System.Drawing.Size(46, 17);
            this.rdbZulu.TabIndex = 9;
            this.rdbZulu.TabStop = true;
            this.rdbZulu.Text = "Zulu";
            this.rdbZulu.UseVisualStyleBackColor = true;
            // 
            // rdbSwati
            // 
            this.rdbSwati.AutoSize = true;
            this.rdbSwati.Location = new System.Drawing.Point(115, 44);
            this.rdbSwati.Name = "rdbSwati";
            this.rdbSwati.Size = new System.Drawing.Size(51, 17);
            this.rdbSwati.TabIndex = 8;
            this.rdbSwati.TabStop = true;
            this.rdbSwati.Text = "Swati";
            this.rdbSwati.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ready to Learn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbBasaa
            // 
            this.rdbBasaa.AutoSize = true;
            this.rdbBasaa.Location = new System.Drawing.Point(262, 117);
            this.rdbBasaa.Name = "rdbBasaa";
            this.rdbBasaa.Size = new System.Drawing.Size(55, 17);
            this.rdbBasaa.TabIndex = 13;
            this.rdbBasaa.TabStop = true;
            this.rdbBasaa.Text = "Basaa";
            this.rdbBasaa.UseVisualStyleBackColor = true;
            // 
            // rdbIton
            // 
            this.rdbIton.AutoSize = true;
            this.rdbIton.Location = new System.Drawing.Point(113, 117);
            this.rdbIton.Name = "rdbIton";
            this.rdbIton.Size = new System.Drawing.Size(43, 17);
            this.rdbIton.TabIndex = 14;
            this.rdbIton.TabStop = true;
            this.rdbIton.Text = "Iton";
            this.rdbIton.UseVisualStyleBackColor = true;
            this.rdbIton.CheckedChanged += new System.EventHandler(this.rdbIton_CheckedChanged);
            // 
            // HomeChooseLungaugeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(443, 251);
            this.Controls.Add(this.rdbIton);
            this.Controls.Add(this.rdbBasaa);
            this.Controls.Add(this.rdbLingala);
            this.Controls.Add(this.rdbIgbo);
            this.Controls.Add(this.rdbMashi);
            this.Controls.Add(this.rdbZulu);
            this.Controls.Add(this.rdbSwati);
            this.Controls.Add(this.button1);
            this.Name = "HomeChooseLungaugeForm";
            this.Text = "Choose The  Lunguage that you want to Learn ";
            this.Load += new System.EventHandler(this.HomeChooseLungaugeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbLingala;
        private System.Windows.Forms.RadioButton rdbIgbo;
        private System.Windows.Forms.RadioButton rdbMashi;
        private System.Windows.Forms.RadioButton rdbZulu;
        private System.Windows.Forms.RadioButton rdbSwati;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbBasaa;
        private System.Windows.Forms.RadioButton rdbIton;
    }
}