using System;

namespace prova06_sistCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Manaus");

            cliente.Cadastro();
        }
    }
}
