using e_Agenda.WinApp.Compartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : Controlador
    {
        public override string TipoDoCadastro { get { return "Tarefa"; } }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        { 
        
        }

        public override void Inserir()
        {
            DialogTarefa telaTarefa = new DialogTarefa();

            telaTarefa.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
            return new ListagemTarefaControl();
        }
    }
}
