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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < listCount; i++)
            {
                lista.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lista.Count(); i++)
            {
                if (lista[i] == int.Parse(textBox1.Text))
                {
                    label1.Text += i + " " + "Existe esse elemento";
                }
                else if (lista.Count() <= int.Parse(textBox1.Text))
                {
                    label1.Text = "Não existe esse elemento";
                }
                else 
                {
                    label1.Text = "Não existe esse elemento";
                }
            }
        }

      


    }
}
