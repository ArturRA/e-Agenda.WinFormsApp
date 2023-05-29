using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl(List<EntidadeContato> listaDeContatos)
        {
            InitializeComponent();

            AtualizarRegistros(listaDeContatos);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeContato> listaDeContatos)
        {
            grid.DataSource = listaDeContatos;
        }

        public EntidadeContato ObterContatoSelecionado()
        {
            return (EntidadeContato)grid.SelectedRows[0].DataBoundItem;
        }
    }
}
