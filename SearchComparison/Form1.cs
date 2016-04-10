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

        public Form1()
        {
            InitializeComponent();
        }

        #region LinearSearch

        #region WithNumbers

        public List<int> lista = new List<int>();
        public List<int> lista2 = new List<int>();
        private const int listCount = 10000;
        private int indexSearch;

        private void Create_ListNumbers1(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            for (int i = 0; i < listCount; i++)
            {
                lista.Add(rand.Next(listCount));
                lista2.Add(lista[i]);
            }
            listBox1.Items.Clear();
            for (int i = 0; i < listCount; i++)
            {
                listBox1.Items.Add(lista[i]);
            }
            lista2.Sort();
            listBox2.Items.Clear();
           for (int i = 0; i < listCount; i++)
            {
                listBox2.Items.Add(lista2[i]);
            }
           
        }

        private void Find_Linear(object sender, EventArgs e)
        {
           label1.Text = "";
           label4.Text = "";
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

        private void Find_Position(object sender, EventArgs e)
        {
            indexSearch = int.Parse(textBox2.Text);
            label4.Text = "";
            label1.Text = "";
            if (int.Parse(textBox2.Text) > listCount || int.Parse(textBox2.Text) < 0)
            {
                label4.Text = "Please, put a number between 0 and 1000";
            }
            else
            {
                label4.Text = "The number in this position is " + lista[indexSearch - 1].ToString();
            }
        }

        #endregion

        #region WithWords

        char[] spliter = {' '};
        char[] spliters = {' ', ',', '.', ':', ';'};
        private int letter;

        private void Add_Text(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            string txt = textBox3.Text;
            string[] word = txt.Split(spliter);
            string[] words = txt.Split(spliters);
            
            foreach (string w in words)
            {
                if (w == textBox4.Text)
                {
                    label5.Text = "The word '" + textBox4.Text + "' exist in the current text";
                    letter = w.Length;
                    label8.Text = "The word have " + letter.ToString() + " letters";
                }
            }
            if (textBox4.Text == "")
            {
                label5.Text = "There is no word to be found.";
            }
            else if (label5.Text == "")
            {
                label5.Text = "The word '" + textBox4.Text + "' does not exist in the current text";
            }

            label7.Text = "There are " + word.Length.ToString() + " word(s) in the current text";
        }

        #endregion


        #endregion

        #region BinarySearch

        private void Find_Binary(object sender, EventArgs e)
        {

        }

        #endregion









    }
}
