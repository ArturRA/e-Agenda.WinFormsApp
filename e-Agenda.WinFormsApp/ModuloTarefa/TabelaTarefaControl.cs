using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl(List<EntidadeTarefa> listaDeTarefas)
        {
            InitializeComponent();

            AtualizarRegistros(listaDeTarefas);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeTarefa> listaDeTarefas)
        {
            grid.DataSource = listaDeTarefas;
        }

        public EntidadeTarefa ObterTarefaSelecionada()
        {
            return (EntidadeTarefa)grid.SelectedRows[0].DataBoundItem;
        }
    }
}