namespace e_Agenda.WinFormsApp.Compartilhado
{
    public abstract class RepositorioEmMemoria<TipoEntidade>
        where TipoEntidade : Entidade<TipoEntidade>
    {
        protected int ContadorDeId { get; set; } = 1;
        protected List<TipoEntidade> Registros { get;} = new List<TipoEntidade>();

        public void Inserir(TipoEntidade entidade)
        {
            entidade.Id = ContadorDeId;
            Registros.Add(entidade);
            ContadorDeId++;
        }

        public void Editar(TipoEntidade entidadeAtualizado)
        {
            TipoEntidade? entidadeParaAtualizar = SelecionarPeloId(entidadeAtualizado.Id);
            entidadeParaAtualizar!.Editar(entidadeAtualizado);
        }

        public void Excluir(TipoEntidade elementoParaExcluir)
        {
            Registros.Remove(elementoParaExcluir);
        }

        public TipoEntidade? SelecionarPeloId(int id)
        {
            return Registros.FirstOrDefault(x => x.Id == id);
        }

        public List<TipoEntidade> SelecionarTodos()
        {
            return Registros;
        }
    }
}
