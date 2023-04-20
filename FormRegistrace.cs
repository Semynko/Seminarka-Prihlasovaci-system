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

namespace Autoskola
{
    public partial class FormRegistrace : Form
    {
        public static string uzjmeno;
        public static string heslo;
        public static string potvrditheslo;
        public static string email;
        
        
        public FormRegistrace()
        {
            InitializeComponent();
        }

        private void buttonRegistrovat_Click(object sender, EventArgs e)
        {
            uzjmeno = textBoxJmeno.Text;
            heslo = textBoxHeslo.Text;
            potvrditheslo = textBoxPotvrdit.Text;
            email = textBoxEmail.Text;
            int pocetvelkych = 0;
            int pocetcisel = 0;
            if(uzjmeno.Length > 0 && email.Length > 0)
            {
                if(heslo.Length >= 8)
                {
                    for(int i = 0; i < heslo.Length; i++)
                    {
                        if (char.IsUpper(heslo[i]))
                        {
                            pocetvelkych++;
                        }
                    }
                    if(pocetvelkych >= 1)
                    {
                        for (int j = 0;  j< heslo.Length; j++)
                        {
                            if (char.IsNumber(heslo[j]))
                            {
                                pocetcisel++;
                            }
                        }
                        if (pocetcisel >= 1)
                        {
                            if (heslo == potvrditheslo)
                            {
                                this.Close();
                                //tohle dodelat
                                for(int i = 0;i< FormPrihlaseni.pocetradkujmen; i++)
                                {
                                    if (FormPrihlaseni.radjmen[i] != uzjmeno)
                                    {
                                        using (StreamWriter jmena = new StreamWriter("jmena.txt", true))
                                        {
                                            jmena.WriteLine(uzjmeno.ToString());
                                            jmena.Close();
                                        }
                                        break;
                                    }
                                }
                                using (StreamWriter hesla = new StreamWriter("hesla.txt", true))
                                {
                                    hesla.WriteLine(heslo.ToString());
                                    hesla.Close();
                                }
                                
                                using(StreamWriter emaily = new StreamWriter("emaily", true))
                                {
                                    emaily.WriteLine(email.ToString());
                                    emaily.Close();
                                }
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Neshodná hesla!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Heslo musí obsahovat alespoň jednu číslici!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Heslo musí obsahovat alespoň jedno velké písmeno!");
                    }
                }
                else
                {
                    MessageBox.Show("Heslo musí obsahovat nejméně 8 znaků!");
                }
            }
            else
            {
                MessageBox.Show("Zadejte jméno a heslo!");
            }
        }
    }
}
