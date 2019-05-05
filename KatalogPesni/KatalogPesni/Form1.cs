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
    public partial class Form1 : Form
    {
        Database d;
        DatabaseController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new DatabaseController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                                
            listBox1.Items.AddRange(controller.GetSongNames().ToArray());            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            controller = new DatabaseController();
            LoadFromFIle Load = new LoadFromFIle(@"I:\KatalogPesni.txt");
            var items = Load.GetModelFromFile();
            foreach (var i in items)
            {
                controller.WriteToDatabase(i);
            }

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var res = controller.GetModelByName(listBox1.SelectedItem.ToString());
            label6.Text = res.SongName;
            label7.Text = res.Singer;
            label8.Text = res.Year.ToString();
            label9.Text = res.Genre;
            label10.Text = res.Length.ToString();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(controller);
            f2.ShowDialog();
        }

        private void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = (RadioButton)sender;
            richTextBox1.Text = "";
            if(box.Checked)
            {
                switch (int.Parse(box.Tag.ToString()))
                {
                    case 0:
                        {
                            var res = controller.GetSortedSongNames();
                            foreach (var s in res)
                                richTextBox1.Text += s + "\n";
                        }
                        break;
                    case 1:
                        {
                            var res = controller.GetSortedSingers();
                            foreach (var s in res)
                                richTextBox1.Text += s + "\n";
                        }
                        break;
                    case 2:
                        {
                            var res = controller.GetSortedYear();
                            foreach (var s in res)
                                richTextBox1.Text += s + "\n";
                        }
                        break;
                    case 3:
                        {
                            var res = controller.GetSortedGenre();
                            foreach (var s in res)
                                richTextBox1.Text += s + "\n";
                        }
                        break;
                    case 4:
                        {
                            var res = controller.GetSortedLength();
                            foreach (var s in res)
                                richTextBox1.Text += s + "\n";
                        }
                        break;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }


}
