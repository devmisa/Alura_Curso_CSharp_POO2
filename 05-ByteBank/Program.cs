using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "123.456.789-00";
            //gabriela.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;

            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela";
            conta.titular.cpf = "123.456.789.00";
            conta.titular.profissao = "Desenvolvedora C#";
            conta.saldo = 500;
            conta.agencia = 1234567;


            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
