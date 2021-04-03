using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int _option;
            bool _hasData = false;

            while (true)
            {
                Console.WriteLine("1 - Cadastro de funcionários\n2 - Cadastro da folha\n3 - Consultar folha\n4 - Listar folhas\n5 - Sair");
                _option = int.Parse(Console.ReadLine());

                switch (_option)
                {
                    case 1:
                        Contato _contato = new();

                        Console.WriteLine("CPF:");
                        _contato.Cpf = Console.ReadLine();
                        if (Notebook.SearchContato(_contato.Cpf) == null)
                        {
                            Console.WriteLine("Nome:");
                            _contato.Name = Console.ReadLine();

                            Notebook.AddContato(_contato);
                            _hasData = true;
                        }
                        else
                            Console.WriteLine("CPF já cadastrado");

                        break;
                    case 2:
                        Contato _c = Notebook.SearchContato(Console.ReadLine());
                        if (_c == null)
                            Console.WriteLine("Contato nao existe");
                        else
                        {


                        }
                            
                        break;
                    case 3:

                        if(_c == null)
                            Console.WriteLine("Contato nao existe");
                        else
                            Console.WriteLine($"Nome:{ _c.Cpf}\nPhone:{_c.Name}\nEmail:{_c.Email}\n");
                        break;
                    case 4:
                        
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