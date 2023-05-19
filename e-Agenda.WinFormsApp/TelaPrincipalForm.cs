using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;
using e_Agenda.WinFormsApp.ModuloCompromisso;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private Controlador Controlador { get; set; }
        private RepositorioContato RepositorioContato { get; set; } = new RepositorioContato();
        private RepositorioCompromisso RepositorioCompromisso { get; set; } = new RepositorioCompromisso();


        public TelaPrincipalForm()
        {
            InitializeComponent();
        }
        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            Controlador = new ControladorCompromisso(RepositorioCompromisso);

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