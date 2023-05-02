namespace TestProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            departmentTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numberTextBox = new TextBox();
            label4 = new Label();
            nameTextBox = new TextBox();
            addCourseButton = new Button();
            courseListBox = new ListBox();
            updateCourseButton = new Button();
            courseFilter = new TextBox();
            Title = new Label();
            label5 = new Label();
            courseError = new Label();
            label6 = new Label();
            studentFilter = new TextBox();
            updateStudentButton = new Button();
            studentListBox = new ListBox();
            addStudentButton = new Button();
            label7 = new Label();
            studentMajorTextBox = new TextBox();
            label8 = new Label();
            studentNameTextBox = new TextBox();
            studentError = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            sectionFilter = new TextBox();
            updateSectionButton = new Button();
            sectionListBox = new ListBox();
            addSectionButton = new Button();
            label15 = new Label();
            sectionDayTimeTextBox = new TextBox();
            label16 = new Label();
            sectionInstructorTextBox = new TextBox();
            label17 = new Label();
            sectionCourseTextBox = new TextBox();
            label1 = new Label();
            sectionSemesterTextBox = new TextBox();
            sectionError = new Label();
            instructorError = new Label();
            label19 = new Label();
            label21 = new Label();
            instructorFilter = new TextBox();
            updateInstructorButton = new Button();
            instructorListBox = new ListBox();
            addInstructorButton = new Button();
            label22 = new Label();
            instructorOfficeTextBox = new TextBox();
            label23 = new Label();
            instructorNameTextBox = new TextBox();
            registrationMessage = new Label();
            label20 = new Label();
            label25 = new Label();
            registrationFilter = new TextBox();
            updateGradeButton = new Button();
            registrationListBox = new ListBox();
            addRegistrationButton = new Button();
            label26 = new Label();
            gradeTextBox = new TextBox();
            label27 = new Label();
            registrationStudentTextBox = new TextBox();
            label28 = new Label();
            registrationSectionTextBox = new TextBox();
            label18 = new Label();
            deleteRegistrationButton = new Button();
            SuspendLayout();
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(443, 117);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(219, 27);
            departmentTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 120);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Department:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 164);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Number:";
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(443, 158);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(219, 27);
            numberTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 205);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(443, 202);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(219, 27);
            nameTextBox.TabIndex = 6;
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(413, 238);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(94, 29);
            addCourseButton.TabIndex = 8;
            addCourseButton.Text = "Add Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // courseListBox
            // 
            courseListBox.FormattingEnabled = true;
            courseListBox.HorizontalScrollbar = true;
            courseListBox.ItemHeight = 20;
            courseListBox.Location = new Point(15, 155);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(324, 104);
            courseListBox.TabIndex = 9;
            courseListBox.SelectedIndexChanged += courseListBox_SelectedIndexChanged;
            // 
            // updateCourseButton
            // 
            updateCourseButton.Location = new Point(526, 238);
            updateCourseButton.Name = "updateCourseButton";
            updateCourseButton.Size = new Size(126, 29);
            updateCourseButton.TabIndex = 10;
            updateCourseButton.Text = "Update Course";
            updateCourseButton.UseVisualStyleBackColor = true;
            updateCourseButton.Click += updateCourseButton_Click;
            // 
            // courseFilter
            // 
            courseFilter.Location = new Point(103, 122);
            courseFilter.Name = "courseFilter";
            courseFilter.Size = new Size(125, 27);
            courseFilter.TabIndex = 12;
            courseFilter.TextChanged += courseFilter_TextChanged;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(513, 9);
            Title.Name = "Title";
            Title.Size = new Size(312, 50);
            Title.TabIndex = 13;
            Title.Text = "Class Registration";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 125);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 14;
            label5.Text = "Search:";
            // 
            // courseError
            // 
            courseError.AutoSize = true;
            courseError.BackColor = SystemColors.Control;
            courseError.ForeColor = Color.Red;
            courseError.Location = new Point(413, 85);
            courseError.Name = "courseError";
            courseError.Size = new Size(0, 20);
            courseError.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(750, 466);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 26;
            label6.Text = "Search:";
            // 
            // studentFilter
            // 
            studentFilter.Location = new Point(818, 463);
            studentFilter.Name = "studentFilter";
            studentFilter.Size = new Size(125, 27);
            studentFilter.TabIndex = 25;
            studentFilter.TextChanged += studentFilter_TextChanged;
            // 
            // updateStudentButton
            // 
            updateStudentButton.Location = new Point(1213, 583);
            updateStudentButton.Name = "updateStudentButton";
            updateStudentButton.Size = new Size(126, 29);
            updateStudentButton.TabIndex = 24;
            updateStudentButton.Text = "Update Student";
            updateStudentButton.UseVisualStyleBackColor = true;
            updateStudentButton.Click += updateStudentButton_Click;
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.HorizontalScrollbar = true;
            studentListBox.ItemHeight = 20;
            studentListBox.Location = new Point(605, 503);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(449, 104);
            studentListBox.TabIndex = 23;
            studentListBox.SelectedIndexChanged += studentListBox_SelectedIndexChanged;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(1089, 583);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(105, 29);
            addStudentButton.TabIndex = 22;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1073, 547);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 21;
            label7.Text = "Major:";
            // 
            // studentMajorTextBox
            // 
            studentMajorTextBox.Location = new Point(1130, 547);
            studentMajorTextBox.Name = "studentMajorTextBox";
            studentMajorTextBox.Size = new Size(219, 27);
            studentMajorTextBox.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1072, 509);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(52, 20);
            label8.TabIndex = 19;
            label8.Text = "Name:";
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Location = new Point(1130, 503);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.Size = new Size(219, 27);
            studentNameTextBox.TabIndex = 18;
            // 
            // studentError
            // 
            studentError.AutoSize = true;
            studentError.BackColor = SystemColors.Control;
            studentError.ForeColor = Color.Red;
            studentError.Location = new Point(1059, 448);
            studentError.Name = "studentError";
            studentError.Size = new Size(0, 20);
            studentError.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(175, 55);
            label10.Name = "label10";
            label10.Size = new Size(124, 41);
            label10.TabIndex = 28;
            label10.Text = "Courses";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(920, 386);
            label11.Name = "label11";
            label11.Size = new Size(134, 41);
            label11.TabIndex = 29;
            label11.Text = "Students";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(818, 108);
            label12.Name = "label12";
            label12.Size = new Size(129, 41);
            label12.TabIndex = 42;
            label12.Text = "Sections";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(1149, 159);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 41;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(695, 194);
            label14.Name = "label14";
            label14.Size = new Size(56, 20);
            label14.TabIndex = 40;
            label14.Text = "Search:";
            // 
            // sectionFilter
            // 
            sectionFilter.Location = new Point(763, 191);
            sectionFilter.Name = "sectionFilter";
            sectionFilter.Size = new Size(125, 27);
            sectionFilter.TabIndex = 39;
            sectionFilter.TextChanged += sectionFilter_TextChanged;
            // 
            // updateSectionButton
            // 
            updateSectionButton.Location = new Point(1262, 302);
            updateSectionButton.Name = "updateSectionButton";
            updateSectionButton.Size = new Size(126, 29);
            updateSectionButton.TabIndex = 38;
            updateSectionButton.Text = "Update Section";
            updateSectionButton.UseVisualStyleBackColor = true;
            updateSectionButton.Click += updateSectionButton_Click;
            // 
            // sectionListBox
            // 
            sectionListBox.FormattingEnabled = true;
            sectionListBox.HorizontalScrollbar = true;
            sectionListBox.ItemHeight = 20;
            sectionListBox.Location = new Point(675, 224);
            sectionListBox.Name = "sectionListBox";
            sectionListBox.Size = new Size(401, 104);
            sectionListBox.TabIndex = 37;
            sectionListBox.SelectedIndexChanged += sectionListBox_SelectedIndexChanged;
            // 
            // addSectionButton
            // 
            addSectionButton.Location = new Point(1138, 302);
            addSectionButton.Name = "addSectionButton";
            addSectionButton.Size = new Size(105, 29);
            addSectionButton.TabIndex = 36;
            addSectionButton.Text = "Add Section";
            addSectionButton.UseVisualStyleBackColor = true;
            addSectionButton.Click += addSectionButton_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1096, 260);
            label15.Name = "label15";
            label15.Size = new Size(77, 20);
            label15.TabIndex = 35;
            label15.Text = "Day/Time:";
            // 
            // sectionDayTimeTextBox
            // 
            sectionDayTimeTextBox.Location = new Point(1179, 257);
            sectionDayTimeTextBox.Name = "sectionDayTimeTextBox";
            sectionDayTimeTextBox.Size = new Size(219, 27);
            sectionDayTimeTextBox.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1082, 225);
            label16.Name = "label16";
            label16.Size = new Size(91, 20);
            label16.TabIndex = 33;
            label16.Text = "Instructor Id:";
            // 
            // sectionInstructorTextBox
            // 
            sectionInstructorTextBox.Location = new Point(1179, 222);
            sectionInstructorTextBox.Name = "sectionInstructorTextBox";
            sectionInstructorTextBox.Size = new Size(219, 27);
            sectionInstructorTextBox.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1099, 191);
            label17.Name = "label17";
            label17.Size = new Size(74, 20);
            label17.TabIndex = 31;
            label17.Text = "Course Id:";
            // 
            // sectionCourseTextBox
            // 
            sectionCourseTextBox.Location = new Point(1179, 191);
            sectionCourseTextBox.Name = "sectionCourseTextBox";
            sectionCourseTextBox.Size = new Size(219, 27);
            sectionCourseTextBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1100, 159);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 43;
            label1.Text = "Semester:";
            // 
            // sectionSemesterTextBox
            // 
            sectionSemesterTextBox.Location = new Point(1179, 156);
            sectionSemesterTextBox.Name = "sectionSemesterTextBox";
            sectionSemesterTextBox.Size = new Size(219, 27);
            sectionSemesterTextBox.TabIndex = 44;
            // 
            // sectionError
            // 
            sectionError.AutoSize = true;
            sectionError.BackColor = SystemColors.Control;
            sectionError.ForeColor = Color.Red;
            sectionError.Location = new Point(1012, 95);
            sectionError.Name = "sectionError";
            sectionError.Size = new Size(0, 20);
            sectionError.TabIndex = 45;
            // 
            // instructorError
            // 
            instructorError.AutoSize = true;
            instructorError.BackColor = SystemColors.Control;
            instructorError.ForeColor = Color.Red;
            instructorError.Location = new Point(385, 311);
            instructorError.Name = "instructorError";
            instructorError.Size = new Size(0, 20);
            instructorError.TabIndex = 61;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(175, 287);
            label19.Name = "label19";
            label19.Size = new Size(158, 41);
            label19.TabIndex = 58;
            label19.Text = "Instructors";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(35, 335);
            label21.Name = "label21";
            label21.Size = new Size(56, 20);
            label21.TabIndex = 56;
            label21.Text = "Search:";
            // 
            // instructorFilter
            // 
            instructorFilter.Location = new Point(103, 332);
            instructorFilter.Name = "instructorFilter";
            instructorFilter.Size = new Size(125, 27);
            instructorFilter.TabIndex = 55;
            instructorFilter.TextChanged += instructorFilter_TextChanged;
            // 
            // updateInstructorButton
            // 
            updateInstructorButton.Enabled = false;
            updateInstructorButton.Location = new Point(513, 448);
            updateInstructorButton.Name = "updateInstructorButton";
            updateInstructorButton.Size = new Size(139, 29);
            updateInstructorButton.TabIndex = 54;
            updateInstructorButton.Text = "Update Instructor";
            updateInstructorButton.UseVisualStyleBackColor = true;
            updateInstructorButton.Click += updateInstructorButton_Click;
            // 
            // instructorListBox
            // 
            instructorListBox.FormattingEnabled = true;
            instructorListBox.HorizontalScrollbar = true;
            instructorListBox.ItemHeight = 20;
            instructorListBox.Location = new Point(15, 365);
            instructorListBox.Name = "instructorListBox";
            instructorListBox.Size = new Size(324, 104);
            instructorListBox.TabIndex = 53;
            instructorListBox.SelectedIndexChanged += instructorListBox_SelectedIndexChanged;
            // 
            // addInstructorButton
            // 
            addInstructorButton.Location = new Point(362, 448);
            addInstructorButton.Name = "addInstructorButton";
            addInstructorButton.Size = new Size(145, 29);
            addInstructorButton.TabIndex = 52;
            addInstructorButton.Text = "Add Instructor";
            addInstructorButton.UseVisualStyleBackColor = true;
            addInstructorButton.Click += addInstructor_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(385, 403);
            label22.Name = "label22";
            label22.Size = new Size(52, 20);
            label22.TabIndex = 51;
            label22.Text = "Office:";
            // 
            // instructorOfficeTextBox
            // 
            instructorOfficeTextBox.Location = new Point(443, 403);
            instructorOfficeTextBox.Name = "instructorOfficeTextBox";
            instructorOfficeTextBox.Size = new Size(219, 27);
            instructorOfficeTextBox.TabIndex = 50;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(385, 368);
            label23.Name = "label23";
            label23.Size = new Size(52, 20);
            label23.TabIndex = 49;
            label23.Text = "Name:";
            // 
            // instructorNameTextBox
            // 
            instructorNameTextBox.Location = new Point(443, 368);
            instructorNameTextBox.Name = "instructorNameTextBox";
            instructorNameTextBox.Size = new Size(219, 27);
            instructorNameTextBox.TabIndex = 48;
            // 
            // registrationMessage
            // 
            registrationMessage.AutoSize = true;
            registrationMessage.BackColor = SystemColors.Control;
            registrationMessage.ForeColor = Color.Red;
            registrationMessage.Location = new Point(761, 636);
            registrationMessage.Name = "registrationMessage";
            registrationMessage.Size = new Size(0, 20);
            registrationMessage.TabIndex = 77;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(562, 619);
            label20.Name = "label20";
            label20.Size = new Size(189, 41);
            label20.TabIndex = 74;
            label20.Text = "Registrations";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(521, 683);
            label25.Name = "label25";
            label25.Size = new Size(56, 20);
            label25.TabIndex = 72;
            label25.Text = "Search:";
            // 
            // registrationFilter
            // 
            registrationFilter.Location = new Point(589, 680);
            registrationFilter.Name = "registrationFilter";
            registrationFilter.Size = new Size(125, 27);
            registrationFilter.TabIndex = 71;
            registrationFilter.TextChanged += registrationFilter_TextChanged;
            // 
            // updateGradeButton
            // 
            updateGradeButton.Enabled = false;
            updateGradeButton.Location = new Point(1196, 796);
            updateGradeButton.Name = "updateGradeButton";
            updateGradeButton.Size = new Size(126, 29);
            updateGradeButton.TabIndex = 70;
            updateGradeButton.Text = "Update Grade";
            updateGradeButton.UseVisualStyleBackColor = true;
            updateGradeButton.Click += updateGradeButton_Click;
            // 
            // registrationListBox
            // 
            registrationListBox.FormattingEnabled = true;
            registrationListBox.HorizontalScrollbar = true;
            registrationListBox.ItemHeight = 20;
            registrationListBox.Location = new Point(15, 713);
            registrationListBox.Name = "registrationListBox";
            registrationListBox.Size = new Size(810, 104);
            registrationListBox.TabIndex = 69;
            registrationListBox.SelectedIndexChanged += registrationListBox_SelectedIndexChanged;
            // 
            // addRegistrationButton
            // 
            addRegistrationButton.Enabled = false;
            addRegistrationButton.Location = new Point(841, 796);
            addRegistrationButton.Name = "addRegistrationButton";
            addRegistrationButton.Size = new Size(158, 29);
            addRegistrationButton.TabIndex = 68;
            addRegistrationButton.Text = "Add Registration";
            addRegistrationButton.UseVisualStyleBackColor = true;
            addRegistrationButton.Click += addRegistrationButton_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(842, 762);
            label26.Name = "label26";
            label26.Size = new Size(52, 20);
            label26.TabIndex = 67;
            label26.Text = "Grade:";
            // 
            // gradeTextBox
            // 
            gradeTextBox.Location = new Point(902, 762);
            gradeTextBox.Name = "gradeTextBox";
            gradeTextBox.Size = new Size(487, 27);
            gradeTextBox.TabIndex = 66;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(828, 730);
            label27.Name = "label27";
            label27.Size = new Size(63, 20);
            label27.TabIndex = 65;
            label27.Text = "Student:";
            // 
            // registrationStudentTextBox
            // 
            registrationStudentTextBox.Location = new Point(902, 727);
            registrationStudentTextBox.Name = "registrationStudentTextBox";
            registrationStudentTextBox.ReadOnly = true;
            registrationStudentTextBox.Size = new Size(487, 27);
            registrationStudentTextBox.TabIndex = 64;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(830, 683);
            label28.Name = "label28";
            label28.Size = new Size(61, 20);
            label28.TabIndex = 63;
            label28.Text = "Section:";
            // 
            // registrationSectionTextBox
            // 
            registrationSectionTextBox.Location = new Point(902, 670);
            registrationSectionTextBox.Multiline = true;
            registrationSectionTextBox.Name = "registrationSectionTextBox";
            registrationSectionTextBox.ReadOnly = true;
            registrationSectionTextBox.Size = new Size(487, 51);
            registrationSectionTextBox.TabIndex = 62;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(76, 596);
            label18.Name = "label18";
            label18.Size = new Size(414, 100);
            label18.TabIndex = 78;
            label18.Text = resources.GetString("label18.Text");
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteRegistrationButton
            // 
            deleteRegistrationButton.Enabled = false;
            deleteRegistrationButton.Location = new Point(1020, 796);
            deleteRegistrationButton.Name = "deleteRegistrationButton";
            deleteRegistrationButton.Size = new Size(158, 29);
            deleteRegistrationButton.TabIndex = 79;
            deleteRegistrationButton.Text = "Delete Registration";
            deleteRegistrationButton.UseVisualStyleBackColor = true;
            deleteRegistrationButton.Click += deleteRegistrationButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 817);
            Controls.Add(deleteRegistrationButton);
            Controls.Add(label18);
            Controls.Add(registrationMessage);
            Controls.Add(label20);
            Controls.Add(label25);
            Controls.Add(registrationFilter);
            Controls.Add(updateGradeButton);
            Controls.Add(registrationListBox);
            Controls.Add(addRegistrationButton);
            Controls.Add(label26);
            Controls.Add(gradeTextBox);
            Controls.Add(label27);
            Controls.Add(registrationStudentTextBox);
            Controls.Add(label28);
            Controls.Add(registrationSectionTextBox);
            Controls.Add(instructorError);
            Controls.Add(label19);
            Controls.Add(label21);
            Controls.Add(instructorFilter);
            Controls.Add(updateInstructorButton);
            Controls.Add(instructorListBox);
            Controls.Add(addInstructorButton);
            Controls.Add(label22);
            Controls.Add(instructorOfficeTextBox);
            Controls.Add(label23);
            Controls.Add(instructorNameTextBox);
            Controls.Add(sectionError);
            Controls.Add(sectionSemesterTextBox);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(sectionFilter);
            Controls.Add(updateSectionButton);
            Controls.Add(sectionListBox);
            Controls.Add(addSectionButton);
            Controls.Add(label15);
            Controls.Add(sectionDayTimeTextBox);
            Controls.Add(label16);
            Controls.Add(sectionInstructorTextBox);
            Controls.Add(label17);
            Controls.Add(sectionCourseTextBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(studentError);
            Controls.Add(label6);
            Controls.Add(studentFilter);
            Controls.Add(updateStudentButton);
            Controls.Add(studentListBox);
            Controls.Add(addStudentButton);
            Controls.Add(label7);
            Controls.Add(studentMajorTextBox);
            Controls.Add(label8);
            Controls.Add(studentNameTextBox);
            Controls.Add(courseError);
            Controls.Add(label5);
            Controls.Add(Title);
            Controls.Add(courseFilter);
            Controls.Add(updateCourseButton);
            Controls.Add(courseListBox);
            Controls.Add(addCourseButton);
            Controls.Add(label4);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(numberTextBox);
            Controls.Add(label2);
            Controls.Add(departmentTextBox);
            Name = "Form1";
            Text = "Class Registration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox departmentTextBox;
        private Label label2;
        private Label label3;
        private TextBox numberTextBox;
        private Label label4;
        private TextBox nameTextBox;
        private Button addCourseButton;
        private ListBox courseListBox;
        private Button updateCourseButton;
        private TextBox courseFilter;
        private Label Title;
        private Label label5;
        private Label courseError;
        private Label label1;
        private Label label6;
        private TextBox studentFilter;
        private Button updateStudentButton;
        private ListBox studentListBox;
        private Button addStudentButton;
        private Label label7;
        private TextBox studentMajorTextBox;
        private Label label8;
        private TextBox studentNameTextBox;
        private Label sectionError;
        private TextBox textBox4;
        private Label studentError;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox sectionFilter;
        private Button updateSectionButton;
        private ListBox sectionListBox;
        private Button addSectionButton;
        private Label label15;
        private TextBox sectionDayTimeTextBox;
        private Label label16;
        private TextBox sectionInstructorTextBox;
        private Label label17;
        private TextBox sectionCourseTextBox;
        private TextBox sectionSemesterTextBox;
        private Label instructorError;
        private Label label19;
        private Label label21;
        private TextBox instructorFilter;
        private Button updateInstructorButton;
        private ListBox instructorListBox;
        private Button addInstructorButton;
        private Label label22;
        private TextBox instructorOfficeTextBox;
        private Label label23;
        private TextBox instructorNameTextBox;
        private Label registrationMessage;
        private Label label20;
        private Label label25;
        private TextBox registrationFilter;
        private Button updateGradeButton;
        private ListBox registrationListBox;
        private Button addRegistrationButton;
        private Label label26;
        private TextBox gradeTextBox;
        private Label label27;
        private TextBox registrationStudentTextBox;
        private Label label28;
        private TextBox registrationSectionTextBox;
        private Label label18;
        private Button deleteRegistrationButton;
    }
}