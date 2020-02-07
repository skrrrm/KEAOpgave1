namespace KEAOpgave1
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
            this.buttonHej = new System.Windows.Forms.Button();
            this.labelVejledning = new System.Windows.Forms.Label();
            this.labelHej = new System.Windows.Forms.Label();
            this.textBoxNavn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonHej
            // 
            this.buttonHej.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonHej.Location = new System.Drawing.Point(142, 231);
            this.buttonHej.Name = "buttonHej";
            this.buttonHej.Size = new System.Drawing.Size(295, 23);
            this.buttonHej.TabIndex = 0;
            this.buttonHej.Text = "Klik her når du har skrevet dit navn";
            this.buttonHej.UseVisualStyleBackColor = false;
            this.buttonHej.Click += new System.EventHandler(this.buttonHej_Click);
            // 
            // labelVejledning
            // 
            this.labelVejledning.AutoSize = true;
            this.labelVejledning.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelVejledning.Location = new System.Drawing.Point(151, 129);
            this.labelVejledning.Name = "labelVejledning";
            this.labelVejledning.Size = new System.Drawing.Size(66, 13);
            this.labelVejledning.TabIndex = 1;
            this.labelVejledning.Text = "Indtast navn";
            // 
            // labelHej
            // 
            this.labelHej.AutoSize = true;
            this.labelHej.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelHej.Location = new System.Drawing.Point(151, 333);
            this.labelHej.Name = "labelHej";
            this.labelHej.Size = new System.Drawing.Size(0, 13);
            this.labelHej.TabIndex = 2;
            // 
            // textBoxNavn
            // 
            this.textBoxNavn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxNavn.Location = new System.Drawing.Point(154, 157);
            this.textBoxNavn.Name = "textBoxNavn";
            this.textBoxNavn.Size = new System.Drawing.Size(100, 20);
            this.textBoxNavn.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNavn);
            this.Controls.Add(this.labelHej);
            this.Controls.Add(this.labelVejledning);
            this.Controls.Add(this.buttonHej);
            this.Name = "Form1";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHej;
        private System.Windows.Forms.Label labelVejledning;
        private System.Windows.Forms.Label labelHej;
        private System.Windows.Forms.TextBox textBoxNavn;
    }
}

