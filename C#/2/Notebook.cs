using System.Collections.Generic;

namespace ConsoleApp3
{
    class Notebook
    {
        static List<Employee> _note = new();
        public static void Add_employee(Employee _employee) => _note.Add(_employee);
        public static List<Employee> Get_employee() => _note;
        public static Employee Search_employee(string _cpf)
        {
            foreach (Employee _temp in _note)
                if (_temp.Cpf.Equals(_cpf))
                    return _temp;

            return null;
        }
    }
}
