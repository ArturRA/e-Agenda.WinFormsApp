namespace e_Agenda.WinApp.ModuloContato
{
    public partial class ListagemContatoControl : UserControl
    {
        public ListagemContatoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<EntidadeContato> contatos)
        {
            listBoxEntidades.Items.Clear();

            contatos.ForEach(c => listBoxEntidades.Items.Add(c));
        }

        public EntidadeContato ObterContatoSelecionado()
        {
            return (EntidadeContato)listBoxEntidades.SelectedItem;
        }
    }
}
