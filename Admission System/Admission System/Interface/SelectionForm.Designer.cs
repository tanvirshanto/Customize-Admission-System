namespace Admission_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.writtenEaxm = new MetroFramework.Controls.MetroButton();
            this.viva = new MetroFramework.Controls.MetroButton();
            this.issuePapers = new MetroFramework.Controls.MetroButton();
            this.primarySelection = new MetroFramework.Controls.MetroButton();
            this.quota = new MetroFramework.Controls.MetroButton();
            this.idGenegation = new MetroFramework.Controls.MetroButton();
            this.next = new MetroFramework.Controls.MetroButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.formContains = new MetroFramework.Controls.MetroTabControl();
            this.admissionProcess = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.personalInfo = new MetroFramework.Controls.MetroButton();
            this.ContactInfo = new MetroFramework.Controls.MetroButton();
            this.generalInfo = new MetroFramework.Controls.MetroButton();
            this.formContains.SuspendLayout();
            this.admissionProcess.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // writtenEaxm
            // 
            this.writtenEaxm.BackColor = System.Drawing.Color.Green;
            this.writtenEaxm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("writtenEaxm.BackgroundImage")));
            this.writtenEaxm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.writtenEaxm.DisplayFocus = true;
            this.writtenEaxm.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.writtenEaxm.Location = new System.Drawing.Point(12, 184);
            this.writtenEaxm.Name = "writtenEaxm";
            this.writtenEaxm.Size = new System.Drawing.Size(81, 86);
            this.writtenEaxm.TabIndex = 6;
            this.writtenEaxm.Text = "Written Eaxm";
            this.writtenEaxm.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.writtenEaxm.UseSelectable = true;
            this.writtenEaxm.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // viva
            // 
            this.viva.BackColor = System.Drawing.Color.DarkOrange;
            this.viva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viva.BackgroundImage")));
            this.viva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.viva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viva.DisplayFocus = true;
            this.viva.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.viva.Location = new System.Drawing.Point(99, 105);
            this.viva.Name = "viva";
            this.viva.Size = new System.Drawing.Size(80, 165);
            this.viva.TabIndex = 6;
            this.viva.Text = "Viva";
            this.viva.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.viva.UseSelectable = true;
            this.viva.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // issuePapers
            // 
            this.issuePapers.BackColor = System.Drawing.Color.Yellow;
            this.issuePapers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("issuePapers.BackgroundImage")));
            this.issuePapers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.issuePapers.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.issuePapers.Location = new System.Drawing.Point(12, 105);
            this.issuePapers.Name = "issuePapers";
            this.issuePapers.Size = new System.Drawing.Size(81, 73);
            this.issuePapers.TabIndex = 7;
            this.issuePapers.Text = "Issue Admit";
            this.issuePapers.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.issuePapers.UseCustomBackColor = true;
            this.issuePapers.UseCustomForeColor = true;
            this.issuePapers.UseSelectable = true;
            this.issuePapers.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // primarySelection
            // 
            this.primarySelection.BackColor = System.Drawing.Color.Blue;
            this.primarySelection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("primarySelection.BackgroundImage")));
            this.primarySelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.primarySelection.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.primarySelection.Location = new System.Drawing.Point(12, 29);
            this.primarySelection.Name = "primarySelection";
            this.primarySelection.Size = new System.Drawing.Size(167, 70);
            this.primarySelection.TabIndex = 8;
            this.primarySelection.Text = "Primary Selection";
            this.primarySelection.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.primarySelection.UseCustomBackColor = true;
            this.primarySelection.UseCustomForeColor = true;
            this.primarySelection.UseSelectable = true;
            this.primarySelection.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // quota
            // 
            this.quota.BackColor = System.Drawing.Color.Red;
            this.quota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quota.BackgroundImage")));
            this.quota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quota.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.quota.Location = new System.Drawing.Point(12, 276);
            this.quota.Name = "quota";
            this.quota.Size = new System.Drawing.Size(81, 80);
            this.quota.TabIndex = 9;
            this.quota.Text = "Quota";
            this.quota.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.quota.UseCustomBackColor = true;
            this.quota.UseCustomForeColor = true;
            this.quota.UseSelectable = true;
            this.quota.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // idGenegation
            // 
            this.idGenegation.BackColor = System.Drawing.Color.Teal;
            this.idGenegation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("idGenegation.BackgroundImage")));
            this.idGenegation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.idGenegation.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.idGenegation.ForeColor = System.Drawing.Color.Black;
            this.idGenegation.Location = new System.Drawing.Point(99, 276);
            this.idGenegation.Name = "idGenegation";
            this.idGenegation.Size = new System.Drawing.Size(80, 80);
            this.idGenegation.TabIndex = 10;
            this.idGenegation.Text = "Id Generation";
            this.idGenegation.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.idGenegation.UseCustomBackColor = true;
            this.idGenegation.UseCustomForeColor = true;
            this.idGenegation.UseSelectable = true;
            this.idGenegation.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.OrangeRed;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.Location = new System.Drawing.Point(594, 538);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(37, 34);
            this.next.TabIndex = 11;
            this.next.UseCustomBackColor = true;
            this.next.UseCustomForeColor = true;
            this.next.UseSelectable = true;
            this.next.Click += new System.EventHandler(this.next_Click_1);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(636, 509);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Green;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 648;
            this.lineShape1.Y1 = 14;
            this.lineShape1.Y2 = 14;
            // 
            // formContains
            // 
            this.formContains.Controls.Add(this.admissionProcess);
            this.formContains.Controls.Add(this.metroTabPage2);
            this.formContains.Location = new System.Drawing.Point(23, 80);
            this.formContains.Name = "formContains";
            this.formContains.SelectedIndex = 0;
            this.formContains.Size = new System.Drawing.Size(643, 449);
            this.formContains.Style = MetroFramework.MetroColorStyle.Green;
            this.formContains.TabIndex = 13;
            this.formContains.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.formContains.UseSelectable = true;
            // 
            // admissionProcess
            // 
            this.admissionProcess.Controls.Add(this.idGenegation);
            this.admissionProcess.Controls.Add(this.primarySelection);
            this.admissionProcess.Controls.Add(this.quota);
            this.admissionProcess.Controls.Add(this.writtenEaxm);
            this.admissionProcess.Controls.Add(this.viva);
            this.admissionProcess.Controls.Add(this.issuePapers);
            this.admissionProcess.HorizontalScrollbarBarColor = true;
            this.admissionProcess.HorizontalScrollbarHighlightOnWheel = false;
            this.admissionProcess.HorizontalScrollbarSize = 10;
            this.admissionProcess.Location = new System.Drawing.Point(4, 38);
            this.admissionProcess.Name = "admissionProcess";
            this.admissionProcess.Size = new System.Drawing.Size(635, 407);
            this.admissionProcess.TabIndex = 0;
            this.admissionProcess.Text = "Process";
            this.admissionProcess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.admissionProcess.VerticalScrollbarBarColor = true;
            this.admissionProcess.VerticalScrollbarHighlightOnWheel = false;
            this.admissionProcess.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton2);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.personalInfo);
            this.metroTabPage2.Controls.Add(this.ContactInfo);
            this.metroTabPage2.Controls.Add(this.generalInfo);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(635, 407);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Form Contains";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Blue;
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Location = new System.Drawing.Point(105, 179);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(85, 74);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "Education Info";
            this.metroButton2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Red;
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(15, 259);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(175, 75);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Administrative Info";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // personalInfo
            // 
            this.personalInfo.BackColor = System.Drawing.Color.Green;
            this.personalInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personalInfo.BackgroundImage")));
            this.personalInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.personalInfo.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.personalInfo.Location = new System.Drawing.Point(15, 125);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(85, 128);
            this.personalInfo.TabIndex = 8;
            this.personalInfo.Text = "Personal Info";
            this.personalInfo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.personalInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.personalInfo.UseCustomBackColor = true;
            this.personalInfo.UseCustomForeColor = true;
            this.personalInfo.UseSelectable = true;
            // 
            // ContactInfo
            // 
            this.ContactInfo.BackColor = System.Drawing.Color.Gold;
            this.ContactInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContactInfo.BackgroundImage")));
            this.ContactInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ContactInfo.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.ContactInfo.ForeColor = System.Drawing.Color.Black;
            this.ContactInfo.Location = new System.Drawing.Point(105, 39);
            this.ContactInfo.Name = "ContactInfo";
            this.ContactInfo.Size = new System.Drawing.Size(85, 134);
            this.ContactInfo.TabIndex = 7;
            this.ContactInfo.Text = "Contact Info";
            this.ContactInfo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ContactInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ContactInfo.UseCustomBackColor = true;
            this.ContactInfo.UseCustomForeColor = true;
            this.ContactInfo.UseSelectable = true;
            // 
            // generalInfo
            // 
            this.generalInfo.BackColor = System.Drawing.Color.GreenYellow;
            this.generalInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generalInfo.BackgroundImage")));
            this.generalInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.generalInfo.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.generalInfo.ForeColor = System.Drawing.Color.Black;
            this.generalInfo.Location = new System.Drawing.Point(15, 39);
            this.generalInfo.Name = "generalInfo";
            this.generalInfo.Size = new System.Drawing.Size(85, 80);
            this.generalInfo.TabIndex = 6;
            this.generalInfo.Text = "General Info";
            this.generalInfo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.generalInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.generalInfo.UseCustomBackColor = true;
            this.generalInfo.UseCustomForeColor = true;
            this.generalInfo.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.ClientSize = new System.Drawing.Size(676, 589);
            this.Controls.Add(this.formContains);
            this.Controls.Add(this.next);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Select";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formContains.ResumeLayout(false);
            this.admissionProcess.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton writtenEaxm;
        private MetroFramework.Controls.MetroButton viva;
        private MetroFramework.Controls.MetroButton issuePapers;
        private MetroFramework.Controls.MetroButton primarySelection;
        private MetroFramework.Controls.MetroButton quota;
        private MetroFramework.Controls.MetroButton idGenegation;
        private MetroFramework.Controls.MetroButton next;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MetroFramework.Controls.MetroTabControl formContains;
        private MetroFramework.Controls.MetroTabPage admissionProcess;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton personalInfo;
        private MetroFramework.Controls.MetroButton ContactInfo;
        private MetroFramework.Controls.MetroButton generalInfo;
    }
}

