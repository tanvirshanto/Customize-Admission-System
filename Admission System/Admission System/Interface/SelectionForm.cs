using Admission_System.Interface;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admission_System
{
    public partial class Form1 : MetroForm
    {
        public int [] selected;
       // public string dtl;

        public Form1()
        {
            
            selected = new int[6];
            for (int i = 0; i < 5; i++) selected[i] = 0;
            InitializeComponent();
        }

        private void background_Click(object sender, EventArgs e)
        {

        }
   

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (selected[2] == 0)
            {
                this.writtenEaxm.BackColor = System.Drawing.Color.Gray;
                selected[2] = 1;
            }
            else
            {
                selected[2] = 0;
                this.writtenEaxm.BackColor = System.Drawing.Color.Green;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (selected[3] == 0)
            {
                this.viva.BackColor = System.Drawing.Color.Gray;
                selected[3] = 1;
            }
            else
            {
                this.viva.BackColor = System.Drawing.Color.DarkOrange;
                selected[3] = 0;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (selected[1] == 0)
            {
                this.issuePapers.BackColor = System.Drawing.Color.Gray;
                selected[1] = 1;
            }
            else
            {
                this.issuePapers.BackColor = System.Drawing.Color.Yellow;
                selected[1] = 0;
            }

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (selected[0] == 0)
            {
                this.primarySelection.BackColor = System.Drawing.Color.Gray;
                selected[0] = 1;
            }
            else
            {
                selected[0] = 0;
                this.primarySelection.BackColor = System.Drawing.Color.Blue;
            }

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (selected[4] == 0)
            {
                this.quota.BackColor = System.Drawing.Color.Gray;
                selected[4] = 1;
            }
            else
            {
                selected[4] = 0;
                this.quota.BackColor = System.Drawing.Color.Red;
            }

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (selected[5] == 0)
            {
                this.idGenegation.BackColor = System.Drawing.Color.Gray;
                selected[5] = 1;
            }
            else
            {
                selected[5] = 0;
                this.idGenegation.BackColor = System.Drawing.Color.Teal;
            }
        }

        private void next_Click_1(object sender, EventArgs e)
        {
            Home hm = new Home(selected);
            hm.Show();
            this.Hide();    
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }
        

        

        
    }
}
