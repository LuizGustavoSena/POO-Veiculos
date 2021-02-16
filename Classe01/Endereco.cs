namespace Classe01
{
    internal class Endereco
    {
        public string Logradouro { get ; set ; }
        public int Numero { get ; set ; }
        public string Localidade { get ; set ; }

        // CONTRUTORES
        public Endereco()
        {
            Logradouro = "";
            Numero = 0;
            Localidade = "";
        }
        public Endereco(string logradouro, int numero, string localidade)
        {
            Logradouro = logradouro;
            Numero = numero;
            Localidade = localidade;
        }

        // IMPRESSAO
        public override string ToString()
        {
            return ("Logradouro: " + Logradouro + " Número: " + Numero + " Localidade: " + Localidade);
        }
    }
}