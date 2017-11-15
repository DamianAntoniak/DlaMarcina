using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Szkola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildGUI(comboBox1.SelectedIndex);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuildGUI(int index)
        {
            switch (index)
            {
                case 0:
                    {
                        Hide(label_B, textBox_B, false);
                        Hide(label_C, textBox_C, false);
                        Hide(label_A, textBox_A, true);
                        label_A.Text = "r =";
                        pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("kolo");
                        
                        break;
                    }
                case 1:
                    {
                        Hide(label_B, textBox_B, false);
                        Hide(label_C, textBox_C, false);
                        Hide(label_A, textBox_A, true);
                        label_A.Text = "a =";
                        pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("kw");
                        break;
                    }
                case 2:
                    {
                        Hide(label_C, textBox_C, false);
                        Hide(label_A, textBox_A, true);
                        Hide(label_B, textBox_B, true);

                        label_A.Text = "a =";
                        label_B.Text = "b =";
                        pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("pro");
                        break;
                    }
            }
        }

        private void Hide(Label l, TextBox b, bool o)
        {
            l.Visible = o;
            b.Visible = o;
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox1.Checked == true)
                {
                    double a = Convert.ToDouble(textBox_A.Text);
                    double result = 3.14 * Math.Pow(a, 2.0);

                    textBox1.Text = "P = " + result.ToString();
                    if (checkBox2.Checked == true) textBox1.Text += "     ";
                }

                if (checkBox2.Checked == true)
                {
                    double a = Convert.ToDouble(textBox_A.Text);
                    double result = 2.0 * 3.14 * a;

                    if (checkBox1.Checked == true) textBox1.Text += "L = " + result.ToString();
                    else textBox1.Text = "L = " + result.ToString();

                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox1.Checked == true)
                {
                    double a = Convert.ToDouble(textBox_A.Text);
                    double result = Math.Pow(a, 2.0);

                    textBox1.Text = "P = " + result.ToString();
                    if (checkBox2.Checked == true) textBox1.Text += "     ";
                }

                if (checkBox2.Checked == true)
                {
                    double a = Convert.ToDouble(textBox_A.Text);
                    double result = 4.0 * a;

                    if (checkBox1.Checked == true) textBox1.Text += "L = " + result.ToString();
                    else textBox1.Text = "L = " + result.ToString();

                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (checkBox1.Checked == true)
                {
                    double a = Convert.ToDouble(textBox_A.Text);
                    double b = Convert.ToDouble(textBox_B.Text);
                    double result = a * b;

                    textBox1.Text = "P = " + result.ToString();
                    if (checkBox2.Checked == true) textBox1.Text += "     ";
                }

                if (checkBox2.Checked == true)
                {
                    double a = Convert.ToDouble(textBox_A.Text);
                    double b = Convert.ToDouble(textBox_B.Text);
                    double result = (2.0 * a) + (2.0 * b);

                    if (checkBox1.Checked == true) textBox1.Text += "L = " + result.ToString();
                    else textBox1.Text = "L = " + result.ToString();

                }
            }
            if (checkBox2.Checked == true || checkBox1.Checked == true) progressBar1.Value = 100;
        }

    }
}
