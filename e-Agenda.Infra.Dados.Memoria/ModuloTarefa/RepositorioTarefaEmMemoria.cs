using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.Infra.Dados.Memoria.ModuloTarefa
{
    public class RepositorioTarefaEmMemoria : RepositorioEmMemoria<EntidadeTarefa>, IRepositorioTarefa
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
