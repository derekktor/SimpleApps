using System;
namespace EmployeeManagement
{
    public class Employee
    {
        string _firstName;
        string _lastName;
        Contract _contract;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public Contract Contract
        {
            get
            {
                return _contract;
            }
            set
            {
                _contract = value;
            }
        }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _contract = new Contract();
        }

        public void ChangeContract(ContractType newContractType)
        {
            _contract.ChangeContract(newContractType);
        }

        public int GetSalary()
        {
            return _contract.Salary;
        }

        public void SetOvertimeHours(int hours)
        {
            _contract.NumHoursOvertime = hours;
        }

        public override string ToString()
        {
            return _firstName + ", " + _lastName + ": " + GetSalary();
        }
    }
}
