using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Sheetbook
    {
        static List<Sheet> _sheet = new();
        public static void Add_sheet(Sheet _sheetbook) => _sheet.Add(_sheetbook);
        public static List<Sheet> GetSheet() => _sheet;
        public static Sheet Search_duplicate(string _cpf, int _month, int _year)
        {
            foreach (Sheet _temp in _sheet)
                if (_temp.Cpf.Equals(_cpf) && _temp.Month.Equals(_month) && _temp.Year.Equals(_year))
                    return _temp;

            return null;
        }
        public static Sheet Show_sheet(int _month, int _year)
        {
            double _sum = 0;
            foreach (Sheet _temp in _sheet)
            {
                if (_temp.Month.Equals(_month) && _temp.Year.Equals(_year))
                {
                    _sum += Sheet.Calc_liquid(_temp.Hour, _temp.Hour_value);
                    /*
                     * sei lá o que fazer aqui, se não tem ninguem na lista de employee ele retorna um null quando usa o método Search employee
                     * na minha cabeça nao era pra crashar, mas eu recebo um nullreference exeption.
                    */
                    Console.Write($"Nome:{Notebook.Search_employee(_temp.Cpf).Name}\n" +
                        $"Salário:{Sheet.Calc_liquid(_temp.Hour, _temp.Hour_value)}");
                }
            }
            Console.WriteLine($"\nSalários totais do mes: R${_sum}");

            return null;
        }
        public static List<Sheet> GetFolha() => _sheet;
    }
}
