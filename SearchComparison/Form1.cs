using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchComparison
{
    public partial class Form1 : Form
    {
        public List<int> lista = new List<int>();
        private const int listCount = 1000;
        private int indexSearch;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            for (int i = 0; i < listCount; i++)
            {
                lista.Add(rand.Next(10000));
            }
            lista.Sort();
            listBox1.Items.Clear();
           for (int i = 0; i < listCount; i++)
            {
                listBox1.Items.Add(lista[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           label1.Text = "";
            for(int i = 0; i < lista.Count(); i++)
            {
                if (lista[i] == int.Parse(textBox1.Text)) 
                {
                    label1.Text += "The number has been found in the position" + " " + (i + 1) + "! " + "\n";
                }
            }
            if (label1.Text == "" || label1.Text == "This number has not been found! Please, put another one!")
            {
                label1.Text = "This number has not been found! Please, put another one!";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            indexSearch = int.Parse(textBox2.Text);
            label4.Text = "";
            label4.Text = "The number in this position is " + lista[indexSearch - 1].ToString();
        }

      


    }
}
