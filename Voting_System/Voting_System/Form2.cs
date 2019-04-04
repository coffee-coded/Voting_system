using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Voting_System
{
    public partial class Form2 : Form
    {
        Voter v = new Voter();
        int flag=0,exception=0;
        public Form2()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exception = 0;
            DateTime cdt, bdt;
            cdt = DateTime.Now;
            bdt = dateTimePicker1.Value;
            int x = cdt.Year;
            int y = bdt.Year;
            int z = x - y;
            if (z > 17 && textBox3.Text!="Password")
            {
                flag = 1;
                v.name = textBox1.Text;
                v.address = textBox2.Text;
                v.dob = bdt;
                v.passwordhash = ComputeSha256Hash(textBox3.Text);
                //MessageBox.Show(v.passwordhash);
               //return v;
                label2.Text = "You are registered ! Your redistrationid is : " + v.name+v.dob.Year+v.dob.Day;
                MessageBox.Show("You are registered ! Your redistrationid is : " + v.name + v.dob.Year + v.dob.Day);
                v.registrationid = v.name + v.dob.Year + v.dob.Day;
            }
            else {
                if (textBox3.Text == "Password")
                    MessageBox.Show("Please set a password");
                label2.Text = "Sorry, you cannot be registered!";
                
                //return v;
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            exception = 0;
        }
        private void textBox1_Click(object sender, System.EventArgs e)
        {
            textBox1.SelectAll();
        }
        private void textBox2_Click(object sender, System.EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            exception = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            exception = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0 && exception==0)
            {
                MessageBox.Show("You are not registered yet");
                exception = 1;
            }
            else
            {
                if (flag == 1)
                {
                    Gettersandsetters.name = v.name;
                    Gettersandsetters.address = v.address;
                    Gettersandsetters.dob = v.dob;
                    Gettersandsetters.registrationid = v.registrationid;
                    Gettersandsetters.passwordhash = v.passwordhash;
                    Form1.push(v);
                }

                this.Hide();
                Form1 f1 = new Form1();
                //f1.Show();
            }
        }
    }
}
