using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    internal class RepositorioCompromisso : Repositorio<EntidadeCompromisso>
    {
        //Selecionar Compromissos Passados
        public List<EntidadeCompromisso> SelecionarCompromissosPassados()
        {
            return Registros.Where(x => x.Data.Date < DateTime.Now).ToList();
        }

        //Selecionar Compromissos Futuros ( dataInicio, dataFinal)
        public List<EntidadeCompromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal)
        {
            return Registros
                .Where(x => x.Data > dataInicio)
                .Where(x => x.Data < dataFinal)
                .ToList();
        }
    }
}
