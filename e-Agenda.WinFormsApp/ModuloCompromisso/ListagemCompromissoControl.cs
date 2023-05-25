namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<EntidadeCompromisso> entidades)
        {
            listBoxEntidades.Items.Clear();

            entidades.ForEach(c => listBoxEntidades.Items.Add(c));
        }

        public EntidadeCompromisso ObterContatoSelecionado()
        {
            return (EntidadeCompromisso)listBoxEntidades.SelectedItem;
        }
    }
}
