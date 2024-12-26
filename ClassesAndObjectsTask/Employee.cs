using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjectsTask
{
    internal class Employee
    {
        private string _surname;
        private int _age;

        public Employee()
        {
            
        }

        public Employee(string surname, int age)
        {
            this._surname = surname ?? throw new ArgumentNullException(nameof(_surname), $"{nameof(_surname)} can not be null");
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age cannot be less than 0");
            }
            else
            {
                this._age = age;
            }

        }

        private string GetAgeAsString()
        {
            return _age.ToString();
        }

        public void ChangeSurname(string surname)
        {
            this._surname = surname;
        }

        public string GetEmployeeInfo()
        {
            return $"Surname: {this._surname}, Age: {this._age}";
        }
    }
}
