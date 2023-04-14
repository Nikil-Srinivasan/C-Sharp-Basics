// This code Checks whether the candidate is eligible for voting or not and prints the result to the console
public class IsEligibleToVote
{
    public static void checkEligibleToVote()
    {
        Console.WriteLine("\n\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Determine a candidate is eligible for casting the vote:");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

        Console.Write("Input the age of candidate: ");
        int voteAge = Convert.ToInt32(Console.ReadLine());

        if (voteAge < 18)
        {
            Console.WriteLine("\nSorry, You are not eligible to caste your vote.\n");
            Console.WriteLine("You would be able to caste your vote after {0} year.\n\n", 18 - voteAge);

        }
        else
        {
            Console.WriteLine("\n\nCongratulation! You are eligible for casting your vote\n\n");
        }
    }
}

