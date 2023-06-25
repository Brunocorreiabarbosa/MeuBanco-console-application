using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MeuBanco
{
    class Conta
    {
        public int ContaID { get; set; }
        public int AgenciaID { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }

        public Conta()
        {

        }
        public Conta(int contaid, string nome,double saldo, int agenciaID) 
        {
            ContaID = contaid;
            AgenciaID = agenciaID;
            Nome = nome;
            Saldo = saldo;
        }
        public Conta GeraAgenciaeConta ()
        {
            Random gera = new Random();
            int geraconta = gera.Next(999999);
            int geraAgencia = gera.Next(9999);

            AgenciaID = geraAgencia;
            ContaID = geraconta;

            return new Conta(geraconta, "Nome da Conta", 0, geraAgencia);
        }
        public void NomeCliente()
        {
            Console.WriteLine("Digite o Nome Do Titular:");
            string nome = Console.ReadLine();

            if (nome !=  null && nome.Length > 2)
            {
                Nome = nome;
                Console.WriteLine("Deseja Depositar Um Saldo inicial Em sua Conta?\n" +
                                 "(S para SIM e N Para NÃO (S/N) ");
                string depositoinicial = Console.ReadLine().ToUpper();
                if (depositoinicial.ToUpper() == "S")
                {
                    Depositar();
                }               
            }           
        }
        public void Depositar()
        {
            Console.WriteLine("Digite o valor do Deposito: ");
            double deposito =double.Parse(Console.ReadLine());
            decimal valor;

            if (deposito >0)
            {
                Saldo+= deposito;

                Console.WriteLine("Deposito Realizado Com Sucesso!!!");  
            }
            else
            {
                Console.WriteLine("Valor Para Deposito Invalido");
            }
        }
        public void Saque() 
        {   
            Console.WriteLine("Digite o valo que deseja sacar: ");
            double saque = double.Parse(Console.ReadLine());
            if (Saldo > saque)
            {
                Saldo -= saque; // Atualiza o saldo após o saque
                Console.WriteLine("Saque Realizado Com Sucesso!!!");
            }
            else
            {
                Console.WriteLine("Você não possui essa quantia para saque");
            }
        }
        public override string ToString()
        {
            return $"==========Banco Sao Jumentos==========\n" +
                $"Nome: {Nome}\n" +
                $"Minha Agencia: {AgenciaID}\n" +
                $"Minha Conta: {ContaID}\n" +
                $"Saldo Em Conta: R$:{Saldo}";
        }
    }
}
