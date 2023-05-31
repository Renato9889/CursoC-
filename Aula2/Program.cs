// See https://aka.ms/new-console-template for more information

/* if(Condição a ser testada)*/

const string APROVADO = "APROVADO!";
const string REPROVADO = "RPROVADO!";
const string EM_RECUPERACAO = "EM RECUPERAÇÃO!";

Console.WriteLine("Digite sua nota: ");
decimal nota = Convert.ToDecimal(Console.ReadLine());

if(nota>=5){
    Console.WriteLine(APROVADO);
}else if(nota >=4 && nota < 5){
    Console.WriteLine(EM_RECUPERACAO);
}else{
    Console.WriteLine(REPROVADO);
}
