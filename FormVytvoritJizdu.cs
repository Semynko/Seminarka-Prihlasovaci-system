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
            //if (FormVytvoritJizdu.        
        }

        private void BtnVytvoritJizdu_Click(object sender, EventArgs e)
        //Funkce po zmáčknutí tlačítka Vytvořit jízdu
        {
            FormJizdy.datum = dtpJizda.Text;
            //MessageBox.Show(dtpJizda.Value.ToString());
            //Jizda.ZapsatNovouJizdu(dtpJizda.Value.ToString());

            Jizda j = new Jizda(dtpJizda.Value.ToString());
            j.ZapsatNovouJizdu();
        }

        private void FormVytvoritJizdu_Load(object sender, EventArgs e)
        {
            FormJizdy fj = new FormJizdy();
            //qfj.lbx
        }
    }
}
