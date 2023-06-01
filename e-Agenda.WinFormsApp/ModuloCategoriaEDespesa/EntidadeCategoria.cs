using e_Agenda.WinFormsApp.Compartilhado;
using System.Collections.ObjectModel;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public class EntidadeCategoria : Entidade<EntidadeCategoria>
    {
        public string Descricao { get; set; }
        public List<EntidadeDespesa> Despesas { get; set; }

        public EntidadeCategoria(string descricao)
        {
            Descricao=descricao;
            Despesas = new List<EntidadeDespesa>();
        }

        public void AdicionarDespesa(EntidadeDespesa entidade)
        {
            if (!Despesas.Any(e => e.Id == entidade.Id))
                Despesas.Add(entidade);
        }

        public void RemoverDespesa(EntidadeDespesa entidade)
        {
            if (Despesas.Any(e => e.Id == entidade.Id))
                Despesas.Remove(Despesas.Single(e => e.Id == entidade.Id));
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
