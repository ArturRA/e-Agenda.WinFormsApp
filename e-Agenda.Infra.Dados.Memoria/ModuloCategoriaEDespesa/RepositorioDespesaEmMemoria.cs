using e_Agenda.Dominio.ModuloCategoriaEDespesa;

namespace e_Agenda.Infra.Dados.Memoria.ModuloCategoriaEDespesa
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
