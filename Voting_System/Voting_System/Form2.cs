using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Voting_System
{
    public partial class Form2 : Form
    {
        Voter v = new Voter(); 
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime cdt, bdt;
            cdt = DateTime.Now;
            bdt = dateTimePicker1.Value;
            int x = cdt.Year;
            int y = bdt.Year;
            int z = x - y;
            if (z > 17)
            {
                v.name = textBox1.Text;
                v.address = textBox2.Text;
                v.dob = bdt;
               //return v;
                label2.Text = "You are registered ! Your redistrationid is : " + v.name+v.dob.Year+v.dob.Day;
                v.registrationid = v.name + v.dob.Year + v.dob.Day;
            }
            else {
                label2.Text = "Sorry, you cannot be registered!";
                //return v;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gettersandsetters.name = v.name;
            Gettersandsetters.address = v.address;
            Gettersandsetters.dob = v.dob;
            Gettersandsetters.registrationid = v.registrationid;
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
