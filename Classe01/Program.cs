using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe01
{
    class Program
    {
        static void Main(string[] args)
        {
            int decisao;
            Veiculo veiculo = new Veiculo();
            Proprietario proprietario = new Proprietario();
            Endereco endereco = new Endereco();

            do {
                do
                {
                    Console.WriteLine("1 - Informar todos os dados\n2 - Cadastrar todos os dados\n3- Sair");
                    decisao = int.Parse(Console.ReadLine());
                } while (decisao != 1 && decisao != 2);

                switch (decisao)
                {
                    case 1:
                        #region dadosVeiculo
                        uint renavan;
                        string chassi, placa, marca, modelo, cor;
                        int ano;

                        Console.Write("Informe o Renavan do carro: ");
                        renavan = uint.Parse(Console.ReadLine());
                        veiculo.Renavan = renavan;

                        Console.Write("Informe o Chassi do carro: ");
                        chassi = Console.ReadLine();
                        veiculo.Chassi = chassi;

                        Console.Write("Informe a Placa do carro: ");
                        placa = Console.ReadLine();
                        veiculo.Placa = placa;

                        Console.Write("Informe a Marca do carro: ");
                        marca = Console.ReadLine();
                        veiculo.Marca = marca;

                        Console.Write("Informe o Modelo do carro: ");
                        modelo = Console.ReadLine();
                        veiculo.Modelo = modelo;

                        Console.Write("Informe a Cor do carro: ");
                        cor = Console.ReadLine();
                        veiculo.Cor = cor;

                        Console.Write("Informe o Ano do carro: ");
                        ano = int.Parse(Console.ReadLine());
                        veiculo.Ano = ano;

                        #endregion

                        #region dadosProprietario

                        string cpf;
                        string nome, dataNasc, dataCompra;

                        Console.Write("Informe o CPF: ");
                        cpf = Console.ReadLine();
                        proprietario.Cpf = cpf;

                        Console.Write("Informe o Nome: ");
                        nome = Console.ReadLine();
                        proprietario.Nome = nome;

                        Console.Write("Informe a Data de Nascimento: ");
                        dataNasc = Console.ReadLine();
                        proprietario.DataNasc = dataNasc;

                        Console.Write("Informe a Data de compra: ");
                        dataCompra = Console.ReadLine();
                        proprietario.DataCompra = dataCompra;

                        #endregion

                        #region dadosEndereco

                        

                        #endregion
                        break;
                    case 2:
                        Console.WriteLine("Veiculo\n" + veiculo.ToString() + "\n");

                        Console.WriteLine("Proprietário\n" + proprietario.ToString() + "\n");

                        Console.WriteLine("Endereço\n" + endereco.ToString() + "\n");
                        break;
                }

            } while (decisao != 3);
            Console.ReadKey();
        }

        static void cadastroEndereco(Endereco endereco){
            string logradouro, localidade;
            int numero;

            do{
                Console.Write("Informe o Logradouro: ");
                logradouro = Console.ReadLine();
            }while(logradouro == "");
            endereco.Localidade = logradouro;

            Console.Write("Informe o Número: ");
            numero = int.Parse(Console.ReadLine());
            endereco.Numero = numero;

            do{
                Console.Write("Informe a Localidade: ");
                localidade = Console.ReadLine();
            }while(localidade == "");
            endereco.Localidade = localidade;
        }
    }
}
