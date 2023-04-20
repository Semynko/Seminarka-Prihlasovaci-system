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
        
        FormSystem sys = new FormSystem();
        public static string jmen;
        public static string hes;
        public static int pocetradkuhes = 0;
        public static int pocetradkujmen = 0;
        public static string[] radhes;
        public static string[] radjmen;
        public FormPrihlaseni()
        {
            InitializeComponent();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {

            FormRegistrace reg = new FormRegistrace();
            reg.ShowDialog();
            
        }

        private void buttonPrihlasit_Click(object sender, EventArgs e)
        {
            string pomocnahes = textBoxHeslo.Text;
            string pomocnajmen = textBoxJmeno.Text;
            using (StreamReader hesla = new StreamReader("hesla.txt"))
            {
                pocetradkuhes = 0;
                string radek;
                while((radek = hesla.ReadLine()) != null)
                {
                    pocetradkuhes++;
                    hes += (radek + "\n");
                    
                }
                radhes = hes.Split('\n');


                hesla.Close();
            }
            using (StreamReader jmena = new StreamReader("jmena.txt"))
            {
                pocetradkujmen = 0;
                string radek;
                while ((radek = jmena.ReadLine()) != null)
                {
                    pocetradkujmen++;
                    jmen += (radek + "\n");
                    
                }
                radjmen = jmen.Split('\n');


                jmena.Close();
            }
            for (int i = 0; i < pocetradkujmen; i++)
            {
                /*
                MessageBox.Show(radhes[i].ToString().Trim());
                MessageBox.Show(radjmen[i].ToString().Trim());
                MessageBox.Show("Prvni v radhes:" +radhes[0].ToString().Trim());
                MessageBox.Show("Prvni v radjmen: " + radjmen[0].ToString().Trim());
                MessageBox.Show("Druhy v radhes:" + radhes[1].ToString().Trim());
                MessageBox.Show("Druhy v radjmen: " + radjmen[1].ToString().Trim());
                MessageBox.Show("Počet radku v heslech:" + pocetradkuhes.ToString());
                MessageBox.Show("Počet radku v jmenech:" + pocetradkujmen.ToString());
                MessageBox.Show("Velikost poli:" + Environment.NewLine + "Radhes:" + radhes.Length.ToString() + Environment.NewLine + "Radjmen:" + radjmen.Length.ToString());
                */
                if (pomocnahes == radhes[i].ToString() && pomocnajmen == radjmen[i].ToString())
                {
                    Close();
                    sys.ShowDialog();
                    
                    break;
                    
                }
                if(pomocnahes != radhes[i].ToString() && pomocnajmen == radjmen[i].ToString())
                {
                    MessageBox.Show("Špatné heslo!");
                    break;
                }
            }
            /*
            if(textBoxJmeno.Text.Length > 0 && textBoxJmeno.Text == FormRegistrace.uzjmeno)
            {
                if(textBoxHeslo.Text.Length > 0 && textBoxHeslo.Text == FormRegistrace.heslo)
                {
                    sys.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Špatné heslo!");
                }
            }
            else
            {
                MessageBox.Show("Špatné uživatelské jméno!");
            }
            */
        }

        private void buttonZapomel_Click(object sender, EventArgs e)
        {

        }
    }
}
