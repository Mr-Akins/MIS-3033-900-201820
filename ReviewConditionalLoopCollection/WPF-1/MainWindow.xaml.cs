using System;
using System.Collections.Generic;
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

namespace WPF_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            
            string name;
            name = txtName.Text;

            int soonerID;// = Convert.ToInt32(txtID.Text);
            if (int.TryParse(txtID.Text, out soonerID) == false) ///validate that the string is an integer
            {
                MessageBox.Show("INVALID SOONER ID");
                return;
            }
            double gpa = Convert.ToDouble(txtGPA.Text);
            string dob = txtDOB.Text;

            DateTime dateOfBirth = Convert.ToDateTime(dob);
            DateTime now = DateTime.Now;
            dateOfBirth = dateOfBirth.AddDays(1);
            var different = now - dateOfBirth;
            var firstName = name.Split(' ')[0];
            var lastName = name.Split(' ')[1];
            MessageBox.Show($"You were born on {dateOfBirth.DayOfWeek}");
            Student newStudent = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                SoonerID = soonerID,
                GPA = gpa
            };
            students.Add(newStudent);
            MessageBox.Show(name);

        }
    }
}
