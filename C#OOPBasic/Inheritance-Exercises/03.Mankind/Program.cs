using System;

namespace _03.Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var studentsTokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentsTokens[0];
                string lastName = studentsTokens[1];
                string facultyNumber = studentsTokens[2];

                Student student = new Student(firstName, lastName, facultyNumber);

                var workerTokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string WfirstName = workerTokens[0];
                string WlastName = workerTokens[1];
                decimal weekSalary = decimal.Parse(workerTokens[2]);
                decimal workHoursPerDay = decimal.Parse(workerTokens[3]);

                Worker worker = new Worker(WfirstName,WlastName, weekSalary, workHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine(worker);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
