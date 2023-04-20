using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    public partial class FormJizdy : Form
    {
        
        private string[] jizdalist;
        public static string datum;
        public static string text;
        public FormJizdy()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader("jizdy.txt"))
            {
                text = sr.ReadToEnd();
                jizdalist = text.Split('\n');
                MessageBox.Show(text);
            }

            for (int i = 0; i < jizdalist.Length; i++)
            {
                lbxSeznamJizd.Items.Add(jizdalist[i]);
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVytvoritJizdu fvj = new FormVytvoritJizdu();
            fvj.ShowDialog();
        }

        //Funkce na zapsání nově naplánované jízdy do souboru
        //a do listboxu 
        public static void ZapsatNovouJizdu(string s)
        {
            s = FormJizdy.ZformatovaniDatumu(s);
            using(StreamWriter sw = new StreamWriter("jizdy.txt"))
            {
                sw.WriteLine(text + s + Environment.NewLine);
            }
            
        }
        public static string ZformatovaniDatumu(string s)
        {
            string[] pomocna = s.Split(':');
            string[] pomo2 = pomocna[0].Split(' ');
            if (pomo2[1].Length == 2)
            {
                return s = $"{pomocna[0] + ":" + pomocna[1]}";

            }
            else
            {
                return s = $"{pomo2[0]} 0{pomo2[1]}:{pomocna[1]}";
            }
        }
    }
}