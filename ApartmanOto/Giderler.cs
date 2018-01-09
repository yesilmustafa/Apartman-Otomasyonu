using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOto
{
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masraflar = string.Empty;
            foreach (Control item in groupBox1.Controls)
                if (item is CheckBox && ((CheckBox)item).Checked)
                    masraflar += item.Text + ", ";

            //eğer seçili olan gider tipi varsa
            if (masraflar.Length > 0)
                masraflar = masraflar.Remove(masraflar.Length - 2);
            //en sondaki virgül ve boşluk silinsin

            listBox1.Items.Add(masraflar);
            listBox2.Items.Add(numericUpDown2.Value);
            listBox3.Items.Add(dateTimePicker1.Value);
        }
    }
}
