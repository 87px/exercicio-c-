using System;

class Program
{
    static void Main(string[] args) {
        Console.WriteLine("Informe a sua idade: ");
        String idadeString = Console.ReadLine()!; // Utilize null forgiveness apenas para desenvolvimento e debug
        int idade = Convert.ToInt32(idadeString);
        String mensagem = idade < 18 ? "Menor de idade" : "Maior de idade";
        Console.WriteLine(mensagem);
    }
}



