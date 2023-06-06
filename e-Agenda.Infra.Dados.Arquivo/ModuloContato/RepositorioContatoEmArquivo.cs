using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloContato
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
