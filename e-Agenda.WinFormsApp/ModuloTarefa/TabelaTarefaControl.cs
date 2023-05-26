using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {
        public TabelaTarefaControl(List<EntidadeTarefa> listaDetarefas)
        {
            InitializeComponent();

            AtualizarRegistros(listaDetarefas);

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<EntidadeTarefa> listaDetarefas)
        {
            grid.DataSource = listaDetarefas;
        }

        public EntidadeTarefa ObterTarefaSelecionada()
        {
            return (EntidadeTarefa)grid.SelectedRows[0].DataBoundItem;
        }
        
        //private void ConfigurarColunas()
        //{
        //    dataTable = new DataTable();
        //    dataTable.Columns.Add("Id");
        //    dataTable.Columns.Add("Título");
        //    dataTable.Columns.Add("Prioridade");
        //    dataTable.Columns.Add("% Concluído");
        //}
        
        //public void AtualizarRegistros(List<EntidadeTarefa> tarefas)
        //{
        //    dataTable.Clear();

        //    tarefas.ForEach(tarefa => dataTable.Rows.Add(tarefa.Id, tarefa.Titulo, tarefa.Prioridade, tarefa.PercentualConcluido));
        //}
    }
}