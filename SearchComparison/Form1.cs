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
        private const int listCount = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            for (int i = 0; i < listCount; i++)
            {
                lista.Add(rand.Next(0, 2000));
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
                
            }
            
        }

      


    }
}
