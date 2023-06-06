namespace e_Agenda.Dominio.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorio<EntidadeTarefa>
    {
        public List<EntidadeTarefa>? SelecionarConcluidas();
        public List<EntidadeTarefa>? SelecionarPendentes();
        public List<EntidadeTarefa> SelecionarTodosOrdenadosPorPrioridade();
    }
}
