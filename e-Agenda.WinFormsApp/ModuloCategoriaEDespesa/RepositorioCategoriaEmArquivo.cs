using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
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
