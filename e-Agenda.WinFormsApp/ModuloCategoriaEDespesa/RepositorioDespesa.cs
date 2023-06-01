using e_Agenda.WinFormsApp.Compartilhado;
using e_Agenda.WinFormsApp.ModuloTarefa;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public class RepositorioDespesa : Repositorio<EntidadeDespesa>
    {
        public List<EntidadeDespesa>? SelecionarDespesasDaCategoria(EntidadeCategoria? entidade)
        {
            return Registros
                .Where(x => x.Categorias.Any(e => e.Id == entidade!.Id))
                .ToList();
        }
    }
}
