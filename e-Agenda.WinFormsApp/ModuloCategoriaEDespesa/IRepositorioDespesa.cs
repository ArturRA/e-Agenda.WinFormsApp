using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public interface IRepositorioDespesa : IRepositorio<EntidadeDespesa>
    {
        public List<EntidadeDespesa>? SelecionarDespesasDaCategoria(EntidadeCategoria? entidade);
    }
}
