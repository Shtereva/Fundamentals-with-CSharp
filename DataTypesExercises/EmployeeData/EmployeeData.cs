using System;


namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = 'f';
            long numberID = 8306112507;
            int employeeNumber = 27563571;
            Console.WriteLine(@"First name: {0}
Last name: {1}
Age: {2}
Gender: {3}
Personal ID: {4}
Unique Employee number: {5}", firstName, lastName, age, gender, numberID, employeeNumber);
        }
    }
}
