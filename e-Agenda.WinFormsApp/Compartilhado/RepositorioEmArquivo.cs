namespace e_Agenda.WinFormsApp.Compartilhado
{
    public abstract class RepositorioEmArquivo<TipoEntidade>
        where TipoEntidade : Entidade<TipoEntidade>
    {
        private int ContadorDeId { get; set; }
        protected ContextoDados ContextoDados { get; set; }

        public RepositorioEmArquivo(ContextoDados contexto)
        {
            ContextoDados = contexto;

            AtualizarContador();
        }

        protected abstract List<TipoEntidade> ObterRegistros();

        public void Inserir(TipoEntidade novoRegistro)
        {
            List<TipoEntidade> registros = ObterRegistros();

            ContadorDeId++;
            novoRegistro.Id = ContadorDeId;
            registros.Add(novoRegistro);

            ContextoDados.GravarEmArquivoJson();
        }

        public void Editar(TipoEntidade registroAtualizado)
        {
            TipoEntidade? registroSelecionado = SelecionarPeloId(registroAtualizado.Id);

            registroSelecionado!.Editar(registroAtualizado);

            ContextoDados.GravarEmArquivoJson();
        }

        public void Excluir(TipoEntidade registroSelecionado)
        {
            List<TipoEntidade> registros = ObterRegistros();

            registros.Remove(registroSelecionado);

            ContextoDados.GravarEmArquivoJson();
        }

        public TipoEntidade? SelecionarPeloId(int Id)
        {
            List<TipoEntidade> registros = ObterRegistros();

            return registros.FirstOrDefault(x => x.Id == Id);
        }

        public List<TipoEntidade> SelecionarTodos()
        {
            return ObterRegistros();
        }

        private void AtualizarContador()
        {
            if (ObterRegistros().Count > 0)
                ContadorDeId = ObterRegistros().Max(x => x.Id);
        }
    }
}
