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

                    Console.WriteLine("1 - Cadastrar Veículo, Proprietário e Endereço\n2 - visualizar todos os dados\n0- Sair");
                try 
	            {	        
		            decisao = int.Parse(Console.ReadLine());
	            }
	            catch (Exception)
	            {
                    decisao = 4;
	            }
                    

                switch (decisao)
                {
                    case 1:

                        cadastroEndereco(endereco);
                        proprietario = new Proprietario(endereco);

                        cadastroProprietario(proprietario);
                        veiculo = new Veiculo(proprietario);

                        cadastroVeiculo(veiculo);

                        break;
                    case 2:
                        Console.WriteLine(veiculo.ToString() + "\n");
                        break;
                }

            } while (decisao != 0);
            Console.ReadKey();
        }

        static void cadastroVeiculo(Veiculo veiculo){
            
            try 
	        {	        
		        uint renavan;
                string chassi, placa, marca, modelo, cor;
                int ano;

                Console.Write("Informe o Renavan do carro: ");
                renavan = uint.Parse(Console.ReadLine());
                veiculo.Renavan = renavan;

                do{
                    Console.Write("Informe o Chassi do carro: ");
                    chassi = Console.ReadLine();
                }while(chassi == "");
                veiculo.Chassi = chassi;

                do{
                    Console.Write("Informe a Placa do carro: ");
                    placa = Console.ReadLine();
                }while(placa == "");
                veiculo.Placa = placa;

                do{
                    Console.Write("Informe a Marca do carro: ");
                    marca = Console.ReadLine();
                }while(marca == "");
                veiculo.Marca = marca;

                do{
                    Console.Write("Informe o Modelo do carro: ");
                    modelo = Console.ReadLine();
                }while(modelo == "");
                veiculo.Modelo = modelo;

                do{
                    Console.Write("Informe a Cor do carro: ");
                    cor = Console.ReadLine();
                }while(cor == "");
                veiculo.Cor = cor;

                Console.Write("Informe o Ano do carro: ");
                ano = int.Parse(Console.ReadLine());
                veiculo.Ano = ano;
	        }
	        catch (Exception)
	        {
                Console.WriteLine("Informe valores válidos");
                cadastroVeiculo(veiculo);
	        }

        }

        static void cadastroProprietario(Proprietario proprietario){
            try 
	        {	        
		        string cpf, nome, dataNasc, dataCompra;

                do{
                    Console.Write("Informe o CPF: ");
                    cpf = Console.ReadLine();
                }while(cpf == "");
                proprietario.Cpf = cpf;

                do{
                    Console.Write("Informe o Nome: ");
                    nome = Console.ReadLine();
                }while(nome == "");
                proprietario.Nome = nome;

                do{
                    Console.Write("Informe a Data de Nascimento: ");
                    dataNasc = Console.ReadLine();
                }while(dataNasc == "");
                proprietario.DataNasc = dataNasc;

                do{
                    Console.Write("Informe a Data de compra: ");
                    dataCompra = Console.ReadLine();
                }while(dataCompra == "");
                proprietario.DataCompra = dataCompra;
	        }
	        catch (Exception)
	        {
                Console.WriteLine("Informe valores válidos");
                cadastroProprietario(proprietario);
	        }
        }


        static void cadastroEndereco(Endereco endereco){
            try 
	        {	        
		        string logradouro, localidade;
                int numero;

                do{ //LAÇO ENQUANDO USUARIO NÃO PREENCHER NADA 
                    Console.Write("Informe o Logradouro: ");
                    logradouro = Console.ReadLine();
                }while(logradouro == "");
                endereco.Logradouro = logradouro;

                Console.Write("Informe o Número: ");
                numero = int.Parse(Console.ReadLine());
                endereco.Numero = numero;

                do{ //LAÇO ENQUANDO USUARIO NÃO PREENCHER NADA 
                    Console.Write("Informe a Localidade: ");
                    localidade = Console.ReadLine();
                }while(localidade == "");
                endereco.Localidade = localidade;
	        }
	        catch (Exception)
	        {
                Console.WriteLine("Informe valores válidos");
                cadastroEndereco(endereco);
	        }
        }
    }
}
