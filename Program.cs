using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta()
;           bool continuar = true;
            do
            {
                Console.WriteLine("======== Bem vindo ao Meu Banco===========");
                Console.WriteLine($"Digite 1 para Abrir a sua conta\n" +
                    $"Digite 2 para se deseja fazerdeposito\n" +
                    $"Digite 3 para sacar\n" +
                    $"Digite 4 para ver saldo em Conta\n" +
                    $"Digite 5 para sair");
                string escolha =Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        
                        conta.NomeCliente();
                        conta.GeraAgenciaeConta();
                        Console.WriteLine(conta);
                        break;
                    case "2":
                        conta.Depositar();
                        Console.WriteLine(conta);
                        break;
                    case "3":
                        conta.Saque();
                        Console.WriteLine(conta);
                        break;
                    case "4":
                        Console.WriteLine(conta);
                        break;
                    case "5":
                        Console.WriteLine("Obrigado por usar Nosso Banco");
                        continuar = false;                     
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção invalida Tente novamente");
                        break;
                        
                }
                Console.WriteLine();
            }
            while (continuar);
            Console.WriteLine("Programa Encerrado...");
            Console.WriteLine("Aperte qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
