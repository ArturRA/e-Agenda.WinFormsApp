using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public class RepositorioTarefaEmArquivo : RepositorioEmArquivo<EntidadeTarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<EntidadeTarefa>? SelecionarConcluidas()
        {
            return ObterRegistros()
                .Where(x => x.PercentualConcluido == 100)
                .OrderByDescending(x => x.Prioridade)
                .ToList();
        }

        public List<EntidadeTarefa>? SelecionarPendentes()
        {
            return ObterRegistros()
                .Where(x => x.PercentualConcluido < 100)
                .OrderByDescending(x => x.Prioridade)
                .ToList();
        }

        public List<EntidadeTarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return ObterRegistros()
                .OrderByDescending(x => x.Prioridade)
                .ToList();
        }

        protected override List<EntidadeTarefa> ObterRegistros()
        {
            return ContextoDados.Tarefas;
        }
    }
}
