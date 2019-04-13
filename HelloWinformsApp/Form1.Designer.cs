namespace HelloWinformsApp
{
    partial class Form1
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
            this.labelImię = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelWiek = new System.Windows.Forms.Label();
            this.textBoxImię = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelKomunikat1 = new System.Windows.Forms.Label();
            this.labelKomunikat2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelImię
            // 
            this.labelImię.AutoSize = true;
            this.labelImię.Location = new System.Drawing.Point(26, 34);
            this.labelImię.Name = "labelImię";
            this.labelImię.Size = new System.Drawing.Size(39, 20);
            this.labelImię.TabIndex = 0;
            this.labelImię.Text = "Imię";
            this.labelImię.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(26, 96);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(76, 20);
            this.labelNazwisko.TabIndex = 1;
            this.labelNazwisko.Text = "Nazwisko";
            this.labelNazwisko.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(26, 154);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(44, 20);
            this.labelWiek.TabIndex = 2;
            this.labelWiek.Text = "Wiek";
            this.labelWiek.Click += new System.EventHandler(this.labelWiek_Click);
            // 
            // textBoxImię
            // 
            this.textBoxImię.Location = new System.Drawing.Point(108, 31);
            this.textBoxImię.Name = "textBoxImię";
            this.textBoxImię.Size = new System.Drawing.Size(100, 26);
            this.textBoxImię.TabIndex = 3;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(108, 90);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 26);
            this.textBoxNazwisko.TabIndex = 4;
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(108, 151);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(100, 26);
            this.textBoxWiek.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(108, 215);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 36);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Kliknij";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelKomunikat1
            // 
            this.labelKomunikat1.AutoSize = true;
            this.labelKomunikat1.Location = new System.Drawing.Point(26, 306);
            this.labelKomunikat1.Name = "labelKomunikat1";
            this.labelKomunikat1.Size = new System.Drawing.Size(97, 20);
            this.labelKomunikat1.TabIndex = 7;
            this.labelKomunikat1.Text = "Komunikat 1";
            this.labelKomunikat1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelKomunikat2
            // 
            this.labelKomunikat2.AutoSize = true;
            this.labelKomunikat2.Location = new System.Drawing.Point(26, 357);
            this.labelKomunikat2.Name = "labelKomunikat2";
            this.labelKomunikat2.Size = new System.Drawing.Size(97, 20);
            this.labelKomunikat2.TabIndex = 8;
            this.labelKomunikat2.Text = "Komunikat 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKomunikat2);
            this.Controls.Add(this.labelKomunikat1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImię);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImię);
            this.Name = "Form1";
            this.Text = "Aplikacja Witaj!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImię;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.TextBox textBoxImię;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelKomunikat1;
        private System.Windows.Forms.Label labelKomunikat2;
    }
}

