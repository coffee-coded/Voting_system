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
   
   public partial class Form1 : Form{
       Voter[] voters = new Voter[50];
       //public void 
        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            textBox1.Text = "Registration ID";

        }

        private void textBox1_TextChanged(object sender, EventArgs e){

        }

        private void button1_Click(object sender, EventArgs e){
            string input = textBox1.Text;
            int fl = 0;
            Voter v = new Voter();
            if (voters.Length == 0)
            {
                try
                {
                    for (int i = 0; i < voters.Length; i++)
                        if (voters[i].name == input)
                        {
                            fl = 1;
                            //label1.Text = v.name;
                            //label2.Text = v.address;
                            label1.Text = "Hit";
                            label2.Text = "Hit";
                        }
                }
                catch (Exception E) {
                    Console.WriteLine();
                }
            }
            else {
                label1.Text = "There are no Registrations yet, Please Register";
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
            
        }
   public class Voter
   {
       public string name;
       public string address;
       public DateTime dob;
       public string registrationid;
   }
   public static class Gettersandsetters {
       public static string name { get; set; }
       public static string address { get; set; }
       public static DateTime dob { get; set; }
       public static string registrationid { get; set; }

   }
}
  
   


