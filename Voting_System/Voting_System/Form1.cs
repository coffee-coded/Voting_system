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

    public partial class Form1 : Form
    {
        static Voter[] voters = new Voter[50];
        static int k = 0;
        static int[] voteings = new int[4];

        public static void push(Voter v)
        {
            voters[k++] = v;

        }
        public static void push_vote(int x)
        {
            voteings[x]++;
        }
        //public void 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Registration ID";
            label1.Text = "";
            label2.Text = "";

        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int fl = 0;
            Voter v = new Voter();
            if (k != 0)
            {
                try
                {
                    for (int i = 0; i < voters.Length; i++)
                    {
                        if (voters[i].registrationid == input)
                        {
                            fl = 1;
                            label1.Text = voters[i].name;
                            label2.Text = voters[i].address;
                            button4.Enabled = true;
                            break;

                        }
                        

                    }
                   
                }
                catch (Exception E)
                {
                    Console.WriteLine();
                }
                if (fl == 0)
                {
                    MessageBox.Show("NOt found");
                    label1.Text = "Not Found !";
                    label2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("There are no Registrations yet, Please Register");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "Party 1 : "+(voteings[0])+ "\nParty 2 : " + (voteings[1])+"\nParty 3 : " + (voteings[2])+"\nParty 4 : " + (voteings[3]);
            MessageBox.Show(s);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    public class Voter
    {
        public string name;
        public string address;
        public DateTime dob;
        public string registrationid;
    }
}
    public class Gettersandsetters {
        public static string name { get; set; }
        public static string address { get; set; }
        public static DateTime dob { get; set; }
        public static string registrationid { get; set; }
        
        
        
    }
