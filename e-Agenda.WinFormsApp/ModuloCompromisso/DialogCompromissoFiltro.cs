namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public partial class DialogCompromissoFiltro : Form
    {
        public enum TipoDoFiltro
        {
            Todos = 0,
            Passados = 1,
            Futuros = 2
        }

        public TipoDoFiltro TipoFiltro { get; private set; }
        public DateTime DataInicial => dtpDataInicial.Value;
        public DateTime DataFinal => dtpDataFinal.Value;

        public DialogCompromissoFiltro()
        {
            InitializeComponent();
            rdbTodos.CheckedChanged += rdbLocalizacaoChanged;
            rdbPassados.CheckedChanged += rdbLocalizacaoChanged;
            rdbFuturos.CheckedChanged += rdbLocalizacaoChanged;
        }

        private void rdbLocalizacaoChanged(object? sender, EventArgs e)
        {
            RadioButton? rdb = sender as RadioButton;
            TipoFiltro = (TipoDoFiltro)Convert.ToInt32(rdb!.Tag);
        }

    }
}
