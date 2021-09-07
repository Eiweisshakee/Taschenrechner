using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (!(string.IsNullOrEmpty(textBox1.Text)) || !(string.IsNullOrEmpty(textBox3.Text)))
                {
                    try
                    {
                        float ersteZahl = float.Parse(textBox1.Text);
                        float zweiteZahl = float.Parse(textBox3.Text);
                        float ergebnis = ersteZahl + zweiteZahl;
                        textBox2.Text = ergebnis.ToString();
                    }
                    catch(Exception e1)
                    {
                        textBox2.Text = "geht nicht!";
                        Console.WriteLine(e1.Message);
                    }
                    
                }
                else
                {
                    textBox1.Text = "ERROR!!!";
                    textBox3.Text = "ERROR!!!";
                }

            }
            else if (radioButton2.Checked)
            {
                if (!(string.IsNullOrEmpty(textBox1.Text)) || !(string.IsNullOrEmpty(textBox3.Text)))
                {
                    try
                    {
                        float ersteZahl = float.Parse(textBox1.Text);
                        float zweiteZahl = float.Parse(textBox3.Text);
                        float ergebnis = ersteZahl - zweiteZahl;
                        textBox2.Text = ergebnis.ToString();
                    }
                    catch (Exception e1)
                    {
                        textBox2.Text = "geht nicht!";
                        Console.WriteLine(e1.Message);
                    }

                }
                else
                {
                    textBox1.Text = "ERROR!!!";
                    textBox3.Text = "ERROR!!!";
                }
            }
            else if (radioButton3.Checked)
            {
                if (!(string.IsNullOrEmpty(textBox1.Text)) || !(string.IsNullOrEmpty(textBox3.Text)))
                {
                    try
                    {
                        float ersteZahl = float.Parse(textBox1.Text);
                        float zweiteZahl = float.Parse(textBox3.Text);
                        float ergebnis = ersteZahl * zweiteZahl;
                        textBox2.Text = ergebnis.ToString();
                    }
                    catch (Exception e1)
                    {
                        textBox2.Text = "geht nicht!";
                        Console.WriteLine(e1.Message);
                    }

                }
                else
                {

                    textBox1.Text = "ERROR!!!";
                    textBox3.Text = "ERROR!!!";
                }
            }
            else if (radioButton4.Checked)
            {
                if (!(string.IsNullOrEmpty(textBox1.Text)) || !(string.IsNullOrEmpty(textBox3.Text)))
                {
                    try
                    {
                        float ersteZahl = float.Parse(textBox1.Text);
                        float zweiteZahl = float.Parse(textBox3.Text);
                        float ergebnis = ersteZahl / zweiteZahl;
                        textBox2.Text = ergebnis.ToString();
                    }
                    catch (Exception e1)
                    {
                        textBox2.Text = "geht nicht!";
                        Console.WriteLine(e1.Message);
                    }

                }
                else
                {
                    textBox1.Text = "ERROR!!!";
                    textBox3.Text = "ERROR!!!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
