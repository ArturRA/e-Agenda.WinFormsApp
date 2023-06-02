using e_Agenda.WinFormsApp.Compartilhado;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace e_Agenda.WinFormsApp.ModuloContato
{
    public class EntidadeContato : Entidade<EntidadeContato>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }

        public EntidadeContato()
        {
        }

        public EntidadeContato(string nome, string telefone, string email, string cargo, string empresa)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
            this.Cargo = cargo; 
            this.Empresa = empresa;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("Digite um Nome valido");
            if (string.IsNullOrWhiteSpace(Telefone) || Telefone.Trim().Length < 14)
                erros.Add("Digite um Telefone valido");

            Regex validarEmail = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
            if (string.IsNullOrWhiteSpace(Email) || !validarEmail.IsMatch(Email))
                erros.Add("Digite um Email valido");
            if (string.IsNullOrWhiteSpace(Cargo))
                erros.Add("Digite um Cargo valido");
            if (string.IsNullOrWhiteSpace(Empresa))
                erros.Add("Digite um Empresa valido");

            return erros;
        }
    }
}
