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
            TipoEntidade entidadeParaAtualizar = SelecionarElementoPeloId(entidadeComValoresAtualizados.Id);
            entidadeParaAtualizar.Editar(entidadeComValoresAtualizados);
            //// Pega o tipo e para cada propriedade, que não seja o id, atualiza o valor
            //typeof(TipoEntidade).GetProperties().ToList().ForEach(p =>
            //{
            //    if (!p.Name.Equals("Id"))
            //        p.SetValue(entidadeParaAtualizar, p.GetValue(entidadeComValoresAtualizados));
            //});
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

        public bool EstaVazio()
        {
            if (Registros.Count == 0)
                return true;
            else
                return false;
        }
    }
}
