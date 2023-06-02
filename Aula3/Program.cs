// See https://aka.ms/new-console-template for more information
Console.WriteLine("---------------LISTAS----------------");
int[] numeros = new int[] {1,2,3,4,5,6,7,8,9,10};
int num = numeros[0];
Console.WriteLine(num);

int total = numeros.Length;

List<int>listNumeros = new List<int>();

List<int>listNum = new List<int>(){1,2,3,4,5};

Console.WriteLine(listNum.Count);
listNum.Add(6);
listNum.Remove(2);

foreach(int numero in listNum){
    Console.WriteLine(numero);
}

Console.WriteLine("---------------Dicionario----------------");

Dictionary<int, string> estados = new Dictionary<int, string>();
estados.Add(1,"TO");
estados.Add(2,"PA");
estados.Add(3,"GO");

if(!estados.ContainsKey(4)){
    estados.Add(4,"MG");
}

foreach(string estado in estados.Values){
    Console.WriteLine(estado);
}

string est = null;

if(estados.TryGetValue(3, out est)){
    Console.WriteLine(est);
}


Console.WriteLine("---------------QUEUE - FILA----------------");
Queue<string> listaS = new Queue<string>();
listaS.Enqueue("Ola");
listaS.Enqueue("pessoal");
listaS.Enqueue("feliz");
listaS.Enqueue("mês");
listaS.Enqueue("do Orgulho");

foreach(string palavra in listaS){
    Console.WriteLine(palavra);
}
Console.WriteLine("-------------DEQUEUE-----------------");
string elemeto = listaS.Dequeue();
foreach(string palavra in listaS){
    Console.WriteLine(palavra);
}
int totalq = listaS.Count;
Console.WriteLine("-------------Primeiro elemento e total-----------------");
Console.WriteLine(listaS.Peek());
Console.WriteLine(totalq);

Console.WriteLine("-------------STACK - PILHA-----------------");

Stack<string> listaP = new Stack<string>();

listaP.Push("Amo");
listaP.Push("meus");
listaP.Push("gatos");
listaP.Push("Chico");
listaP.Push("Tigressa");

foreach(string palavra in listaP){
    Console.WriteLine(palavra);
}
Console.WriteLine("-------------POP-----------------");
listaP.Pop();

foreach(string palavra in listaP){
    Console.WriteLine(palavra);
}

Console.WriteLine("-------------SORTEDLIST-----------------");

SortedList<int,string> listaD = new SortedList<int, string>();
listaD.Add(1, "Homen Aranha atravez do aranha verso");
listaD.Add(4, "Homem Formiga Qunatumania");
listaD.Add(2,"The Marvels");
listaD.Add(3,"Guadioes da galaxia");

foreach(string filme in listaD.Values){
    Console.WriteLine(filme);
}