using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Vhod
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       

        // buton za 4istene
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();


        }
        //registrirane
        string name1 = "";
        string pas1 = "";
        string email = ""; 
        private void button1_Click(object sender, EventArgs e)
        {
            //kakvo da izvede
            if (textBox1.Text == name1 && textBox2.Text == pas1 && textBox3== pas1 && textBox4.Text==email)
            {
                MessageBox.Show("Вярно име!");
                Form2 forma2 = new Form2();
                Form1 forma1 = new Form1();

                forma2.Show();
                forma1.Close();

            }
            //
            else
            {

                Form3 forma3 = new Form3();
                forma3.Show();
                MessageBox.Show("ГРЕШНО ИМЕ!");

            }
        }
    }
}
