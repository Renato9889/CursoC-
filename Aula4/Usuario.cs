using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola;

namespace Escola{
    public class Usuario{
        public string Nome;
        public string email;
        public string senha;

        public Usuario(){

        }
        public Usuario(string nome){
            Nome = nome;
        }
        public virtual void Logar(){
            Console.WriteLine("Você está logado");
        }
    }
}