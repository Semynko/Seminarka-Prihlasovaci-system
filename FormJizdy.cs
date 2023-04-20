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
        public static string text;
        public FormJizdy()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader("jizdy.txt"))
            {
                jizdalist = sr.ReadToEnd().Split('\n');
                text = sr.ReadToEnd();
            }

            for (int i = 0; i < jizdalist.Length; i++)
            {
                lbxSeznamJizd.Items.Add(jizdalist[i]);
                //f

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVytvoritJizdu fvj = new FormVytvoritJizdu();
            fvj.ShowDialog();
        }
    }
}