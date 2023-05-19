namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class Controlador
    {
        public abstract string TipoDoCadastro { get; }
        public string ToolTipInserir { get { return $"Inserir novo {TipoDoCadastro}"; } }
        public string ToolTipEditar { get { return $"Editar {TipoDoCadastro} existente"; } }
        public string ToolTipExcluir { get { return $"Excluir {TipoDoCadastro} existente"; } }
        public string ToolTipFiltrar { get { return $"Filtrar {TipoDoCadastro} existente"; } }
        public string ObterTipoCadastro { get { return $"Cadastro de {TipoDoCadastro}"; } }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public abstract UserControl ObterListagem();

        public abstract void Filtrar();
    }

}
