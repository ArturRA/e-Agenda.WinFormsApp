namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class Controlador
    {
        public abstract string TipoDoCadastro { get; }
        public string ToolTipInserir => $"Inserir novo {TipoDoCadastro}";
        public string ToolTipEditar => $"Editar {TipoDoCadastro} existente";
        public string ToolTipExcluir => $"Excluir {TipoDoCadastro} existente";
        public virtual string ToolTipFiltrar => "";
        public virtual string ToolTipAdicionarItens => "";
        public virtual string ToolTipConcluirItens => "";
        public string ObterTipoCadastro => $"Cadastro de {TipoDoCadastro}";

        public virtual bool ToolTipEnableInserir => true;
        public virtual bool ToolTipEnableEditar => true;
        public virtual bool ToolTipEnableExcluir => true;
        public virtual bool ToolTipEnableFiltrar => false;
        public virtual bool ToolTipEnableAdicionarItens => false;
        public virtual bool ToolTipEnableConcluirItens => false;

        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract void Filtrar();
        public abstract UserControl ObterListagem();

    }

}
