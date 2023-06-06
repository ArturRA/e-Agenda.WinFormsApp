using e_Agenda.Dominio.ModuloCategoriaEDespesa;
using System.ComponentModel;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public partial class TabelaDespesaControl : UserControl
    {
        public TabelaDespesaControl(List<EntidadeDespesa> listaDeEntidades)
        {
            InitializeComponent();

            AtualizarRegistros(listaDeEntidades);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeDespesa> listaDeEntidades)
        {
            BindingList<EntidadeDespesa> bindingList = new BindingList<EntidadeDespesa>(listaDeEntidades);
            BindingSource source = new BindingSource(bindingList, null);
            grid.DataSource = source;
        }

        public EntidadeDespesa? ObterEntidadeSelecionada()
        {
            List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (rows.Count > 0)
            {
                return rows[0].DataBoundItem as EntidadeDespesa;
            }
            return null;
        }
    }
}
