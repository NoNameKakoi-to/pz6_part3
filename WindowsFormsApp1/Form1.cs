using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пз6_часть3
{
    public partial class ExhibitForm : Form
    {
        private ExhibitionDatabase _exhibit;
        public ExhibitForm()
        {

            InitializeComponent();

            _exhibit = new ExhibitionDatabase();
            _exhibit.Initialize();
            dataGridView1.DataSource = _exhibit.Exhibits.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            dataGridView1.DataSource = _exhibit.Exhibits.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _exhibit.Exhibits.Where(i => i.Availability == Availability.inStock).ToList(); //?
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _exhibit.Exhibits.OrderBy(i => i.ExhibitName).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _exhibit.Exhibits.Where(i => i.ExhibitName.ToLower().Contains(textBox1.Text.ToLower())).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = _exhibit.Exhibits.Where(i => i.Availability == Availability.inStock).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = _exhibit.Exhibits.Where(i => i.Availability == Availability.outStock).ToList();
                    break;
            }  
        }
    }
}
