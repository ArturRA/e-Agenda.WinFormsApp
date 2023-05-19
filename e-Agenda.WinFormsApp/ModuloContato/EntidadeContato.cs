using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class EntidadeContato : Entidade<EntidadeContato>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }

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
            return $"Id: {Id}, Nome: {Nome}, Telefone: {Telefone}, Email: {Email}, Cargo: {Cargo}, Empresa: {Empresa}";
        }
    }
}
