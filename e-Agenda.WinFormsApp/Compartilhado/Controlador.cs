namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class Controlador
    {
        public string ToolTipInserir => $"Inserir novo {TipoDoCadastro}";
        public string ToolTipEditar => $"Editar {TipoDoCadastro} existente";
        public string ToolTipExcluir => $"Excluir {TipoDoCadastro} existente";
        public string ToolTipFiltrar => $"Filtrar {TipoDoCadastro} existente";
        public string ObterTipoCadastro => $"Cadastro de {TipoDoCadastro}";

        public abstract string TipoDoCadastro { get; }
        public abstract bool ToolTipEnableInserir { get; }
        public abstract bool ToolTipEnableEditar { get; }
        public abstract bool ToolTipEnableExcluir { get; }
        public abstract bool ToolTipEnableFiltrar { get; }
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract void Filtrar();
        public abstract UserControl ObterListagem();

    }

}
