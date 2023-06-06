using e_Agenda.Dominio.ModuloCategoriaEDespesa;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloCategoriaEDespesa
{
    public class RepositorioCategoriaEmArquivo : RepositorioEmArquivo<EntidadeCategoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<EntidadeCategoria> ObterRegistros()
        {
            return ContextoDados.Categorias;
        }
    }
}
