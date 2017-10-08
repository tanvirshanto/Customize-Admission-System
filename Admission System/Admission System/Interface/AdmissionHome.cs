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
    public partial class Home : MetroForm   
    {
        private int[] sel;
        public Home(int[] x)
        {
            sel = new int[10];
            sel = x;
            InitializeComponent();
        }

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editForm_Click(object sender, EventArgs e)
        {
            studentInfoForm sif = new studentInfoForm();
            sif.Show();
            metroPanel4.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            metroPanel4.Dispose();
            metroPanel5.Location = metroPanel4.Location;
        }
    }
}
