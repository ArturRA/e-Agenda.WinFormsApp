using e_Agenda.WinFormsApp.Compartilhado;
using System.ComponentModel;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl(List<EntidadeTarefa> listaDeEntidades)
        {
            InitializeComponent();

            AtualizarRegistros(listaDeEntidades);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeTarefa> listaDeEntidades)
        {
            BindingList<EntidadeTarefa> bindingList = new BindingList<EntidadeTarefa>(listaDeEntidades);
            BindingSource source = new BindingSource(bindingList, null);
            grid.DataSource = source;
        }

        public EntidadeTarefa? ObterEntidadeSelecionada()
        {
            List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (rows.Count > 0)
            {
                return rows[0].DataBoundItem as EntidadeTarefa;
            }
            return null;
        }
    }
}