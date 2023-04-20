using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoskola
{
    public partial class FormVytvoritJizdu : Form
    {
        public FormVytvoritJizdu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = FormJizdy.text;
            MessageBox.Show(dtpJizda.Text);
        }
    }
}
