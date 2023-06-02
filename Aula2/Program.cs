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

/* switch(variavel)*/

const string DIAS_31 = "ESTE MÊS TEM 31 DIAS!";
const string DIAS_30 = "ESTE MÊS TEM 30 DIAS";
const string DIAS_28 = "ESTE MÊS TEM 28 DIAS";
const string MES_INVALIDO = "ESTE MÊS NÃO EXISTE";

Console.WriteLine(("ESCREVA UM MÊS: "));
string mes = Console.ReadLine();

switch(mes){
    case "JANEIRO":
        Console.WriteLine(DIAS_31);
        break;
    case "FEVEREIRO":
        Console.WriteLine(DIAS_28);
        break;
    case "MARÇO" :
        Console.WriteLine(DIAS_31);
        break;
    case "ABRIL":
        Console.WriteLine(DIAS_30);
        break;
     case "MAIO":
        Console.WriteLine(DIAS_31);
        break;
    case "JUNHO":
        Console.WriteLine(DIAS_30);
        break;
    case "JULHO" :
        Console.WriteLine(DIAS_31);
        break;
    case "AGOSTO":
        Console.WriteLine(DIAS_30);
        break;
    case "SETEMBRO":
        Console.WriteLine(DIAS_30);
        break;
     case "OUTUBRO":
        Console.WriteLine(DIAS_31);
        break;
    case "NOVEMBRO":
        Console.WriteLine(DIAS_30);
        break;
    case "DEZEMBRO" :
        Console.WriteLine(DIAS_31);
        break;
    default:
    Console.WriteLine(MES_INVALIDO);
    break;
}

/* WHILE AND FOR*/

int[] arint = new int[] {1,2,3,4,5,6,7,8,9,10};
int i = 0;
while( i < arint.Length){
    Console.WriteLine("Um array bem gay: " + arint[i]);
    Console.WriteLine("Contando os i bem monete:" + i);
    i++;
}

for( int j = 0; j <= 10; j++){
    int numero = arint[j];
    Console.WriteLine(numero);
}

foreach(int numero1 in arint){
    Console.WriteLine(numero1);
}