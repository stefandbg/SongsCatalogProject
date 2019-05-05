using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatalogPesni
{
    public partial class Form2 : Form
    {
        private DatabaseController controller;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(DatabaseController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var model = new CatalogDataModel()
            {
                SongName = textBox1.Text,
                Singer = textBox2.Text,
                Year = int.Parse(textBox3.Text),
                Genre = textBox4.Text,
                Length = double.Parse(textBox5.Text)
            };

            controller.WriteToDatabase(model);
            this.Close();
        }
    }
}
