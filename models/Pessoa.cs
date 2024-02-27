using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudando_dot_net.models
{
    public class Pessoa
    {
        public string Nome {get; set;} = string.Empty;
        public int Idade {get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Hello, my name is {Nome} and I have {Idade} years old!");
        }
    }
}
