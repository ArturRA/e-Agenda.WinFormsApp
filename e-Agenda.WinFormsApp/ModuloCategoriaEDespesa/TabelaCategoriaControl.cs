using e_Agenda.WinFormsApp.Compartilhado;
using System.ComponentModel;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public partial class TabelaCategoriaControl : UserControl
    {
        public TabelaCategoriaControl(List<EntidadeCategoria> listaDeEntidades)
        {
            InitializeComponent();

            AtualizarRegistros(listaDeEntidades);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeCategoria> listaDeEntidades)
        {
            BindingList<EntidadeCategoria> bindingList = new BindingList<EntidadeCategoria>(listaDeEntidades);
            BindingSource source = new BindingSource(bindingList, null);
            grid.DataSource = source;
        }

        public EntidadeCategoria? ObterEntidadeSelecionada()
        {
            List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (rows.Count > 0)
            {
                return rows[0].DataBoundItem as EntidadeCategoria;
            }
            return null;
        }
    }
}
