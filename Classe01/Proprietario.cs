namespace Classe01
{
    public class Proprietario
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }

        private Endereco endereco;
        public string DataNasc { get; set; }
        public string DataCompra { get; set; }

        // CONSTRUTORES
        public Proprietario()
        {
            Cpf = "0";
            Nome = "User";
            DataCompra = "00/00/00";
        }

        public Proprietario(Endereco endereco){
            this.endereco = endereco;
        }

        public Proprietario(string cpf, string nome, string dataNasc, string dataCompra)
        {
            Cpf = cpf;
            Nome = nome;
            DataNasc = dataNasc;
            DataCompra = dataCompra;
        }
        // IMPRESSAO
        public override string ToString()
        {
            return ("CPF: " + Cpf + " Nome: " + Nome + " Data Nascimento: " + DataNasc + " Data Compra: " + DataCompra);
        }
    }
}