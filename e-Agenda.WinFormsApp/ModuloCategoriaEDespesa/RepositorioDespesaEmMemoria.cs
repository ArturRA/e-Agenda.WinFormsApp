using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public class RepositorioDespesaEmMemoria : RepositorioEmMemoria<EntidadeDespesa>, IRepositorioDespesa
    {
        public List<EntidadeDespesa>? SelecionarDespesasDaCategoria(EntidadeCategoria? entidade)
        {
            return Registros
                .Where(x => x.Categorias.Any(e => e.Id == entidade!.Id))
                .ToList();
        }
    }
}
