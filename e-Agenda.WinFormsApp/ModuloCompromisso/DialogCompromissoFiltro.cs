namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public partial class DialogCompromissoFiltro : Form
    {
        private TipoDoFiltro TipoFiltro { get; set; }
        public enum TipoDoFiltro
        {
            Todos = 0,
            Passados = 1,
            Futuros = 2
        }

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

        public TipoDoFiltro TipoDeFiltroSelecionado()
        {
            return TipoFiltro;
        }

        public DateTime DataInicial
        {
            get { return dtpDataInicial.Value; }
        }

        public DateTime DataFinal
        {
            get { return dtpDataFinal.Value; }
        }
    }
}
