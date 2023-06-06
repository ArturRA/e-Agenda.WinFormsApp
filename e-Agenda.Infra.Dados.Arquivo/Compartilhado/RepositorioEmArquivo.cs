namespace e_Agenda.Infra.Dados.Arquivo.Compartilhado
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

        public void Inserir(TipoEntidade entidade)
        {
            List<TipoEntidade> registros = ObterRegistros();

            ContadorDeId++;
            entidade.Id = ContadorDeId;
            registros.Add(entidade);

            ContextoDados.GravarEmArquivoJson();
        }

        public void Editar(TipoEntidade entidadeAtualizado)
        {
            TipoEntidade? entidadeParaAtualizar = SelecionarPeloId(entidadeAtualizado.Id);

            entidadeParaAtualizar!.Editar(entidadeAtualizado);

            ContextoDados.GravarEmArquivoJson();
        }

        public void Excluir(TipoEntidade entidade)
        {
            List<TipoEntidade> registros = ObterRegistros();

            registros.Remove(entidade);

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
