using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.Infra.Dados.Memoria.ModuloCompromisso
{
    public class RepositorioCompromissoEmMemoria : RepositorioEmMemoria<EntidadeCompromisso>, IRepositorioCompromisso
    {
        public List<EntidadeCompromisso> SelecionarCompromissosPassados()
        {
            return Registros.Where(x => x.Data.Date < DateTime.Now).ToList();
        }

        public List<EntidadeCompromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return Registros
                .Where(x => x.Data > dataInicio)
                .Where(x => x.Data < dataFinal)
                .ToList();
        }
    }
}
