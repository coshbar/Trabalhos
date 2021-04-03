using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int _option;
            float _numero, _numexp, _numpercent, _numbase, _numheight;
            while (true)
            {
                Console.WriteLine("1 - Fatorial\n2 - Exponenciação\n3 - Porcentagem\n4 - Area do triângulo\n5 - Sair");
                _option = int.Parse(Console.ReadLine());
                switch (_option)
                {
                    case 1:
                        Console.WriteLine("Numero:");
                        _numero = float.Parse(Console.ReadLine());
                        Console.WriteLine(CalcularFatorial(_numero));
                        break;
                    case 2:
                        Console.WriteLine("Base:");
                        _numero = float.Parse(Console.ReadLine());
                        Console.WriteLine("Exponente:");
                        _numexp = float.Parse(Console.ReadLine());
                        Console.WriteLine(CalcularExponenciacao(_numero, _numexp));
                        break;
                    case 3:
                        Console.WriteLine("Numero:");
                        _numero = float.Parse(Console.ReadLine());
                        Console.WriteLine("Porcentagem:");
                        _numpercent = float.Parse(Console.ReadLine());
                        Console.WriteLine(CalcularPorcentagem(_numero, _numpercent));
                        break;
                    case 4:
                        Console.WriteLine("Base:");
                        _numbase = float.Parse(Console.ReadLine());
                        Console.WriteLine("Altura:");
                        _numheight = float.Parse(Console.ReadLine());
                        Console.WriteLine(CalcularAreaTrinagulo(_numbase, _numheight));
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
        static float CalcularFatorial(float numero) => numero == 1 ? 1 : numero * CalcularFatorial(numero - 1);
        static float CalcularExponenciacao(float numero, float numexp) => numexp == 0 ? 1 : numero * CalcularExponenciacao(numero, numexp - 1);
        static float CalcularPorcentagem(float numero, float numpercent) => numpercent / 100 * numero;
        static float CalcularAreaTrinagulo(float numbase, float numheight) => numbase * numheight / 2;
    }
}
