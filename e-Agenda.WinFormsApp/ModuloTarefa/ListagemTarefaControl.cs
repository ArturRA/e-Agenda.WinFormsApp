namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl
    {
        List<EntidadeTarefa> tarefas = new List<EntidadeTarefa>();

        public ListagemTarefaControl()
        {
            InitializeComponent();

            tarefas.Add(new EntidadeTarefa(1, "Lavar o carro", "alta"));
            tarefas.Add(new EntidadeTarefa(2, "Lavar o cachorro", "alta"));

            foreach (EntidadeTarefa tarefa in tarefas)
            {
                listTarefas.Items.Add(tarefa);  
            }
        }
    }
}

