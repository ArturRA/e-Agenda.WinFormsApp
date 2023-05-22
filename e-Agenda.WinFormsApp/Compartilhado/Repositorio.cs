namespace e_Agenda.WinApp.Compartilhado
{
    public class Repositorio<TipoEntidade> where TipoEntidade : Entidade<TipoEntidade>
    {
        protected int contadorDeId = 1;
        protected List<TipoEntidade> Registros { get;} = new List<TipoEntidade>();

        public void Inserir(TipoEntidade entidade)
        {
            entidade.Id = contadorDeId;
            Registros.Add(entidade);
            contadorDeId++;
        }

        public void Editar(TipoEntidade entidadeComValoresAtualizados)
        {
            TipoEntidade? entidadeParaAtualizar = SelecionarElementoPeloId(entidadeComValoresAtualizados.Id);
            entidadeParaAtualizar!.Editar(entidadeComValoresAtualizados);
        }

        public void Excluir(TipoEntidade elementoParaExcluir)
        {
            Registros.Remove(elementoParaExcluir);
        }

        public TipoEntidade? SelecionarElementoPeloId(int id)
        {
            return Registros.FirstOrDefault(x => x.Id == id);
        }

        public List<TipoEntidade> SelecionarTodaALista()
        {
            return Registros;
        }
    }
}
