using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 123;
            contaDaGabriela.numero = 123456-7;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine($"Agência: {contaDaGabriela.agencia}");
            Console.WriteLine($"Número: {contaDaGabriela.numero}");
            Console.WriteLine($"Saldo: {contaDaGabriela.saldo}");

            contaDaGabriela.saldo += 200;

            Console.ReadLine();
        }
    }
}
