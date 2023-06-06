namespace e_Agenda.Dominio.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorio<EntidadeCompromisso>
    {
        public List<EntidadeCompromisso> SelecionarCompromissosPassados();
        public List<EntidadeCompromisso> SelecionarCompromissosFuturos(DateTime dataInicio, DateTime dataFinal);
    }
}
