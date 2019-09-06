using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustonControl1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustonControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustomController1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            thirdCustomCollection1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            fourCustomController1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            userControl11.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            sixCustomCOntroller1.BringToFront();
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

      
        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Entrou em Opções");
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Entrou em Novidades");
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Entrou em Duvidas");
        }      

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/nicolas.sanchez.370177");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Keyblase/Test-Code");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/nicolas-soares-ba56b4170/");
        }
    }
}
