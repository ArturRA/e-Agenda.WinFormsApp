using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloContato
{
    public class RepositorioContatoEmArquivo : RepositorioEmArquivo<EntidadeContato>, IRepositorioContato
    {
        public RepositorioContatoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<EntidadeContato> ObterRegistros()
        {
            return ContextoDados.Contatos;
        }
    }
}
