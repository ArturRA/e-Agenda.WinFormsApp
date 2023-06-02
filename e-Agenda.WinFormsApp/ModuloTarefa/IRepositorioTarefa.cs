using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorio<EntidadeTarefa>
    {
        public List<EntidadeTarefa>? SelecionarConcluidas();
        public List<EntidadeTarefa>? SelecionarPendentes();
        public List<EntidadeTarefa> SelecionarTodosOrdenadosPorPrioridade();
    }
}
