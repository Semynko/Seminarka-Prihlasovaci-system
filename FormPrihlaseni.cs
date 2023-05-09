using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Autoskola
{
    public partial class FormPrihlaseni : Form
    {
        public FormRegistrace reg = new FormRegistrace();
        public FormSystem sys = new FormSystem();
       
        public FormPrihlaseni()
        {
            InitializeComponent();    
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {     
            reg.ShowDialog();     
        }

        private void buttonPrihlasit_Click(object sender, EventArgs e)
        {
            Hash hash = new Hash();
            Uzivatel uz = new Uzivatel(textBoxJmeno.Text, textBoxHeslo.Text,"","", 0, 0, 0, null, null, null, "", "", "");
            using (StreamReader hesla = new StreamReader("hesla.txt"))
            {
                uz.Pocetradkuhes = 0;
                string radek;
                while((radek = hesla.ReadLine()) != null)
                {
                    uz.Pocetradkuhes++;
                    uz.Hes += (radek + "\n");
                    
                }
                uz.Radhes = null;
                uz.Radhes = uz.Hes.Split('\n');
                hesla.Close();
            }
            using (StreamReader jmena = new StreamReader("jmena.txt"))
            {
                uz.Pocetradkujmen = 0;
                string radek;
                while ((radek = jmena.ReadLine()) != null)
                {
                    uz.Pocetradkujmen++;
                    uz.Jmen += (radek + "\n");    
                }
                jmena.Close();
            }
            using (StreamReader emaily = new StreamReader("emaily.txt"))
            {
                uz.Pocetradkuemail = 0;
                string radek;
                while((radek = emaily.ReadLine()) != null)
                {
                    uz.Pocetradkuemail++;
                    uz.Email += (radek + "\n");
                }
                emaily.Close();
            }
            string pomocnahes = textBoxHeslo.Text;
            string pomocnajmen = textBoxJmeno.Text;
            for (int i = 0; i < uz.Pocetradkujmen; i++)
            {
                uz.Radjmen = null;
                uz.Radjmen = uz.Jmen.Split('\n');
                uz.Rademail = null;
                uz.Rademail = uz.Email.Split('\n');
 
                if (hash.PokusOHash(pomocnahes) == uz.Radhes[i].ToString() && pomocnajmen == uz.Radjmen[i].ToString())
                {
                    this.Close();
                    sys.ShowDialog();
                    break;   
                }
                if (hash.PokusOHash(pomocnahes) != uz.Radhes[i].ToString() && pomocnajmen == uz.Radjmen[i].ToString()) 
                {    
                    MessageBox.Show("Špatné heslo!");
                    break;
                }

            }
            
        }

        private void buttonZapomel_Click(object sender, EventArgs e)
        {
            FormZapomenute fr = new FormZapomenute();
            fr.ShowDialog();
        }

        private void FormPrihlaseni_Enter(object sender, EventArgs e)
        {
            reg.Close();
        }
    }
}
