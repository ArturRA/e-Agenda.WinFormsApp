using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.Infra.Dados.Arquivo.ModuloCompromisso
{
    public class RepositorioCompromissoEmArquivo : RepositorioEmArquivo<EntidadeCompromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<EntidadeCompromisso> SelecionarCompromissosPassados()
        {
            return ObterRegistros().Where(x => x.Data.Date < DateTime.Now).ToList();
        }

        public List<EntidadeCompromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return ObterRegistros()
                .Where(x => x.Data > dataInicio)
                .Where(x => x.Data < dataFinal)
                .ToList();
        }

        protected override List<EntidadeCompromisso> ObterRegistros()
        {
            return ContextoDados.Compromissos;
        }
    }
}
