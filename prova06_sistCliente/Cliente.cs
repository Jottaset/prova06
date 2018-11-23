using System;
namespace prova06_sistCliente
{
    public class Cliente
    {
        public string Nome;
        public string Cidade = "Manaus";

        public void Cadastro()
        {

            Console.WriteLine("Informe o Nome do cliente:");
            Nome = Console.ReadLine();

            Console.Write("Cliente: {0}, Cidade: {1}" , Nome, Cidade);

        }

        public Cliente(string cidade)//Construtor
        {
            this.Cidade = cidade;
        }
    }
}
