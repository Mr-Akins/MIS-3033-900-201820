namespace Classes
{
    class Course
    {
        public int CourseID { get; set; }
        public int CourseNumber { get; set; }

        public string CourseName { get; set; }
        public string Subject { get; set; }
        public string Instructor { get; set; }

        public Course()
        {
            CourseID = 0;
            CourseNumber = 0;
            CourseName = string.Empty;
            Subject = string.Empty;
            Instructor = string.Empty;
        }

        public override string ToString()
        {
            return $"{Subject}-{CourseNumber} taught by {Instructor}";
        }

    }
}