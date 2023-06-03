// See https://aka.ms/new-console-template for more information
using Escola;

var aluno1 = new Aluno();
var aluno2 = new Aluno();

var materia = new Materia();

aluno1.Matricula = 01;
aluno1.Nome = "Renato";
aluno1.Media = 9;

aluno2.Matricula = 02;
aluno2.Nome = "Paulo";
aluno2.Media = 8;

Console.WriteLine(aluno1.Nome);