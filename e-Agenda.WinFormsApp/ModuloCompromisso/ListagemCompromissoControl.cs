using e_Agenda.WinApp.ModuloContato;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

        public void AtualizarRegistrosPassados(List<EntidadeCompromisso> entidades)
        {
            listBoxEntidades.Items.Clear();
            entidades.ForEach(c =>
            {
                if (DateTime.Compare(c.DataCompromisso, DateTime.Now) < 0)
                    listBoxEntidades.Items.Add(c);
            });
        }

        public void AtualizarRegistrosRange(List<EntidadeCompromisso> entidades, DateTime dataInicial, DateTime dataFinal)
        {
            listBoxEntidades.Items.Clear();
            entidades.ForEach(c =>
            {
                if (c.DataCompromisso > dataInicial
                 && c.DataCompromisso < dataFinal)
                    listBoxEntidades.Items.Add(c);
            });
        }

        public EntidadeCompromisso ObterContatoSelecionado()
        {
            return (EntidadeCompromisso)listBoxEntidades.SelectedItem;
        }
    }
}
