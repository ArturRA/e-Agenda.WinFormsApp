namespace e_Agenda.WinFormsApp.Compartilhado
{
    public interface IRepositorio<TipoEntidade>
        where TipoEntidade : Entidade<TipoEntidade>
    {
        public void Inserir(TipoEntidade entidade);
        public void Editar(TipoEntidade entidade);
        public void Excluir(TipoEntidade entidade);
        public TipoEntidade? SelecionarPeloId(int id);
        public List<TipoEntidade> SelecionarTodos();
    }
}
