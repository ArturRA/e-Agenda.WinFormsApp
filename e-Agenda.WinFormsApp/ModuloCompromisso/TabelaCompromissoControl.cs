using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl(List<EntidadeCompromisso> listaDeCompromissos)
        {
            InitializeComponent();

            AtualizarRegistros(listaDeCompromissos);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeCompromisso> listaDeCompromissos)
        {
            grid.DataSource = listaDeCompromissos;
        }

        public EntidadeCompromisso ObterCompromissoSelecionado()
        {
            return (EntidadeCompromisso)grid.SelectedRows[0].DataBoundItem;
        }
    }
}
