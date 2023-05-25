using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public class ControladorTarefa : Controlador
    {
        private RepositorioTarefa RepositorioTarefa { get; set; }
        private ListagemTarefaControl ListagemTarefaControl { get; set; }
        public override string TipoDoCadastro => "Tarefa";
        public override string ToolTipFiltrar => $"Filtrar {TipoDoCadastro} existente";
        public override bool ToolTipEnableFiltrar => true;

        public override void Inserir()
        {
            DialogTarefa telaTarefa = new DialogTarefa();

            telaTarefa.ShowDialog();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        { 
        
        }

        public override UserControl ObterListagem()
        {
            return new ListagemTarefaControl();
        }

        public override void Filtrar()
        {
            throw new NotImplementedException();
        }
    }
}
