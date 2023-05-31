using System;

namespace PrimeirosPassos{
    public class Tipos{
        public static void Main(){
            //int
            int variavelA = 13;

            //float
            float varivelB = 13.5f;

            //double
            double variavelC = 24.13d;

            //decimal
            decimal variavelD = 55.9m;

            //bool
            bool b1 = true;
            bool b2 = false;

            //char
            char variavelE = 'A';

            //string
            string variavelF = "Renato";

            //var
            var cidade = "Palmas";
            var idade = 24;

            idade = 25;

            //constante
            const string pais = "Brasil";

            //Opeadores aritméticos
            int adicao = 5 + 8;
            int subtracao = 5-6;
            int multiplicacao = 5*12;
            int divisao = 15/3;
            int expres = (1 + 2) * 3 - 2 / 2;

            //Operadores relacionais
            string cidade1 = "Palmas";
            string cidade2 = "Goiania";

            bool ret1 = cidade1 == cidade2;
            bool ret2 = cidade1 != cidade2;

            Console.WriteLine(ret1);
            Console.WriteLine(ret2);

            int i = 3;
            int j = 5;

            bool ret3 = i==j;
            bool ret4 = i!=j;
            bool ret5 = i>j;
            bool ret6 = i<j;
            bool ret7 = i<=j;
            bool ret8 = i>=j;

            //Operadores lógicos
            bool ret9 = i==j && cidade1 == cidade2;
            bool ret10 = i<j || cidade1 == cidade2;
            bool ret11 = !(i==j);

            Console.WriteLine(ret9);
            Console.WriteLine(ret10);
            Console.WriteLine(ret11);

            //Strings

            string frase = "Hoje estreia homen aranha!";
            Console.WriteLine(frase.Substring(13));

            Console.WriteLine(frase.Replace("homen aranha","barbie"));

            frase.Trim();
            frase.TrimEnd();
            frase.TrimStart();

            Console.WriteLine(frase.Trim('!'));

            string cpf = "345544673";

            cpf = cpf.PadLeft(11,'0');

            Console.WriteLine(cpf);

            string frase2 = frase + "E tambem estreia Flash!";

            Console.WriteLine(frase2);

            string frase3 = $"{frase}E tambem estreia Guardiões da Galaxia!";

            Console.WriteLine(frase3);
        }
    }
}
