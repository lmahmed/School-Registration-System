using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.Devices;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();

            updateDataSourceForCourseListBox();
            updateDataSourceForStudentListBox();
            updateDataSourceForSectionListBox();
            updateDataSourceForInstructorListBox();
            updateDataSourceForRegistrationListBox();



        }

        //start updateListBoxes
        private void updateDataSourceForCourseListBox()
        {
            using (var database = new Database1MdfContext())
            {
                List<Course> courses;
                if (courseFilter.Text.IsNullOrEmpty())
                {
                    courses = database.Courses.ToList();
                }
                else
                {
                    var query = database.Courses.Where(c => ("Course ID: " + c.Id + " " + c.Department + " " + c.Number + " " + c.Name).ToLower().Contains(courseFilter.Text.ToLower()));
                    courses = query.ToList();
                }


                courseListBox.DataSource = courses;
                courseListBox.DisplayMember = "FullDescription";
                courseError.Text = "";
                courseListBox.ClearSelected();
            }
        }

        private void updateDataSourceForStudentListBox()
        {
            using (var database = new Database1MdfContext())
            {
                List<Student> students;
                if (studentFilter.Text.IsNullOrEmpty())
                {
                    students = database.Students.ToList();
                }
                else
                {
                    var query = database.Students.Where(c => ("Student ID: " + c.Id + " " + c.Name + " Major: " + c.Major).ToLower().Contains(studentFilter.Text.ToLower()));
                    students = query.ToList();
                }


                studentListBox.DataSource = students;
                studentListBox.DisplayMember = "FullDescription";
                studentError.Text = "";
                studentListBox.ClearSelected();
            }
        }

        private void updateDataSourceForSectionListBox()
        {
            using (var database = new Database1MdfContext())
            {
                List<Section> sections;
                if (sectionFilter.Text.IsNullOrEmpty())
                {
                    sections = database.Sections
                        .Include(s => s.Course)
                        .Include(s => s.Instructor)
                        .ToList();
                }
                else
                {
                    var query = database.Sections.Where(c => ("Section ID: " + c.Id + " " + c.Semester + " " + c.Course.Department + " " + c.Course.Number + "-" + c.Course.Name + " with Instructor ID: " + c.InstructorId + " " + c.Instructor.Name + " Day/Time: " + c.DayTime).ToLower().Contains(sectionFilter.Text.ToLower()));
                    sections = query
                        .Include(s => s.Course)
                        .Include(s => s.Instructor)
                        .ToList();
                }


                sectionListBox.DataSource = sections;
                sectionListBox.DisplayMember = "FullDescription";
                sectionError.Text = "";
                sectionListBox.ClearSelected();
            }
        }

        private void updateDataSourceForInstructorListBox()
        {
            using (var database = new Database1MdfContext())
            {
                List<Instructor> instructors;
                if (instructorFilter.Text.IsNullOrEmpty())
                {
                    instructors = database.Instructors.ToList();
                }
                else
                {
                    var query = database.Instructors.Where(c => ("Instructor ID: " + c.Id + " " + c.Name + " : " + c.OfficeLocation).ToLower().Contains(instructorFilter.Text.ToLower()));
                    instructors = query.ToList();
                }

                instructorListBox.DataSource = instructors;
                instructorListBox.DisplayMember = "FullDescription";
                instructorError.Text = "";
                instructorListBox.ClearSelected();
            }
        }

        private void updateDataSourceForRegistrationListBox()
        {
            using (var database = new Database1MdfContext())
            {
                List<Registration> registrations;
                if (registrationFilter.Text.IsNullOrEmpty())
                {
                    registrations = database.Registrations
                        .Include(s => s.Student)
                        .Include(s => s.Section).ThenInclude(s => s.Course)
                        .Include(s => s.Section).ThenInclude(s => s.Instructor)
                        .ToList();
                }
                else
                {
                    var query = database.Registrations.Where(c => ("Registration ID: " + c.Id + " Student ID: " + c.StudentId + " " + c.Student.Name + " " + c.Section.Semester + " " +
                    c.Section.Course.Department + " " + c.Section.Course.Number + "-" + c.Section.Course.Name + " with Instructor ID: " + c.Section.InstructorId + " " + c.Section.Instructor.Name +
                    " Day/Time: " + c.Section.DayTime).ToLower().Contains(registrationFilter.Text.ToLower()));

                    registrations = query
                        .Include(s => s.Student)
                        .Include(s => s.Section).ThenInclude(s => s.Course)
                        .Include(s => s.Section).ThenInclude(s => s.Instructor)
                        .ToList();
                }


                registrationListBox.DataSource = registrations;
                registrationListBox.DisplayMember = "FullDescription";
                registrationMessage.Text = "";

                registrationListBox.ClearSelected();
            }
        }


        //end updateListBoxes 


        // chat gpt
        // "how do you bind an entity framework core table to a list box in .net core forms"
        // "how do i handle clicking on an item in the list box"

        //all add Buttons
        private void addCourseButton_Click(object sender, EventArgs e)
        {
            Course course = new Course()
            {
                Name = nameTextBox.Text,
                Number = numberTextBox.Text,
                Department = departmentTextBox.Text
            };

            using (var database = new Database1MdfContext())
            {
                if (database.Courses.Any(c => c.Name == course.Name && c.Number == course.Number && c.Department == course.Department))
                {
                    courseError.Text = "Duplicate course found! Try again!";
                    return;
                }


                database.Courses.Add(course);
                // the nice thing to do is to use async not lock the UI
                database.SaveChanges();
                nameTextBox.Text = "";
                numberTextBox.Text = "";
                departmentTextBox.Text = "";
                courseError.Text = "";
            }

            updateDataSourceForCourseListBox();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = studentNameTextBox.Text,
                Major = studentMajorTextBox.Text,
            };

            using (var database = new Database1MdfContext())
            {
                if (database.Students.Any(c => c.Name == student.Name && c.Major == student.Major))
                {
                    studentError.Text = "Duplicate student found! Try again!";
                    return;
                }


                database.Students.Add(student);
                // the nice thing to do is to use async not lock the UI
                database.SaveChanges();
                studentNameTextBox.Text = "";
                studentMajorTextBox.Text = "";
                studentError.Text = "";
            }

            updateDataSourceForStudentListBox();
        }

        private void addSectionButton_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            try
            {
                section.CourseId = Int32.Parse(sectionCourseTextBox.Text);
                section.Semester = sectionSemesterTextBox.Text;
                section.DayTime = sectionDayTimeTextBox.Text;
                section.InstructorId = Int32.Parse(sectionInstructorTextBox.Text);

            }
            catch
            {
                sectionError.Text = "Enter numeric values for Course Id and Instructor Id. Try again!";
                return;
            }

            using (var database = new Database1MdfContext())
            {
                if (database.Sections.Any(c => c.CourseId == section.CourseId && c.Semester == section.Semester && c.DayTime == section.DayTime && c.InstructorId == section.InstructorId))
                {
                    sectionError.Text = "Duplicate section found! Try again!";
                    return;
                }

                if (database.Instructors.Any(c => c.Id == section.InstructorId) && database.Courses.Any(c => c.Id == section.CourseId))
                {
                    database.Sections.Add(section);
                    database.SaveChanges();
                    sectionSemesterTextBox.Text = "";
                    sectionCourseTextBox.Text = "";
                    sectionDayTimeTextBox.Text = "";
                    sectionInstructorTextBox.Text = "";
                }
                else
                {
                    sectionError.Text = "Course Id and/or Instructor Id does not exist. Try again!";
                    return;
                }
            }

            updateDataSourceForSectionListBox();
        }

        private void addInstructor_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor()
            {
                Name = instructorNameTextBox.Text,
                OfficeLocation = instructorOfficeTextBox.Text
            };

            using (var database = new Database1MdfContext())
            {
                if (database.Instructors.Any(c => c.Name == instructor.Name && c.OfficeLocation == instructor.OfficeLocation))
                {
                    instructorError.Text = "Duplicate instructor found! Try again!";
                    return;
                }


                database.Instructors.Add(instructor);
                // the nice thing to do is to use async not lock the UI
                database.SaveChanges();
                instructorNameTextBox.Text = "";
                instructorOfficeTextBox.Text = "";
                instructorError.Text = "";
            }
            updateDataSourceForInstructorListBox();
        }

        private void addRegistrationButton_Click(object sender, EventArgs e)
        {
            if (gradeTextBox.Text.Length > 2)
            {
                registrationMessage.Text = "Invalid Grade. Up to 2 characters like \"A\", \"A+\", or empty. Try again!";
                return;
            }
            if (sectionListBox.SelectedItem != null && studentListBox.SelectedItem != null)
            {
                using (var database = new Database1MdfContext())
                {
                    Registration registration = new Registration()
                    {
                        SectionId = ((Section)sectionListBox.SelectedItem).Id,
                        StudentId = ((Student)studentListBox.SelectedItem).Id,
                        Grade = gradeTextBox.Text
                    };

                    var section = (Section)sectionListBox.SelectedItem;

                    if (database.Registrations.Any(c => c.SectionId == registration.SectionId && c.StudentId == registration.StudentId))
                    {
                        registrationMessage.Text = "Student has already registered for this section. Look for this registration in the listbox.";
                        return;
                    }
                    if (database.Students.Any(s => s.Registrations.Any(r => r.Section.CourseId == section.CourseId && r.Section.Semester == section.Semester) && s.Id == registration.StudentId))
                    {
                        registrationMessage.Text = "Student has already registered for this course in another section. To add this section\ndelete the other section.";
                        return;
                    }

                    database.Registrations.Add(registration);
                    database.SaveChanges();
                }
                updateDataSourceForRegistrationListBox();
            }
        }

        // end Add Buttons


        // start update Buttons

        private void updateCourseButton_Click(object sender, EventArgs e)
        {
            if (courseListBox.SelectedItem != null)
            {
                Course selectedCourse = (Course)courseListBox.SelectedItem;

                using (var database = new Database1MdfContext())
                {
                    if (database.Courses.Any(c => c.Name == nameTextBox.Text && c.Number == numberTextBox.Text && c.Department == departmentTextBox.Text))
                    {
                        courseError.Text = "Duplicate course found! Try again!";
                        nameTextBox.Text = selectedCourse.Name;
                        numberTextBox.Text = selectedCourse.Number;
                        departmentTextBox.Text = selectedCourse.Department;
                        return;
                    }

                    selectedCourse.Name = nameTextBox.Text;
                    selectedCourse.Department = departmentTextBox.Text;
                    selectedCourse.Number = numberTextBox.Text;
                    database.Courses.Update(selectedCourse);
                    database.SaveChanges();
                }

                updateCourseButton.Enabled = false;
                courseError.Text = "";
                updateDataSourceForCourseListBox();
                updateDataSourceForSectionListBox();
                updateDataSourceForRegistrationListBox();
            }
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            if (studentListBox.SelectedItem != null)
            {
                Student selectedStudent = (Student)studentListBox.SelectedItem;

                using (var database = new Database1MdfContext())
                {
                    if (database.Students.Any(c => c.Name == studentNameTextBox.Text && c.Major == studentMajorTextBox.Text))
                    {
                        studentError.Text = "Duplicate student found! Try again!";
                        studentNameTextBox.Text = selectedStudent.Name;
                        studentMajorTextBox.Text = selectedStudent.Major;
                        return;
                    }

                    selectedStudent.Name = studentNameTextBox.Text;
                    selectedStudent.Major = studentMajorTextBox.Text;
                    database.Students.Update(selectedStudent);
                    database.SaveChanges();
                }

                updateStudentButton.Enabled = false;
                studentError.Text = "";
                updateDataSourceForStudentListBox();
                updateDataSourceForRegistrationListBox();
            }
        }

        private void updateSectionButton_Click(object sender, EventArgs e)
        {
            if (sectionListBox.SelectedItem != null)
            {
                Section selectedSection = (Section)sectionListBox.SelectedItem;
                int courseId;
                int instructorId;
                try
                {
                    courseId = Int32.Parse(sectionCourseTextBox.Text);
                    instructorId = Int32.Parse(sectionInstructorTextBox.Text);
                }
                catch
                {
                    sectionError.Text = "Enter numeric values for Course Id and Instructor Id. Try again!";
                    return;
                }

                using (var database = new Database1MdfContext())
                {
                    if (database.Sections.Any(c => c.CourseId == courseId && c.Semester == sectionSemesterTextBox.Text && c.DayTime == sectionDayTimeTextBox.Text && c.InstructorId == instructorId))
                    {
                        sectionError.Text = "Duplicate section found! Try again!";
                        sectionSemesterTextBox.Text = selectedSection.Semester;
                        sectionCourseTextBox.Text = selectedSection.CourseId.ToString();
                        sectionDayTimeTextBox.Text = selectedSection.DayTime;
                        sectionInstructorTextBox.Text = selectedSection.InstructorId.ToString();
                        return;
                    }

                    if (database.Instructors.Any(c => c.Id == instructorId) && database.Courses.Any(c => c.Id == courseId))
                    {
                        selectedSection.Semester = sectionSemesterTextBox.Text;
                        selectedSection.CourseId = courseId;
                        selectedSection.DayTime = sectionDayTimeTextBox.Text;
                        selectedSection.InstructorId = instructorId;
                        database.Sections.Entry(selectedSection).State = EntityState.Modified;
                        database.SaveChanges();
                    }
                    else
                    {
                        sectionError.Text = "Course Id and/or Instructor Id does not exist. Try again!";
                        return;
                    }
                }

                updateSectionButton.Enabled = false;
                sectionError.Text = "";
                updateDataSourceForSectionListBox();
                updateDataSourceForRegistrationListBox();
            }
        }

        private void updateInstructorButton_Click(object sender, EventArgs e)
        {
            if (instructorListBox.SelectedItem != null)
            {
                Instructor selectedInstructor = (Instructor)instructorListBox.SelectedItem;

                using (var database = new Database1MdfContext())
                {
                    if (database.Instructors.Any(c => c.Name == instructorNameTextBox.Text && c.OfficeLocation == instructorOfficeTextBox.Text))
                    {
                        instructorError.Text = "Duplicate instructor found! Try again!";
                        instructorNameTextBox.Text = selectedInstructor.Name;
                        instructorOfficeTextBox.Text = selectedInstructor.OfficeLocation;
                        return;
                    }

                    selectedInstructor.Name = instructorNameTextBox.Text;
                    selectedInstructor.OfficeLocation = instructorOfficeTextBox.Text;
                    database.Instructors.Update(selectedInstructor);
                    database.SaveChanges();
                }

                updateInstructorButton.Enabled = false;
                instructorError.Text = "";
                updateDataSourceForInstructorListBox();
                updateDataSourceForSectionListBox();
                updateDataSourceForRegistrationListBox();
            }
        }

        private void updateGradeButton_Click(object sender, EventArgs e)
        {
            if (registrationListBox.SelectedItem != null)
            {
                if (gradeTextBox.Text.Length > 2)
                {
                    registrationMessage.Text = "Invalid Grade. Up to 2 characters like \"A\", \"A+\", or empty. Try again!";
                    return;
                }
                using (var database = new Database1MdfContext())
                {
                    Registration registration = (Registration)registrationListBox.SelectedItem;
                    registration.Grade = gradeTextBox.Text;
                    database.Registrations.Update(registration);
                    database.SaveChanges();
                }
            }
            updateDataSourceForRegistrationListBox();
        }

        // end update Buttons


        // start ListBox changeindex
        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseListBox.SelectedItem != null)
            {
                Course selectedCourse = (Course)courseListBox.SelectedItem;
                nameTextBox.Text = selectedCourse.Name;
                numberTextBox.Text = selectedCourse.Number;
                departmentTextBox.Text = selectedCourse.Department;
                updateCourseButton.Enabled = true;
            }
            else
            {
                nameTextBox.Text = "";
                numberTextBox.Text = "";
                departmentTextBox.Text = "";
                updateCourseButton.Enabled = false;
            }
            courseError.Text = "";
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentListBox.SelectedItem != null)
            {
                Student selectedStudent = (Student)studentListBox.SelectedItem;
                studentNameTextBox.Text = selectedStudent.Name;
                studentMajorTextBox.Text = selectedStudent.Major;
                updateStudentButton.Enabled = true;

                registrationListBox.ClearSelected();
                registrationStudentTextBox.Text = selectedStudent.FullDescription;
                if (sectionListBox.SelectedItem != null)
                {
                    addRegistrationButton.Enabled = true;
                }
            }
            else
            {
                studentNameTextBox.Text = "";
                studentMajorTextBox.Text = "";
                registrationStudentTextBox.Text = "";
                updateStudentButton.Enabled = false;
            }
            studentError.Text = "";
        }

        private void sectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sectionListBox.SelectedItem != null)
            {
                Section selectedSection = (Section)sectionListBox.SelectedItem;
                sectionCourseTextBox.Text = selectedSection.CourseId.ToString();
                sectionDayTimeTextBox.Text = selectedSection.DayTime;
                sectionInstructorTextBox.Text = selectedSection.InstructorId.ToString();
                sectionSemesterTextBox.Text = selectedSection.Semester;

                updateSectionButton.Enabled = true;


                registrationListBox.ClearSelected();
                registrationSectionTextBox.Text = selectedSection.FullDescription;
                if (studentListBox.SelectedItem != null)
                {
                    addRegistrationButton.Enabled = true;
                }
            }
            else
            {
                sectionCourseTextBox.Text = "";
                sectionDayTimeTextBox.Text = "";
                sectionInstructorTextBox.Text = "";
                sectionSemesterTextBox.Text = "";
                registrationSectionTextBox.Text = "";
                updateSectionButton.Enabled = false;
            }
            sectionError.Text = "";
        }

        private void instructorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (instructorListBox.SelectedItem != null)
            {
                Instructor selectedInstructor = (Instructor)instructorListBox.SelectedItem;
                instructorNameTextBox.Text = selectedInstructor.Name;
                instructorOfficeTextBox.Text = selectedInstructor.OfficeLocation;
                updateInstructorButton.Enabled = true;
            }
            else
            {
                instructorNameTextBox.Text = "";
                instructorOfficeTextBox.Text = "";
                updateInstructorButton.Enabled = false;
            }
            instructorError.Text = "";
        }

        private void registrationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registrationListBox.SelectedItem != null)
            {
                Registration selectedRegistration = (Registration)registrationListBox.SelectedItem;
                sectionListBox.ClearSelected();
                studentListBox.ClearSelected();

                registrationSectionTextBox.Text = selectedRegistration.Section.FullDescription;
                registrationStudentTextBox.Text = selectedRegistration.Student.FullDescription;
                gradeTextBox.Text = selectedRegistration.Grade;

                updateGradeButton.Enabled = true;
                deleteRegistrationButton.Enabled = true;


                addRegistrationButton.Enabled = false;


            }
            else
            {
                registrationSectionTextBox.Text = "";
                registrationStudentTextBox.Text = "";
                gradeTextBox.Text = "";
                updateGradeButton.Enabled = false;
                deleteRegistrationButton.Enabled = false;
            }
            registrationMessage.Text = "";
        }

        // end ListBox changeindex




        // start filter functions
        private void courseFilter_TextChanged(object sender, EventArgs e)
        {
            updateDataSourceForCourseListBox();
        }

        private void studentFilter_TextChanged(object sender, EventArgs e)
        {
            bool wasSelected = false; ;
            if (studentListBox.SelectedItem != null)
            {
                wasSelected = true;
            }
            updateDataSourceForStudentListBox();
            if (wasSelected)
            {
                registrationStudentTextBox.Text = "";
            }
        }

        private void sectionFilter_TextChanged(object sender, EventArgs e)
        {
            bool wasSelected = false; ;
            if (sectionListBox.SelectedItem != null)
            {
                wasSelected = true;
            }
            updateDataSourceForSectionListBox();

            if (wasSelected)
            {
                registrationSectionTextBox.Text = "";
            }
        }

        private void instructorFilter_TextChanged(object sender, EventArgs e)
        {
            updateDataSourceForInstructorListBox();
        }

        private void registrationFilter_TextChanged(object sender, EventArgs e)
        {
            updateDataSourceForRegistrationListBox();
        }
        // end filter functions

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deleteRegistrationButton_Click(object sender, EventArgs e)
        {
            using (var database = new Database1MdfContext())
            {
                database.Registrations.Remove((Registration)registrationListBox.SelectedItem);
                database.SaveChanges();
            }
            deleteRegistrationButton.Enabled = false;
            updateDataSourceForRegistrationListBox();
        }


    }
}