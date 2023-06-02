using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorio<EntidadeCompromisso>
    {
        public List<EntidadeCompromisso> SelecionarCompromissosPassados();
        public List<EntidadeCompromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
    }
}
