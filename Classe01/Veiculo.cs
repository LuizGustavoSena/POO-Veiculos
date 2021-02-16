using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe01
{
    class Veiculo
    {
        public uint Renavan { get; set; }
        public string Chassi { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }

        public Proprietario proprietario;

        // CONSTRUTORES
        public Veiculo()
        {
            Renavan = 000000000;
            Chassi = "0000a000a000a";
            Placa = "AAA-000";
            Marca = "";
            Modelo = "";
            Cor = "";
            Ano = 0000;
        }

        public Veiculo(Proprietario proprietario){
            this.proprietario = proprietario;
        }

        public Veiculo(uint renavan, string chassi, string placa, string marca, string modelo, string cor, int ano)
        {
            Renavan = renavan;
            Chassi = chassi;
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
        }
        
        // IMPRESSÃO OBJETO
        public override string ToString()
        {
            return ("Renavan: " + Renavan + " Chassi: " + Chassi + 
                " Placa: " + Placa + " Marca: " + Marca + " Modelo: " + 
                Cor + " Ano: " + Ano);
        }
  
    }
}
