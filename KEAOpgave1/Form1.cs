using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHej_Click(object sender, EventArgs e) // Metode for knappen 'Hej'. Når knappen klikkes vil alt inde i denne metode køres.
        {
            labelHej.Text = "Hej " + textBoxNavn.Text + " velkommen til!"; // Tilføjer tekst til 'labelHej', navnet tages fra 'textBoxNavn'
        }
    }
}
