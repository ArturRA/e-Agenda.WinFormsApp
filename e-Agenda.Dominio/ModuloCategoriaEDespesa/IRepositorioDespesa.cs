namespace e_Agenda.Dominio.ModuloCategoriaEDespesa
{
    public interface IRepositorioDespesa : IRepositorio<EntidadeDespesa>
    {
        public List<EntidadeDespesa>? SelecionarDespesasDaCategoria(EntidadeCategoria? entidade);
    }
}
