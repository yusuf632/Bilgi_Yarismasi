using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button2.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button3.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button4.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button1.Text;
            if(label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;

            soruno++;
            label4.Text = soruno.ToString();

            if(soruno == 1)
            {
                richTextBox1.Text = "Hangisi tek sayıdır?";
                button1.Text = "124";
                button2.Text = "486";
                button3.Text = "173";
                button4.Text = "998";
                label7.Text = "173";
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "Suç ve Ceza Kitabının yazarı kimdir?";
                button1.Text = "Carlo Collodi";
                button2.Text = "Conan Doyle";
                button3.Text = "Fydor Dostoyevski";
                button4.Text = "Jack London";
                label7.Text = "Fydor Dostoyevski";
                button5.Text = "Sonuçlar";
            }
            if(soruno == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

                MessageBox.Show("Doğru:" + dogru + "\n" + "Yanlış:" + yanlis);
            }
        }
    }
}
