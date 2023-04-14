
public class AdmissionEligibility
{
    public static void checkAdmissionEligibility()
    {
        Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Find eligibility for admission");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        Console.WriteLine("Eligibility Criteria:\n");
        Console.WriteLine("Marks in Maths >= 65");
        Console.WriteLine("and Marks in Physics >= 55");
        Console.WriteLine("and Marks in Chemistry >= 50");
        Console.WriteLine("and Total in all three subjects >= 180");
        Console.WriteLine("or Total in Maths and Physics >= 140\n");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");


        Console.Write("Input Marks obtained in Math: ");
        int mathMark = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input Marks obtained in Physics: ");
        int physicsMark = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input Marks obtained in Chemistry: ");
        int chemistryMark = Convert.ToInt32(Console.ReadLine());

        if (mathMark >= 65 && physicsMark >= 65 && chemistryMark >= 50 &&
           (mathMark + physicsMark + chemistryMark >= 180 || mathMark + physicsMark >= 140))
        {
            Console.WriteLine("\nThe candidate is eligible\n\n");
        }
        else
        {
            Console.WriteLine("\nThe candidate is not eligible\n\n");
        }
    }
}

