using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Run
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.ToString();
            
            try
            {
              System.Diagnostics.Process.Start(str1);   
            }
            catch 
            {
                if (textBox1.Text=="")
                {
                    errorProvider1.SetError(this.textBox1, "Bir Komut Girmelisiniz"); 
                }
                else
                {
                     
                }
                
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox1.TabIndex = 0;

            textBox1.Focus();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }
        private bool ValidateName()
        {
            bool bStatus = true;
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Please enter your Name");
                bStatus = false;
            }
            else
                errorProvider1.SetError(textBox1, "");
            return bStatus;

        }

       

        
     

     

           

    }
}