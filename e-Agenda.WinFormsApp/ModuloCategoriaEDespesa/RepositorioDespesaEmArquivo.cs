using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public class RepositorioDespesaEmArquivo : RepositorioEmArquivo<EntidadeDespesa>, IRepositorioDespesa
    {
        public RepositorioDespesaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<EntidadeDespesa>? SelecionarDespesasDaCategoria(EntidadeCategoria? entidade)
        {
            return ObterRegistros()
                .Where(x => x.Categorias.Any(e => e.Id == entidade!.Id))
                .ToList();
        }

        protected override List<EntidadeDespesa> ObterRegistros()
        {
            return ContextoDados.Despesa;
        }
    }
}
