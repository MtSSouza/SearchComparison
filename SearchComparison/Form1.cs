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


        public List<int> lista = new List<int>();
        public List<int> lista2 = new List<int>();
        public const int listCount = 100;
        private int indexSearch;

        private void Create_ListNumbers1(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            for (int i = 0; i < listCount; i++)
            {
                lista.Add(rand.Next(100));
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

        #region LinearSearch

        #region WithNumbers

        private int times2 = 0;

        private void Find_Linear(object sender, EventArgs e)
        {
           label1.Text = "";
           label4.Text = "";

            for(int i = 0; i < lista.Count(); i++)
            {
                times2++;
                if (lista[i] == int.Parse(textBox1.Text)) 
                {
                    label1.Text = "The number " + textBox1.Text + " has been found!";
                    label4.Text = times2  + " elements tested";
                    times2 = 0;
                    break;
                }
                
            }
            if (label1.Text == "" || label1.Text == "The number " + textBox1.Text + " has not been found!")
            {
                label1.Text = "The number " + textBox1.Text + " has not been found!";
                label4.Text = times2 + " elements tested";
                times2 = 0;
            }
            
        }

        private void Find_Position(object sender, EventArgs e)
        {
            indexSearch = int.Parse(textBox2.Text);
            label4.Text = "";
            label1.Text = "";
            if (int.Parse(textBox2.Text) > listCount || int.Parse(textBox2.Text) < 0)
            {
                label1.Text = "Please, put a number between 0 and " + listCount;
            }
            else
            {
                label1.Text = "The number in this position is " + lista[indexSearch - 1].ToString();
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

        private int target;
        private int times = 0;

        private void Find_Binary(object sender, EventArgs e)
        {
            target = int.Parse(textBox6.Text);
            int index = BinarySearch(lista2 , target, 0, lista2.Count(), ref times);

            label12.Text = times.ToString() + " elements tested";
            if (index < lista2.Count() && lista2[index] == target)
            {
                label11.Text = "The number " + target + " has been found!";
                times = 0;
            }
            else
            {
                label11.Text = "The number " + target + " has not been found!";
                times = 0;
            }
        }

        static int BinarySearch(List<int> lista2, int target, int left, int right, ref int times)
        {
            if (left == right - 1)
            {
                return right;
            }
            else
            {
                times++;
                int middle = (left + right) / 2;
                if (lista2[middle] == target)
                {
                    return middle;
                }
                else if (lista2[middle] < target)
                {
                    return BinarySearch(lista2, target, middle, right, ref times);
                }
                else
                {
                    return BinarySearch(lista2, target, left, middle, ref times);
                }
            }
        }

        #endregion









    }
}
