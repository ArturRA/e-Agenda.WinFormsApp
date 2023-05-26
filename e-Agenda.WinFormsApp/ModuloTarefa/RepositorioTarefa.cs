using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public class RepositorioTarefa : Repositorio<EntidadeTarefa>
    {
        public List<EntidadeTarefa>? SelecionarConcluidas()
        {
            return Registros
                .Where(x => x.PercentualConcluido == 100)
                .OrderByDescending(x => x.Prioridade)
                .ToList();
        }

        public List<EntidadeTarefa>? SelecionarPendentes()
        {
            return Registros
                .Where(x => x.PercentualConcluido < 100)
                .OrderByDescending(x => x.Prioridade)
                .ToList();
        }

        public List<EntidadeTarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return Registros
                .OrderByDescending(x => x.Prioridade)
                .ToList();
        }
    }
}
