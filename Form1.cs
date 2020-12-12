using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace budicPolugodiste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Zvucnik> zvucnik=new List<Zvucnik>();
        private void btnIspisi_Click(object sender, EventArgs e)
        {
            dataGridViewTablica.Refresh();
            dataGridViewTablica.DataSource = zvucnik;

        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            List<Zvucnik> temp = zvucnik;
            foreach(Zvucnik tempZv in temp)
            {
                if (tempZv.Snaga < 5) tempZv.Posebno = "Tih";
                if (tempZv.Snaga >= 5 && tempZv.Snaga < 10) tempZv.Posebno = "Tako-Tako";
                if (tempZv.Snaga > 20) tempZv.Posebno = "Buka";
            }
            zvucnik = temp;
            
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Zvucnik temp ;
            int number;
            bool istina = Int32.TryParse(textBoxSnaga.Text, out number);
            if (!istina)
            {
                MessageBox.Show("Nisi upiso/la broj", "Greška"); 
                
            }
            else if  (String.IsNullOrEmpty(textBoxMarka.Text)|| String.IsNullOrEmpty(textBoxModel.Text)|| String.IsNullOrEmpty(textBoxSnaga.Text))
            {
                MessageBox.Show("Nisi ispunio/la sva polja", "Greška");
            }
            else 
            {
                temp = new Zvucnik(textBoxMarka.Text, textBoxModel.Text, int.Parse(textBoxSnaga.Text), comboBoxPovezivost.GetItemText(comboBoxPovezivost.SelectedItem));
                zvucnik.Add(temp);
                textBoxMarka.Clear();
                textBoxModel.Clear();
                textBoxSnaga.Clear();
            }
           
        }

       
    }
}
