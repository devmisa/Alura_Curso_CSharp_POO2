using _04_ByteBank;
using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contadoBruno = new ContaCorrente();

            contadoBruno.titular = "Bruno";

            Console.WriteLine(contadoBruno.saldo);

            bool resultadoSaque = contadoBruno.Sacar(500);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contadoBruno.saldo);

            contadoBruno.Depositar(500);
            Console.WriteLine(contadoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine($"Saldo do Bruno: {contadoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela: {contaDaGabriela.saldo}");

            bool resultadoTransferencia = contadoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine($"Saldo do Bruno: {contadoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela: {contaDaGabriela.saldo}");

            Console.WriteLine($"Resultado trasnferência: {resultadoTransferencia}");

            contaDaGabriela.Transferir(100, contadoBruno);

            Console.WriteLine($"Saldo do Bruno: {contadoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela: {contaDaGabriela.saldo}");

            Console.ReadLine();
        }
    }
}
