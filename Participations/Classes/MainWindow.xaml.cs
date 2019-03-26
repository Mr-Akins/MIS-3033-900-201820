using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
            string courseFile = $@"{path}\Course.csv";
            string studentFile = $@"{path}\Student.csv";
            string courseFile1 = @"‪C:\Users\acke9387\Downloads\Course.csv";
            string studentFile1 = @"‪‪C:\Users\acke9387\Downloads\Student.csv";
            string squirrel = courseFile1 + Environment.NewLine + courseFile;

            if (courseFile == courseFile1)
            {
                MessageBox.Show("HELLO");
            }

            if (File.Exists(courseFile) == false || File.Exists(studentFile) == false)
            {
                MessageBox.Show("Please make sure that your files are in your downloads directory.");
                Environment.Exit(0);
            }
            var courses = File.ReadAllLines(courseFile);
            //[0] = "CourseID,CourseNumber,CourseName,Subject,Instructor"
            //[1] = "1,3033,Programming 2,MIS,Ackerman" ==> ["1", "3033", "Programming 2", "MIS", "Ackerman"]
            for (int i = 1; i < courses.Length; i++)
            {
                var course = courses[i].Split(',');
                Course c = new Course()
                {
                    CourseID = Convert.ToInt32(course[0]),
                    CourseNumber = Convert.ToInt32(course[1]),
                    CourseName = course[2],
                    Subject = course[3],
                    Instructor = course[4]
                };
                lstCourses.Items.Add(c);
            }

            //Read in the students

            Student s = new Student();
            s.AddCourse(new Course());
        }
    }
}
