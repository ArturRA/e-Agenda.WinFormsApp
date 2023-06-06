using e_Agenda.Dominio.ModuloCategoriaEDespesa;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloCategoriaEDespesa
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
