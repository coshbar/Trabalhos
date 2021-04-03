using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int _option;

            while (true)
            {
                Console.WriteLine("1 - Cadastro de funcionários\n" +
                    "2 - Cadastro da folha\n" +
                    "3 - Consultar folha\n" +
                    "4 - Listar folhas\n" +
                    "5 - Sair");
                _option = int.Parse(Console.ReadLine());

                switch (_option)
                {
                    case 1:
                        Employee _employee = new();

                        Console.WriteLine("CPF:");
                        _employee.Cpf = Console.ReadLine();
                        if (Notebook.Search_employee(_employee.Cpf) == null)
                        {
                            Console.WriteLine("Nome:");
                            _employee.Name = Console.ReadLine();

                            Notebook.Add_employee(_employee);
                        }
                        else
                            Console.WriteLine("CPF já cadastrado");

                        break;
                    case 2:
                        Sheet _sheet = new();

                        Console.WriteLine("CPF:");
                        _sheet.Cpf = Console.ReadLine();
                        Console.WriteLine("Mês:");
                        _sheet.Month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ano:");
                        _sheet.Year = int.Parse(Console.ReadLine());

                        if (Sheetbook.Search_duplicate(_sheet.Cpf, _sheet.Month, _sheet.Year) == null)
                        {
                            Console.WriteLine("Número de horas trabalhadas:");
                            _sheet.Hour = int.Parse(Console.ReadLine());
                            Console.WriteLine("Valor da hora:");
                            _sheet.Hour_value = float.Parse(Console.ReadLine());

                            Sheetbook.Add_sheet(_sheet);
                        }
                        else
                            Console.WriteLine("Dados repetidos");

                        break;
                    case 3:
                        Sheet _sheet_temp = new();

                        Console.Write("CPF:");
                        _sheet_temp.Cpf = Console.ReadLine();
                        Console.Write("Mês:");
                        _sheet_temp.Month = int.Parse(Console.ReadLine());
                        Console.Write("Ano:");
                        _sheet_temp.Year = int.Parse(Console.ReadLine());
                        Sheet _sheet_if = Sheetbook.Search_duplicate(_sheet_temp.Cpf, _sheet_temp.Month, _sheet_temp.Year);

                        if (_sheet_if != null)
                        {
                            double
                            _bruto = Sheet.Calc_bruto(_sheet_if.Hour, _sheet_if.Hour_value),
                            _ir = Sheet.Calc_ir(_sheet_if.Hour, _sheet_if.Hour_value),
                            _inss = Sheet.Calc_inss(_sheet_if.Hour, _sheet_if.Hour_value),
                            _fgts = Sheet.Calc_fgts(_sheet_if.Hour, _sheet_if.Hour_value),
                            _liquid = Sheet.Calc_liquid(_sheet_if.Hour, _sheet_if.Hour_value);

                            Console.WriteLine($"Salário Bruto:R${_bruto}\n" +
                                $"Desconto IR:R${_ir}\n" +
                                $"Desconto INSS:R${_inss}\n" +
                                $"FGTS:R${_fgts}\n" +
                                $"Salário Liquido:R${_liquid}");
                        }
                        else
                            Console.WriteLine("Folha não registrada");
                        break;
                    case 4:
                        int _month, _year;
                        Console.Write("Mês:");
                        _month = int.Parse(Console.ReadLine());
                        Console.Write("Ano:");
                        _year = int.Parse(Console.ReadLine());

                        Sheetbook.Show_sheet(_month, _year);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcao invalida.");
                        break;
                }
            }
        }
    }
}
