using e_Agenda.Dominio.ModuloCategoriaEDespesa;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public partial class DialogDespesasDeCategoria : Form
    {
        public DialogDespesasDeCategoria(string Descricao, List<EntidadeDespesa> entidades)
        {
            InitializeComponent();

            labelCategoria.Text = Descricao;

            TabelaDespesaControl TabelaDespesa = new TabelaDespesaControl(entidades);
            panelDespesas.Controls.Add(TabelaDespesa);

            TabelaDespesa.AtualizarRegistros(entidades);
        }
    }
}
