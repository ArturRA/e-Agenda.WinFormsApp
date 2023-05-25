using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;
using e_Agenda.WinFormsApp.ModuloCompromisso;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm? Instancia { get; set; }

        private Controlador Controlador { get; set; }
        private RepositorioContato RepositorioContato { get; set; } = new RepositorioContato();
        private RepositorioCompromisso RepositorioCompromisso { get; set; } = new RepositorioCompromisso();



        public TelaPrincipalForm()
        {
            InitializeComponent();
            PreencherEntidadesExemplo();
            Instancia=this;
        }

        private void PreencherEntidadesExemplo()
        {
            RepositorioContato.Inserir(new EntidadeContato("Ricardo", "49 9 9999-9999", "temp@gmail.com", "Empregado", "Sadia"));
            RepositorioContato.Inserir(new EntidadeContato("Bruno", "49 9 9999-9999", "temp@gmail.com", "Empregado", "Seara"));
            RepositorioContato.Inserir(new EntidadeContato("Maria", "49 9 9999-9999", "temp@gmail.com", "Empregado", "Perdigao"));
        }

        public void AtualizarToolStrip(string text)
        {
            statusLabelTelaPrincipal.Text = text;
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            Controlador = new ControladorCompromisso(RepositorioCompromisso, RepositorioContato);

            ConfigurarTelaPrincipal(Controlador);
        }
        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            Controlador = new ControladorContato(RepositorioContato);

            ConfigurarTelaPrincipal(Controlador);
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            Controlador = new ControladorTarefa();

            ConfigurarTelaPrincipal(Controlador);
        }

        private void ConfigurarTelaPrincipal(Controlador controladorBase)
        {
            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro;

            ConfigurarToolTips(Controlador);

            ConfigurarListagem(Controlador);
        }

        private void ConfigurarToolTips(Controlador controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText= controlador.ToolTipFiltrar;
            btnAdicionarItens.ToolTipText = controlador.ToolTipAdicionarItens;
            btnConcluirItens.ToolTipText = controlador.ToolTipConcluirItens;

            btnInserir.Enabled = controlador.ToolTipEnableInserir;
            btnEditar.Enabled = controlador.ToolTipEnableEditar;
            btnExcluir.Enabled = controlador.ToolTipEnableExcluir;
            btnFiltrar.Enabled = controlador.ToolTipEnableFiltrar;
            btnAdicionarItens.Enabled = controlador.ToolTipEnableAdicionarItens;
            btnConcluirItens.Enabled = controlador.ToolTipEnableConcluirItens;
        }

        private void ConfigurarListagem(Controlador controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            Controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controlador.Excluir();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Controlador.Filtrar();
        }
    }
}