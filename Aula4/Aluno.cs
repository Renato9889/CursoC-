using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola;

namespace Escola{
    public class Aluno:Usuario{
        public int Matricula;
        public decimal Media {get;private set;} //Encapsulamento
        private List<Materia> Materias;

        public Aluno():base(){
            Materias = new List<Materia>();
        }
        public Aluno(int mat, string nome ):this(){
            Nome = nome;
            Matricula = mat;
        }

        public void CalcularMedia(decimal nota1, decimal nota2, decimal nota3){
            decimal total = nota1 + nota2 + nota3;
            Media = total/3;
        }

        public string AdicionarMateria(Materia materia){
            foreach(Materia mate in Materias){
                if(mate.Nome == materia.Nome){
                    return "Esta matéria já existe";
                }
            }

            Materias.Add(materia);
            return "Matéria adicionada com sucesso";
        }

        public override void Logar(){
            Console.WriteLine("O aluno está logado");
        }
    }
}