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
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(numericUpDown1.Value);
            listBox2.Items.Add(numericUpDown2.Value);
            listBox3.Items.Add(dateTimePicker1.Value.ToShortDateString());
        }
    }
}
