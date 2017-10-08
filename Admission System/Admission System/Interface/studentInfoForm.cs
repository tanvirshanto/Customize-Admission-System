using Admission_System.DB_linker;
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

namespace Admission_System.Interface
{
    public partial class studentInfoForm : MetroForm
    {
        int paperflg = 0;
        int paymentflg = 0;
        public studentInfoForm()
        {
            InitializeComponent();
        }

        private void studentInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void generalInfo_Click(object sender, EventArgs e)
        {

        }

        private void personalInfo_Click(object sender, EventArgs e)
        {

        }

        private void PscResult_Click(object sender, EventArgs e)
        {
            PscResult.Text = "";
        }

        private void JscResult_Click(object sender, EventArgs e)
        {
            JscResult.Text = "";
        }

        private void SscResult_Click(object sender, EventArgs e)
        {
            SscResult.Text = "";
        }

        private void HscResult_Click(object sender, EventArgs e)
        {
            HscResult.Text = "";
        }

        private void PresentAddress_Click(object sender, EventArgs e)
        {
            PresentAddress.Text = "";
        }

        private void PermanentAddress_Click(object sender, EventArgs e)
        {
            PermanentAddress.Text = "";
        }

        private void PhoneNo_Click(object sender, EventArgs e)
        {
            PhoneNo.Text = "";
        }

        private void Email_Click(object sender, EventArgs e)
        {
            Email.Text = "";
        }

        private void FatherName_Click(object sender, EventArgs e)
        {
            FatherName.Text = "";
        }

        private void FOccupation_Click(object sender, EventArgs e)
        {
            FOccupation.Text = "";
        }

        private void MotherName_Click(object sender, EventArgs e)
        {
            MotherName.Text = "";

        }

        private void MOccupation_Click(object sender, EventArgs e)
        {
            MOccupation.Text = "";
        }

        private void FirstName_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
        }

        private void LastName_Click(object sender, EventArgs e)
        {
            LastName.Text = "";
        }

        private void BloodGroup_Click(object sender, EventArgs e)
        {
            BloodGroup.Text = "";
        }

        

        private void DateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void AdministrationInfo_Click(object sender, EventArgs e)
        {

        }

        private void papersVerify_Click(object sender, EventArgs e)
        {
            this.papersVerify.BackColor = System.Drawing.Color.Green;
            paperflg = 1;
        }

        private void Payments_Click(object sender, EventArgs e)
        {
            this.Payments.BackColor = System.Drawing.Color.Green;
            paymentflg = 1;

        }

        private void messageBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nationality_Click(object sender, EventArgs e)
        {
            nationality.Text = "";
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            maritalStatus.Text="";
        }

        private void year_Click(object sender, EventArgs e)
        {
            year.Text = "";
        }

        private void semester_Click(object sender, EventArgs e)
        {
            semester.Text = "";

        }

        private void dept_Click(object sender, EventArgs e)
        {
            dept.Text = "";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
