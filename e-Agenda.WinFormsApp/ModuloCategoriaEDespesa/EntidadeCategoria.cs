using e_Agenda.WinFormsApp.Compartilhado;
using System.Collections.ObjectModel;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public class EntidadeCategoria : Entidade<EntidadeCategoria>
    {
        public string Descricao { get; set; }
        private List<EntidadeDespesa> despesas { get; set; }
        public ReadOnlyCollection<EntidadeDespesa> Despesas
        {
            get
            {
                return despesas.AsReadOnly();
            }
        }

        public EntidadeCategoria(string descricao)
        {
            Descricao=descricao;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Descricao))
                erros.Add("Digite uma Descricao valido");

            return erros;
        }
    }
}
