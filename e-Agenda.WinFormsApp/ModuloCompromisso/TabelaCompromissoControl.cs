using e_Agenda.WinFormsApp.Compartilhado;
using System.ComponentModel;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl(List<EntidadeCompromisso> listaDeEntidades)
        {
            InitializeComponent();

            AtualizarRegistros(listaDeEntidades);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeCompromisso> listaDeEntidades)
        {
            BindingList<EntidadeCompromisso> bindingList = new BindingList<EntidadeCompromisso>(listaDeEntidades);
            BindingSource source = new BindingSource(bindingList, null);
            grid.DataSource = source;
        }

        public EntidadeCompromisso? ObterEntidadeSelecionada()
        {
            List<DataGridViewRow> rows = grid.SelectedRows.Cast<DataGridViewRow>().ToList();
            if (rows.Count > 0)
            {
                return rows[0].DataBoundItem as EntidadeCompromisso;
            }
            return null;
        }
    }
}
