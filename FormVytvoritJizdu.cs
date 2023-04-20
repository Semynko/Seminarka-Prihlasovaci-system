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

            //Nastavení DateTimePickeru na vybrání datumu i času
            dtpJizda.Format = DateTimePickerFormat.Custom;
            dtpJizda.CustomFormat = "dd/MM/yyyy  HH:mm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormJizdy.datum = dtpJizda.Text;
            //MessageBox.Show(dtpJizda.Value.ToString());
            FormJizdy.ZapsatNovouJizdu(dtpJizda.Value.ToString());
        }
    }
}
