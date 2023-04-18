using System.Collections.Generic;
public class DictionaryExample
{
    public static void dictionaryMethods()
    {
        Dictionary<int, string> employeeDetails = new Dictionary<int, string>();

        //adding a key/value using the Add() method
        employeeDetails.Add(100, "Nikil");
        employeeDetails.Add(101, "Priya");
        employeeDetails.Add(102, "Pratiksha");

        //Iterating employeeDetails using object kvp
        foreach (KeyValuePair<int, string> kvp in employeeDetails)
        {
            Console.WriteLine($"Employee ID: {kvp.Key}");
            Console.WriteLine($"Employee Name: {kvp.Value}\n");
        }

        // Accessing value with its key
        // If the key is not present runtime exception occurs
        Console.WriteLine($"First Employee: {employeeDetails[100]}\n");

        if (employeeDetails.ContainsKey(101))
        {
            Console.WriteLine($"Second Employee: {employeeDetails[101]}\n");
        }

        //use TryGetValue() to get a value of unknown key
        if (employeeDetails.TryGetValue(103, out string? value))
        {
            Console.WriteLine($"Third Employee: {value}\n");
        }

        // To update a value of a particular key
        if (employeeDetails.ContainsKey(102))
        {
            employeeDetails[102] = "Syed";
        }

        //use ElementAt() to retrieve key-value pair using index
        for (int index = 0; index < employeeDetails.Count; index++)
        {
            Console.WriteLine("Key : {0} \t Value : {1}", employeeDetails.ElementAt(index).Key, employeeDetails.ElementAt(index).Value);
        }

        // To delete an element in dictionary
        if (employeeDetails.ContainsKey(102))
        {
            employeeDetails.Remove(102);
        }

        foreach (var kvp in employeeDetails)
        {
            Console.WriteLine("Employee Id: {0} \t Employee Name: {1}", kvp.Key, kvp.Value);
        }

        //To remove all the elements
        employeeDetails.Clear();

    }
}