using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Notebook
    {
        static List<Contato> _notebook = new();

        public static void AddContato(Contato _contato) => _notebook.Add(_contato);
        public static List<Contato> GetContato() => _notebook;
        public static Contato SearchContato(string _email)
        {
            foreach(Contato _temp in _notebook)
                if (_temp.Email.Equals(_email))
                    return _temp;
 
            return null;
        }
    }
}
