public class StudentDetails
{
    public static void Main()
    {
        Console.WriteLine("Enter student name");
        // Console.ReadLine();
        HigherSecondaryCourse student = new HigherSecondaryCourse();
        student.StudentName = "Nikil";
        Console.WriteLine("The student name is {0}", student.StudentName);

        student.StudentAge = 20;
        Console.WriteLine("The student age is " + student.StudentAge);

        student.SelectedCourse = "Math, Physics, Chemistry";
        Console.WriteLine("The student {0} selected course is {1}", student.StudentName, student.SelectedCourse);


    }
}