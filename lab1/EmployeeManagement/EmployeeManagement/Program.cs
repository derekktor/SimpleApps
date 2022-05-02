using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee derek = new Employee("derek", "hale");

            derek.ChangeContract(ContractType.Etat);
            derek.SetOvertimeHours(100);

            Console.WriteLine(derek);
        }
    }
}
