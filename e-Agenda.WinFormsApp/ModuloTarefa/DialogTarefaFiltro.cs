namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public partial class DialogTarefaFiltro : Form
    {
        public enum TipoDoFiltroTarefa
        {
            Todos = 0,
            Pendentes = 1,
            Concluidas = 2
        }

        public TipoDoFiltroTarefa TipoFiltroTarefa { get; private set; }

        public DialogTarefaFiltro()
        {
            InitializeComponent();
            rdbTodos.CheckedChanged += rdbFiltroChanged;
            rdbPendentes.CheckedChanged += rdbFiltroChanged;
            rdbConcluidas.CheckedChanged += rdbFiltroChanged;
        }

        private void rdbFiltroChanged(object? sender, EventArgs e)
        {
            RadioButton? rdb = sender as RadioButton;
            TipoFiltroTarefa = (TipoDoFiltroTarefa)Convert.ToInt32(rdb!.Tag);
        }
    }
}
