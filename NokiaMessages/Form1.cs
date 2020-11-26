using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NokiaMessages
{
    public partial class Form1 : Form
    {
        Convertir C;
        public Form1()
        {
            C = new Convertir();
            InitializeComponent();
        }



        private void QuitterBoutton_OnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrypteButton_Click(object sender, EventArgs e)
        {
            string chaineClaire = messageClair.Text;
            messageCrypte.Text = C.LettersToNumbers(chaineClaire);
        }

        private void DecrypteButton_Click(object sender, EventArgs e)
        {
            string chaineCrypte = messageCrypte.Text;
            messageClair.Text = C.NumbersToLetters(chaineCrypte);
        }
    }
}
