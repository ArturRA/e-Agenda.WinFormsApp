using static e_Agenda.WinFormsApp.ModuloCompromisso.DialogCompromissoFiltro;

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

        public void AtualizarRegistrosComFiltro(List<EntidadeCompromisso> entidades, TipoDoFiltro TipoFiltro, DateTime dataInicial, DateTime dataFinal)
        {
            listBoxEntidades.Items.Clear();

            switch (TipoFiltro)
            {
                case TipoDoFiltro.Todos:
                    entidades.ForEach(c => listBoxEntidades.Items.Add(c));
                    break;
                case TipoDoFiltro.Passados:
                    entidades.ForEach(c =>
                    {
                        if (DateTime.Compare(c.DataCompromisso, DateTime.Now) < 0)
                            listBoxEntidades.Items.Add(c);
                    });
                    break;
                case TipoDoFiltro.Futuros:
                    entidades.ForEach(c =>
                    {
                        if (c.DataCompromisso > dataInicial
                         && c.DataCompromisso < dataFinal)
                            listBoxEntidades.Items.Add(c);
                    });
                    break;
            }
        }

        public EntidadeCompromisso ObterContatoSelecionado()
        {
            return (EntidadeCompromisso)listBoxEntidades.SelectedItem;
        }
    }
}
