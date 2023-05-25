using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : Controlador
    {
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
