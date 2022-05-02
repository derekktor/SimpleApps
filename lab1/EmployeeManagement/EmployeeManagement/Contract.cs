using System;
namespace EmployeeManagement
{
    public enum SalaryType
    {
        Staz,
        Etat
    }

    public enum ContractType
    {
        Staz,
        Etat
    }

    public class Contract
    {
        ContractType _type;
        int _salary;
        int _hoursOvertime;

        public int NumHoursOvertime
        {
            get
            {
                return _hoursOvertime;
            }
            set
            {
                _hoursOvertime = value;
            }
        }

        public int Salary
        {
            get
            {
                int sal = 0;

                if (_type == ContractType.Staz)
                {
                    sal = 1000;
                }

                if (_type == ContractType.Etat)
                {
                    sal = 5000 + _hoursOvertime * (5000 / 60);
                }

                return sal;
            }
            set
            {
                _salary = value;
            }
        }

        public ContractType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public Contract()
        {
            _type = ContractType.Staz;
            _hoursOvertime = 0;
        }

        public Contract(ContractType type, int salary, int numHoursOvertime)
        {
            _type = type;
            _salary = salary;
            _hoursOvertime = numHoursOvertime;
        }

        public void ChangeContract(ContractType newContractType)
        {
            _type = newContractType;
        }

    }
}
