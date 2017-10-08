namespace Admission_System.Interface
{
    partial class studentInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentInfoForm));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.form = new MetroFramework.Controls.MetroTabControl();
            this.generalInfo = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DateOfBirth = new MetroFramework.Controls.MetroDateTime();
            this.BloodGroup = new MetroFramework.Controls.MetroTextBox();
            this.LastName = new MetroFramework.Controls.MetroTextBox();
            this.FirstName = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personalInfo = new MetroFramework.Controls.MetroTabPage();
            this.maritalStatus = new MetroFramework.Controls.MetroTextBox();
            this.nationality = new MetroFramework.Controls.MetroTextBox();
            this.MOccupation = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.MotherName = new MetroFramework.Controls.MetroTextBox();
            this.FOccupation = new MetroFramework.Controls.MetroTextBox();
            this.FatherName = new MetroFramework.Controls.MetroTextBox();
            this.contactInfo = new MetroFramework.Controls.MetroTabPage();
            this.Email = new MetroFramework.Controls.MetroTextBox();
            this.PhoneNo = new MetroFramework.Controls.MetroTextBox();
            this.PermanentAddress = new MetroFramework.Controls.MetroTextBox();
            this.PresentAddress = new MetroFramework.Controls.MetroTextBox();
            this.EducationInfo = new MetroFramework.Controls.MetroTabPage();
            this.HscResult = new MetroFramework.Controls.MetroTextBox();
            this.SscResult = new MetroFramework.Controls.MetroTextBox();
            this.JscResult = new MetroFramework.Controls.MetroTextBox();
            this.PscResult = new MetroFramework.Controls.MetroTextBox();
            this.AdministrationInfo = new MetroFramework.Controls.MetroTabPage();
            this.Payments = new MetroFramework.Controls.MetroButton();
            this.papersVerify = new MetroFramework.Controls.MetroButton();
            this.dept = new MetroFramework.Controls.MetroTextBox();
            this.semester = new MetroFramework.Controls.MetroTextBox();
            this.year = new MetroFramework.Controls.MetroTextBox();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.form.SuspendLayout();
            this.generalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.personalInfo.SuspendLayout();
            this.contactInfo.SuspendLayout();
            this.EducationInfo.SuspendLayout();
            this.AdministrationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(679, 399);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Green;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.Green;
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 720;
            this.lineShape1.Y1 = 14;
            this.lineShape1.Y2 = 14;
            // 
            // form
            // 
            this.form.Controls.Add(this.generalInfo);
            this.form.Controls.Add(this.personalInfo);
            this.form.Controls.Add(this.contactInfo);
            this.form.Controls.Add(this.EducationInfo);
            this.form.Controls.Add(this.AdministrationInfo);
            this.form.Location = new System.Drawing.Point(20, 77);
            this.form.Name = "form";
            this.form.SelectedIndex = 4;
            this.form.Size = new System.Drawing.Size(682, 326);
            this.form.Style = MetroFramework.MetroColorStyle.Green;
            this.form.TabIndex = 1;
            this.form.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.form.UseSelectable = true;
            // 
            // generalInfo
            // 
            this.generalInfo.Controls.Add(this.metroLabel1);
            this.generalInfo.Controls.Add(this.DateOfBirth);
            this.generalInfo.Controls.Add(this.BloodGroup);
            this.generalInfo.Controls.Add(this.LastName);
            this.generalInfo.Controls.Add(this.FirstName);
            this.generalInfo.Controls.Add(this.pictureBox1);
            this.generalInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.generalInfo.HorizontalScrollbarBarColor = true;
            this.generalInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.generalInfo.HorizontalScrollbarSize = 10;
            this.generalInfo.Location = new System.Drawing.Point(4, 38);
            this.generalInfo.Name = "generalInfo";
            this.generalInfo.Size = new System.Drawing.Size(674, 284);
            this.generalInfo.TabIndex = 0;
            this.generalInfo.Text = "General Info";
            this.generalInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.generalInfo.VerticalScrollbarBarColor = true;
            this.generalInfo.VerticalScrollbarHighlightOnWheel = false;
            this.generalInfo.VerticalScrollbarSize = 10;
            this.generalInfo.Click += new System.EventHandler(this.generalInfo_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 159);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Date Of Birth";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirth.Location = new System.Drawing.Point(24, 184);
            this.DateOfBirth.MinimumSize = new System.Drawing.Size(4, 29);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(235, 29);
            this.DateOfBirth.Style = MetroFramework.MetroColorStyle.Green;
            this.DateOfBirth.TabIndex = 5;
            this.DateOfBirth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DateOfBirth.ValueChanged += new System.EventHandler(this.DateOfBirth_ValueChanged);
            // 
            // BloodGroup
            // 
            // 
            // 
            // 
            this.BloodGroup.CustomButton.Image = null;
            this.BloodGroup.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.BloodGroup.CustomButton.Name = "";
            this.BloodGroup.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BloodGroup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BloodGroup.CustomButton.TabIndex = 1;
            this.BloodGroup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BloodGroup.CustomButton.UseSelectable = true;
            this.BloodGroup.CustomButton.Visible = false;
            this.BloodGroup.Lines = new string[] {
        "Blood Group"};
            this.BloodGroup.Location = new System.Drawing.Point(24, 241);
            this.BloodGroup.MaxLength = 32767;
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.PasswordChar = '\0';
            this.BloodGroup.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BloodGroup.SelectedText = "";
            this.BloodGroup.SelectionLength = 0;
            this.BloodGroup.SelectionStart = 0;
            this.BloodGroup.Size = new System.Drawing.Size(235, 23);
            this.BloodGroup.Style = MetroFramework.MetroColorStyle.Green;
            this.BloodGroup.TabIndex = 4;
            this.BloodGroup.Text = "Blood Group";
            this.BloodGroup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BloodGroup.UseCustomForeColor = true;
            this.BloodGroup.UseSelectable = true;
            this.BloodGroup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BloodGroup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BloodGroup.Click += new System.EventHandler(this.BloodGroup_Click);
            // 
            // LastName
            // 
            // 
            // 
            // 
            this.LastName.CustomButton.Image = null;
            this.LastName.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.LastName.CustomButton.Name = "";
            this.LastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LastName.CustomButton.TabIndex = 1;
            this.LastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LastName.CustomButton.UseSelectable = true;
            this.LastName.CustomButton.Visible = false;
            this.LastName.Lines = new string[] {
        "Last Name"};
            this.LastName.Location = new System.Drawing.Point(24, 113);
            this.LastName.MaxLength = 32767;
            this.LastName.Name = "LastName";
            this.LastName.PasswordChar = '\0';
            this.LastName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.LastName.SelectedText = "";
            this.LastName.SelectionLength = 0;
            this.LastName.SelectionStart = 0;
            this.LastName.Size = new System.Drawing.Size(235, 23);
            this.LastName.Style = MetroFramework.MetroColorStyle.Green;
            this.LastName.TabIndex = 4;
            this.LastName.Text = "Last Name";
            this.LastName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LastName.UseCustomForeColor = true;
            this.LastName.UseSelectable = true;
            this.LastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LastName.Click += new System.EventHandler(this.LastName_Click);
            // 
            // FirstName
            // 
            // 
            // 
            // 
            this.FirstName.CustomButton.Image = null;
            this.FirstName.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.FirstName.CustomButton.Name = "";
            this.FirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FirstName.CustomButton.TabIndex = 1;
            this.FirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FirstName.CustomButton.UseSelectable = true;
            this.FirstName.CustomButton.Visible = false;
            this.FirstName.Lines = new string[] {
        "First Name"};
            this.FirstName.Location = new System.Drawing.Point(24, 57);
            this.FirstName.MaxLength = 32767;
            this.FirstName.Name = "FirstName";
            this.FirstName.PasswordChar = '\0';
            this.FirstName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FirstName.SelectedText = "";
            this.FirstName.SelectionLength = 0;
            this.FirstName.SelectionStart = 0;
            this.FirstName.Size = new System.Drawing.Size(235, 23);
            this.FirstName.Style = MetroFramework.MetroColorStyle.Green;
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "First Name";
            this.FirstName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FirstName.UseCustomForeColor = true;
            this.FirstName.UseSelectable = true;
            this.FirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(526, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // personalInfo
            // 
            this.personalInfo.Controls.Add(this.maritalStatus);
            this.personalInfo.Controls.Add(this.nationality);
            this.personalInfo.Controls.Add(this.MOccupation);
            this.personalInfo.Controls.Add(this.metroTextBox2);
            this.personalInfo.Controls.Add(this.MotherName);
            this.personalInfo.Controls.Add(this.FOccupation);
            this.personalInfo.Controls.Add(this.FatherName);
            this.personalInfo.HorizontalScrollbarBarColor = true;
            this.personalInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.personalInfo.HorizontalScrollbarSize = 10;
            this.personalInfo.Location = new System.Drawing.Point(4, 38);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(674, 284);
            this.personalInfo.TabIndex = 1;
            this.personalInfo.Text = "Personal Info";
            this.personalInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.personalInfo.VerticalScrollbarBarColor = true;
            this.personalInfo.VerticalScrollbarHighlightOnWheel = false;
            this.personalInfo.VerticalScrollbarSize = 10;
            this.personalInfo.Click += new System.EventHandler(this.personalInfo_Click);
            // 
            // maritalStatus
            // 
            // 
            // 
            // 
            this.maritalStatus.CustomButton.Image = null;
            this.maritalStatus.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.maritalStatus.CustomButton.Name = "";
            this.maritalStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.maritalStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.maritalStatus.CustomButton.TabIndex = 1;
            this.maritalStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.maritalStatus.CustomButton.UseSelectable = true;
            this.maritalStatus.CustomButton.Visible = false;
            this.maritalStatus.Lines = new string[] {
        "Marital status"};
            this.maritalStatus.Location = new System.Drawing.Point(364, 81);
            this.maritalStatus.MaxLength = 32767;
            this.maritalStatus.Name = "maritalStatus";
            this.maritalStatus.PasswordChar = '\0';
            this.maritalStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.maritalStatus.SelectedText = "";
            this.maritalStatus.SelectionLength = 0;
            this.maritalStatus.SelectionStart = 0;
            this.maritalStatus.Size = new System.Drawing.Size(213, 23);
            this.maritalStatus.Style = MetroFramework.MetroColorStyle.Green;
            this.maritalStatus.TabIndex = 7;
            this.maritalStatus.Text = "Marital status";
            this.maritalStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.maritalStatus.UseSelectable = true;
            this.maritalStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.maritalStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.maritalStatus.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // nationality
            // 
            // 
            // 
            // 
            this.nationality.CustomButton.Image = null;
            this.nationality.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.nationality.CustomButton.Name = "";
            this.nationality.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nationality.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nationality.CustomButton.TabIndex = 1;
            this.nationality.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nationality.CustomButton.UseSelectable = true;
            this.nationality.CustomButton.Visible = false;
            this.nationality.Lines = new string[] {
        "Nationality"};
            this.nationality.Location = new System.Drawing.Point(364, 36);
            this.nationality.MaxLength = 32767;
            this.nationality.Name = "nationality";
            this.nationality.PasswordChar = '\0';
            this.nationality.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nationality.SelectedText = "";
            this.nationality.SelectionLength = 0;
            this.nationality.SelectionStart = 0;
            this.nationality.Size = new System.Drawing.Size(213, 23);
            this.nationality.Style = MetroFramework.MetroColorStyle.Green;
            this.nationality.TabIndex = 6;
            this.nationality.Text = "Nationality";
            this.nationality.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nationality.UseSelectable = true;
            this.nationality.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nationality.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nationality.Click += new System.EventHandler(this.nationality_Click);
            // 
            // MOccupation
            // 
            // 
            // 
            // 
            this.MOccupation.CustomButton.Image = null;
            this.MOccupation.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.MOccupation.CustomButton.Name = "";
            this.MOccupation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MOccupation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MOccupation.CustomButton.TabIndex = 1;
            this.MOccupation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MOccupation.CustomButton.UseSelectable = true;
            this.MOccupation.CustomButton.Visible = false;
            this.MOccupation.Lines = new string[] {
        "Occupation"};
            this.MOccupation.Location = new System.Drawing.Point(29, 168);
            this.MOccupation.MaxLength = 32767;
            this.MOccupation.Name = "MOccupation";
            this.MOccupation.PasswordChar = '\0';
            this.MOccupation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MOccupation.SelectedText = "";
            this.MOccupation.SelectionLength = 0;
            this.MOccupation.SelectionStart = 0;
            this.MOccupation.Size = new System.Drawing.Size(223, 23);
            this.MOccupation.Style = MetroFramework.MetroColorStyle.Green;
            this.MOccupation.TabIndex = 5;
            this.MOccupation.Text = "Occupation";
            this.MOccupation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MOccupation.UseSelectable = true;
            this.MOccupation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MOccupation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MOccupation.Click += new System.EventHandler(this.MOccupation_Click);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "Occupation"};
            this.metroTextBox2.Location = new System.Drawing.Point(29, 81);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.Size = new System.Drawing.Size(223, 23);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox2.TabIndex = 3;
            this.metroTextBox2.Text = "Occupation";
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox2.Click += new System.EventHandler(this.FOccupation_Click);
            // 
            // MotherName
            // 
            // 
            // 
            // 
            this.MotherName.CustomButton.Image = null;
            this.MotherName.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.MotherName.CustomButton.Name = "";
            this.MotherName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MotherName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MotherName.CustomButton.TabIndex = 1;
            this.MotherName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MotherName.CustomButton.UseSelectable = true;
            this.MotherName.CustomButton.Visible = false;
            this.MotherName.Lines = new string[] {
        "Mother Name"};
            this.MotherName.Location = new System.Drawing.Point(29, 127);
            this.MotherName.MaxLength = 32767;
            this.MotherName.Name = "MotherName";
            this.MotherName.PasswordChar = '\0';
            this.MotherName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MotherName.SelectedText = "";
            this.MotherName.SelectionLength = 0;
            this.MotherName.SelectionStart = 0;
            this.MotherName.Size = new System.Drawing.Size(223, 23);
            this.MotherName.Style = MetroFramework.MetroColorStyle.Green;
            this.MotherName.TabIndex = 4;
            this.MotherName.Text = "Mother Name";
            this.MotherName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MotherName.UseSelectable = true;
            this.MotherName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MotherName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MotherName.Click += new System.EventHandler(this.MotherName_Click);
            // 
            // FOccupation
            // 
            // 
            // 
            // 
            this.FOccupation.CustomButton.Image = null;
            this.FOccupation.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.FOccupation.CustomButton.Name = "";
            this.FOccupation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FOccupation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FOccupation.CustomButton.TabIndex = 1;
            this.FOccupation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FOccupation.CustomButton.UseSelectable = true;
            this.FOccupation.CustomButton.Visible = false;
            this.FOccupation.Lines = new string[] {
        "Occupation"};
            this.FOccupation.Location = new System.Drawing.Point(29, 81);
            this.FOccupation.MaxLength = 32767;
            this.FOccupation.Name = "FOccupation";
            this.FOccupation.PasswordChar = '\0';
            this.FOccupation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FOccupation.SelectedText = "";
            this.FOccupation.SelectionLength = 0;
            this.FOccupation.SelectionStart = 0;
            this.FOccupation.Size = new System.Drawing.Size(223, 23);
            this.FOccupation.Style = MetroFramework.MetroColorStyle.Green;
            this.FOccupation.TabIndex = 3;
            this.FOccupation.Text = "Occupation";
            this.FOccupation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FOccupation.UseSelectable = true;
            this.FOccupation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FOccupation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FOccupation.Click += new System.EventHandler(this.FOccupation_Click);
            // 
            // FatherName
            // 
            // 
            // 
            // 
            this.FatherName.CustomButton.Image = null;
            this.FatherName.CustomButton.Location = new System.Drawing.Point(201, 1);
            this.FatherName.CustomButton.Name = "";
            this.FatherName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FatherName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FatherName.CustomButton.TabIndex = 1;
            this.FatherName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FatherName.CustomButton.UseSelectable = true;
            this.FatherName.CustomButton.Visible = false;
            this.FatherName.Lines = new string[] {
        "FatherName"};
            this.FatherName.Location = new System.Drawing.Point(29, 36);
            this.FatherName.MaxLength = 32767;
            this.FatherName.Name = "FatherName";
            this.FatherName.PasswordChar = '\0';
            this.FatherName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FatherName.SelectedText = "";
            this.FatherName.SelectionLength = 0;
            this.FatherName.SelectionStart = 0;
            this.FatherName.Size = new System.Drawing.Size(223, 23);
            this.FatherName.Style = MetroFramework.MetroColorStyle.Green;
            this.FatherName.TabIndex = 2;
            this.FatherName.Text = "FatherName";
            this.FatherName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FatherName.UseSelectable = true;
            this.FatherName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FatherName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FatherName.Click += new System.EventHandler(this.FatherName_Click);
            // 
            // contactInfo
            // 
            this.contactInfo.Controls.Add(this.Email);
            this.contactInfo.Controls.Add(this.PhoneNo);
            this.contactInfo.Controls.Add(this.PermanentAddress);
            this.contactInfo.Controls.Add(this.PresentAddress);
            this.contactInfo.HorizontalScrollbarBarColor = true;
            this.contactInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.contactInfo.HorizontalScrollbarSize = 10;
            this.contactInfo.Location = new System.Drawing.Point(4, 38);
            this.contactInfo.Name = "contactInfo";
            this.contactInfo.Size = new System.Drawing.Size(674, 284);
            this.contactInfo.TabIndex = 2;
            this.contactInfo.Text = "Contact Info";
            this.contactInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.contactInfo.VerticalScrollbarBarColor = true;
            this.contactInfo.VerticalScrollbarHighlightOnWheel = false;
            this.contactInfo.VerticalScrollbarSize = 10;
            // 
            // Email
            // 
            // 
            // 
            // 
            this.Email.CustomButton.Image = null;
            this.Email.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.Email.CustomButton.Name = "";
            this.Email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Email.CustomButton.TabIndex = 1;
            this.Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Email.CustomButton.UseSelectable = true;
            this.Email.CustomButton.Visible = false;
            this.Email.Lines = new string[] {
        "Email"};
            this.Email.Location = new System.Drawing.Point(30, 158);
            this.Email.MaxLength = 32767;
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Email.SelectedText = "";
            this.Email.SelectionLength = 0;
            this.Email.SelectionStart = 0;
            this.Email.Size = new System.Drawing.Size(257, 23);
            this.Email.Style = MetroFramework.MetroColorStyle.Green;
            this.Email.TabIndex = 5;
            this.Email.Text = "Email";
            this.Email.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Email.UseSelectable = true;
            this.Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // PhoneNo
            // 
            // 
            // 
            // 
            this.PhoneNo.CustomButton.Image = null;
            this.PhoneNo.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.PhoneNo.CustomButton.Name = "";
            this.PhoneNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PhoneNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PhoneNo.CustomButton.TabIndex = 1;
            this.PhoneNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PhoneNo.CustomButton.UseSelectable = true;
            this.PhoneNo.CustomButton.Visible = false;
            this.PhoneNo.Lines = new string[] {
        "Phone No"};
            this.PhoneNo.Location = new System.Drawing.Point(30, 116);
            this.PhoneNo.MaxLength = 32767;
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.PasswordChar = '\0';
            this.PhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PhoneNo.SelectedText = "";
            this.PhoneNo.SelectionLength = 0;
            this.PhoneNo.SelectionStart = 0;
            this.PhoneNo.Size = new System.Drawing.Size(257, 23);
            this.PhoneNo.Style = MetroFramework.MetroColorStyle.Green;
            this.PhoneNo.TabIndex = 4;
            this.PhoneNo.Text = "Phone No";
            this.PhoneNo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PhoneNo.UseSelectable = true;
            this.PhoneNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PhoneNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PhoneNo.Click += new System.EventHandler(this.PhoneNo_Click);
            // 
            // PermanentAddress
            // 
            // 
            // 
            // 
            this.PermanentAddress.CustomButton.Image = null;
            this.PermanentAddress.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.PermanentAddress.CustomButton.Name = "";
            this.PermanentAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PermanentAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PermanentAddress.CustomButton.TabIndex = 1;
            this.PermanentAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PermanentAddress.CustomButton.UseSelectable = true;
            this.PermanentAddress.CustomButton.Visible = false;
            this.PermanentAddress.Lines = new string[] {
        "Permanent Address"};
            this.PermanentAddress.Location = new System.Drawing.Point(30, 74);
            this.PermanentAddress.MaxLength = 32767;
            this.PermanentAddress.Name = "PermanentAddress";
            this.PermanentAddress.PasswordChar = '\0';
            this.PermanentAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PermanentAddress.SelectedText = "";
            this.PermanentAddress.SelectionLength = 0;
            this.PermanentAddress.SelectionStart = 0;
            this.PermanentAddress.Size = new System.Drawing.Size(257, 23);
            this.PermanentAddress.Style = MetroFramework.MetroColorStyle.Green;
            this.PermanentAddress.TabIndex = 3;
            this.PermanentAddress.Text = "Permanent Address";
            this.PermanentAddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PermanentAddress.UseSelectable = true;
            this.PermanentAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PermanentAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PermanentAddress.Click += new System.EventHandler(this.PermanentAddress_Click);
            // 
            // PresentAddress
            // 
            // 
            // 
            // 
            this.PresentAddress.CustomButton.Image = null;
            this.PresentAddress.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.PresentAddress.CustomButton.Name = "";
            this.PresentAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PresentAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PresentAddress.CustomButton.TabIndex = 1;
            this.PresentAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PresentAddress.CustomButton.UseSelectable = true;
            this.PresentAddress.CustomButton.Visible = false;
            this.PresentAddress.Lines = new string[] {
        "Present Address"};
            this.PresentAddress.Location = new System.Drawing.Point(30, 33);
            this.PresentAddress.MaxLength = 32767;
            this.PresentAddress.Name = "PresentAddress";
            this.PresentAddress.PasswordChar = '\0';
            this.PresentAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PresentAddress.SelectedText = "";
            this.PresentAddress.SelectionLength = 0;
            this.PresentAddress.SelectionStart = 0;
            this.PresentAddress.Size = new System.Drawing.Size(257, 23);
            this.PresentAddress.Style = MetroFramework.MetroColorStyle.Green;
            this.PresentAddress.TabIndex = 2;
            this.PresentAddress.Text = "Present Address";
            this.PresentAddress.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PresentAddress.UseSelectable = true;
            this.PresentAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PresentAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PresentAddress.Click += new System.EventHandler(this.PresentAddress_Click);
            // 
            // EducationInfo
            // 
            this.EducationInfo.Controls.Add(this.HscResult);
            this.EducationInfo.Controls.Add(this.SscResult);
            this.EducationInfo.Controls.Add(this.JscResult);
            this.EducationInfo.Controls.Add(this.PscResult);
            this.EducationInfo.HorizontalScrollbarBarColor = true;
            this.EducationInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.EducationInfo.HorizontalScrollbarSize = 10;
            this.EducationInfo.Location = new System.Drawing.Point(4, 38);
            this.EducationInfo.Name = "EducationInfo";
            this.EducationInfo.Size = new System.Drawing.Size(674, 284);
            this.EducationInfo.TabIndex = 3;
            this.EducationInfo.Text = "Education Info";
            this.EducationInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.EducationInfo.VerticalScrollbarBarColor = true;
            this.EducationInfo.VerticalScrollbarHighlightOnWheel = false;
            this.EducationInfo.VerticalScrollbarSize = 10;
            // 
            // HscResult
            // 
            // 
            // 
            // 
            this.HscResult.CustomButton.Image = null;
            this.HscResult.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.HscResult.CustomButton.Name = "";
            this.HscResult.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.HscResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.HscResult.CustomButton.TabIndex = 1;
            this.HscResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HscResult.CustomButton.UseSelectable = true;
            this.HscResult.CustomButton.Visible = false;
            this.HscResult.Lines = new string[] {
        "HSC Result"};
            this.HscResult.Location = new System.Drawing.Point(30, 173);
            this.HscResult.MaxLength = 32767;
            this.HscResult.Name = "HscResult";
            this.HscResult.PasswordChar = '\0';
            this.HscResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HscResult.SelectedText = "";
            this.HscResult.SelectionLength = 0;
            this.HscResult.SelectionStart = 0;
            this.HscResult.Size = new System.Drawing.Size(243, 23);
            this.HscResult.Style = MetroFramework.MetroColorStyle.Green;
            this.HscResult.TabIndex = 5;
            this.HscResult.Text = "HSC Result";
            this.HscResult.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HscResult.UseSelectable = true;
            this.HscResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.HscResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.HscResult.Click += new System.EventHandler(this.HscResult_Click);
            // 
            // SscResult
            // 
            // 
            // 
            // 
            this.SscResult.CustomButton.Image = null;
            this.SscResult.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.SscResult.CustomButton.Name = "";
            this.SscResult.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SscResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SscResult.CustomButton.TabIndex = 1;
            this.SscResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SscResult.CustomButton.UseSelectable = true;
            this.SscResult.CustomButton.Visible = false;
            this.SscResult.Lines = new string[] {
        "SSC Result"};
            this.SscResult.Location = new System.Drawing.Point(30, 133);
            this.SscResult.MaxLength = 32767;
            this.SscResult.Name = "SscResult";
            this.SscResult.PasswordChar = '\0';
            this.SscResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SscResult.SelectedText = "";
            this.SscResult.SelectionLength = 0;
            this.SscResult.SelectionStart = 0;
            this.SscResult.Size = new System.Drawing.Size(243, 23);
            this.SscResult.Style = MetroFramework.MetroColorStyle.Green;
            this.SscResult.TabIndex = 4;
            this.SscResult.Text = "SSC Result";
            this.SscResult.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SscResult.UseSelectable = true;
            this.SscResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SscResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SscResult.Click += new System.EventHandler(this.SscResult_Click);
            // 
            // JscResult
            // 
            // 
            // 
            // 
            this.JscResult.CustomButton.Image = null;
            this.JscResult.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.JscResult.CustomButton.Name = "";
            this.JscResult.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.JscResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.JscResult.CustomButton.TabIndex = 1;
            this.JscResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.JscResult.CustomButton.UseSelectable = true;
            this.JscResult.CustomButton.Visible = false;
            this.JscResult.Lines = new string[] {
        "JSC Result"};
            this.JscResult.Location = new System.Drawing.Point(30, 90);
            this.JscResult.MaxLength = 32767;
            this.JscResult.Name = "JscResult";
            this.JscResult.PasswordChar = '\0';
            this.JscResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.JscResult.SelectedText = "";
            this.JscResult.SelectionLength = 0;
            this.JscResult.SelectionStart = 0;
            this.JscResult.Size = new System.Drawing.Size(243, 23);
            this.JscResult.Style = MetroFramework.MetroColorStyle.Green;
            this.JscResult.TabIndex = 3;
            this.JscResult.Text = "JSC Result";
            this.JscResult.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.JscResult.UseSelectable = true;
            this.JscResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.JscResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.JscResult.Click += new System.EventHandler(this.JscResult_Click);
            // 
            // PscResult
            // 
            // 
            // 
            // 
            this.PscResult.CustomButton.Image = null;
            this.PscResult.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.PscResult.CustomButton.Name = "";
            this.PscResult.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PscResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PscResult.CustomButton.TabIndex = 1;
            this.PscResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PscResult.CustomButton.UseSelectable = true;
            this.PscResult.CustomButton.Visible = false;
            this.PscResult.Lines = new string[] {
        "PSC Result"};
            this.PscResult.Location = new System.Drawing.Point(30, 47);
            this.PscResult.MaxLength = 32767;
            this.PscResult.Name = "PscResult";
            this.PscResult.PasswordChar = '\0';
            this.PscResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PscResult.SelectedText = "";
            this.PscResult.SelectionLength = 0;
            this.PscResult.SelectionStart = 0;
            this.PscResult.Size = new System.Drawing.Size(243, 23);
            this.PscResult.Style = MetroFramework.MetroColorStyle.Green;
            this.PscResult.TabIndex = 2;
            this.PscResult.Text = "PSC Result";
            this.PscResult.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PscResult.UseSelectable = true;
            this.PscResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PscResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PscResult.Click += new System.EventHandler(this.PscResult_Click);
            // 
            // AdministrationInfo
            // 
            this.AdministrationInfo.Controls.Add(this.Payments);
            this.AdministrationInfo.Controls.Add(this.papersVerify);
            this.AdministrationInfo.Controls.Add(this.dept);
            this.AdministrationInfo.Controls.Add(this.semester);
            this.AdministrationInfo.Controls.Add(this.year);
            this.AdministrationInfo.HorizontalScrollbarBarColor = true;
            this.AdministrationInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.AdministrationInfo.HorizontalScrollbarSize = 10;
            this.AdministrationInfo.Location = new System.Drawing.Point(4, 38);
            this.AdministrationInfo.Name = "AdministrationInfo";
            this.AdministrationInfo.Size = new System.Drawing.Size(674, 284);
            this.AdministrationInfo.TabIndex = 4;
            this.AdministrationInfo.Text = "Administration Info";
            this.AdministrationInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AdministrationInfo.VerticalScrollbarBarColor = true;
            this.AdministrationInfo.VerticalScrollbarHighlightOnWheel = false;
            this.AdministrationInfo.VerticalScrollbarSize = 10;
            this.AdministrationInfo.Click += new System.EventHandler(this.AdministrationInfo_Click);
            // 
            // Payments
            // 
            this.Payments.BackColor = System.Drawing.Color.Gray;
            this.Payments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Payments.BackgroundImage")));
            this.Payments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Payments.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Payments.Location = new System.Drawing.Point(139, 174);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(83, 78);
            this.Payments.TabIndex = 3;
            this.Payments.Text = "Payments";
            this.Payments.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Payments.UseCustomBackColor = true;
            this.Payments.UseCustomForeColor = true;
            this.Payments.UseSelectable = true;
            this.Payments.Click += new System.EventHandler(this.Payments_Click);
            // 
            // papersVerify
            // 
            this.papersVerify.BackColor = System.Drawing.Color.Gray;
            this.papersVerify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("papersVerify.BackgroundImage")));
            this.papersVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.papersVerify.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.papersVerify.Location = new System.Drawing.Point(39, 174);
            this.papersVerify.Name = "papersVerify";
            this.papersVerify.Size = new System.Drawing.Size(83, 78);
            this.papersVerify.Style = MetroFramework.MetroColorStyle.Green;
            this.papersVerify.TabIndex = 3;
            this.papersVerify.Text = "Verified Papers";
            this.papersVerify.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.papersVerify.UseCustomBackColor = true;
            this.papersVerify.UseCustomForeColor = true;
            this.papersVerify.UseSelectable = true;
            this.papersVerify.Click += new System.EventHandler(this.papersVerify_Click);
            // 
            // dept
            // 
            // 
            // 
            // 
            this.dept.CustomButton.Image = null;
            this.dept.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.dept.CustomButton.Name = "";
            this.dept.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dept.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dept.CustomButton.TabIndex = 1;
            this.dept.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dept.CustomButton.UseSelectable = true;
            this.dept.CustomButton.Visible = false;
            this.dept.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dept.Lines = new string[] {
        "Department"};
            this.dept.Location = new System.Drawing.Point(39, 119);
            this.dept.MaxLength = 32767;
            this.dept.Name = "dept";
            this.dept.PasswordChar = '\0';
            this.dept.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dept.SelectedText = "";
            this.dept.SelectionLength = 0;
            this.dept.SelectionStart = 0;
            this.dept.Size = new System.Drawing.Size(183, 23);
            this.dept.Style = MetroFramework.MetroColorStyle.Green;
            this.dept.TabIndex = 2;
            this.dept.Text = "Department";
            this.dept.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dept.UseCustomForeColor = true;
            this.dept.UseSelectable = true;
            this.dept.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dept.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.dept.Click += new System.EventHandler(this.dept_Click);
            // 
            // semester
            // 
            // 
            // 
            // 
            this.semester.CustomButton.Image = null;
            this.semester.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.semester.CustomButton.Name = "";
            this.semester.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.semester.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.semester.CustomButton.TabIndex = 1;
            this.semester.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.semester.CustomButton.UseSelectable = true;
            this.semester.CustomButton.Visible = false;
            this.semester.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.semester.Lines = new string[] {
        "Semester"};
            this.semester.Location = new System.Drawing.Point(39, 75);
            this.semester.MaxLength = 32767;
            this.semester.Name = "semester";
            this.semester.PasswordChar = '\0';
            this.semester.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.semester.SelectedText = "";
            this.semester.SelectionLength = 0;
            this.semester.SelectionStart = 0;
            this.semester.Size = new System.Drawing.Size(183, 23);
            this.semester.Style = MetroFramework.MetroColorStyle.Green;
            this.semester.TabIndex = 2;
            this.semester.Text = "Semester";
            this.semester.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.semester.UseCustomForeColor = true;
            this.semester.UseSelectable = true;
            this.semester.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.semester.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.semester.Click += new System.EventHandler(this.semester_Click);
            // 
            // year
            // 
            // 
            // 
            // 
            this.year.CustomButton.Image = null;
            this.year.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.year.CustomButton.Name = "";
            this.year.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.year.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.year.CustomButton.TabIndex = 1;
            this.year.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.year.CustomButton.UseSelectable = true;
            this.year.CustomButton.Visible = false;
            this.year.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.year.Lines = new string[] {
        "Year"};
            this.year.Location = new System.Drawing.Point(39, 34);
            this.year.MaxLength = 32767;
            this.year.Name = "year";
            this.year.PasswordChar = '\0';
            this.year.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.year.SelectedText = "";
            this.year.SelectionLength = 0;
            this.year.SelectionStart = 0;
            this.year.Size = new System.Drawing.Size(183, 23);
            this.year.Style = MetroFramework.MetroColorStyle.Green;
            this.year.TabIndex = 2;
            this.year.Text = "Year";
            this.year.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.year.UseCustomForeColor = true;
            this.year.UseSelectable = true;
            this.year.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.year.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.year.Click += new System.EventHandler(this.year_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveBtn.Location = new System.Drawing.Point(634, 426);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(62, 30);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.UseCustomBackColor = true;
            this.saveBtn.UseCustomForeColor = true;
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(24, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(295, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Do you want to confirm submition?";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.ForeColor = System.Drawing.Color.Green;
            this.metroButton1.Location = new System.Drawing.Point(514, 221);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 35);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Confirm";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.ForeColor = System.Drawing.Color.Green;
            this.metroButton2.Location = new System.Drawing.Point(608, 221);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(88, 35);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // studentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 479);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.form);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "studentInfoForm";
            this.Opacity = 0.9D;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Form";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.studentInfoForm_Load);
            this.form.ResumeLayout(false);
            this.generalInfo.ResumeLayout(false);
            this.generalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.personalInfo.ResumeLayout(false);
            this.contactInfo.ResumeLayout(false);
            this.EducationInfo.ResumeLayout(false);
            this.AdministrationInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MetroFramework.Controls.MetroTabControl form;
        private MetroFramework.Controls.MetroTabPage generalInfo;
        private MetroFramework.Controls.MetroTabPage personalInfo;
        private MetroFramework.Controls.MetroTabPage contactInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox BloodGroup;
        private MetroFramework.Controls.MetroTextBox LastName;
        private MetroFramework.Controls.MetroTextBox FirstName;
        private MetroFramework.Controls.MetroDateTime DateOfBirth;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox MOccupation;
        private MetroFramework.Controls.MetroTextBox MotherName;
        private MetroFramework.Controls.MetroTextBox FOccupation;
        private MetroFramework.Controls.MetroTextBox FatherName;
        private MetroFramework.Controls.MetroTextBox Email;
        private MetroFramework.Controls.MetroTextBox PhoneNo;
        private MetroFramework.Controls.MetroTextBox PermanentAddress;
        private MetroFramework.Controls.MetroTextBox PresentAddress;
        private MetroFramework.Controls.MetroTabPage EducationInfo;
        private MetroFramework.Controls.MetroTextBox HscResult;
        private MetroFramework.Controls.MetroTextBox SscResult;
        private MetroFramework.Controls.MetroTextBox JscResult;
        private MetroFramework.Controls.MetroTextBox PscResult;
        private MetroFramework.Controls.MetroTabPage AdministrationInfo;
        private MetroFramework.Controls.MetroTextBox dept;
        private MetroFramework.Controls.MetroTextBox semester;
        private MetroFramework.Controls.MetroTextBox year;
        private MetroFramework.Controls.MetroButton Payments;
        private MetroFramework.Controls.MetroButton papersVerify;
        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox maritalStatus;
        private MetroFramework.Controls.MetroTextBox nationality;
    }
}