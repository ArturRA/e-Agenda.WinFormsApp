using e_Agenda.WinFormsApp.Compartilhado;
using e_Agenda.WinFormsApp.ModuloContato;
using e_Agenda.WinFormsApp.ModuloTarefa;
using e_Agenda.WinFormsApp.ModuloCompromisso;
using e_Agenda.WinFormsApp.ModuloCategoriaEDespesa;

namespace e_Agenda.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        enum TipoDeRepositorio
        {
            EmArquivo,
            EmMemoria
        }
        public static TelaPrincipalForm Instancia { get; set; }

        private Controlador Controlador { get; set; }

        private ContextoDados ContextoDados { get; set; } = new ContextoDados(carregarDados: true);
        private IRepositorioCategoria RepositorioCategoria { get; set; }
        private IRepositorioCompromisso RepositorioCompromisso { get; set; }
        private IRepositorioContato RepositorioContato { get; set; }
        private IRepositorioDespesa RepositorioDespesa { get; set; }
        private IRepositorioTarefa RepositorioTarefa { get; set; }



        public TelaPrincipalForm()
        {
            InitializeComponent();
            EscolhaDeTipoDeRepositorio(TipoDeRepositorio.EmArquivo);
            Instancia=this;
        }

        private void EscolhaDeTipoDeRepositorio(TipoDeRepositorio tipo)
        {
            switch (tipo)
            {
                case TipoDeRepositorio.EmArquivo:
                    RepositorioCategoria = new RepositorioCategoriaEmArquivo(ContextoDados);
                    RepositorioCompromisso = new RepositorioCompromissoEmArquivo(ContextoDados);
                    RepositorioContato = new RepositorioContatoEmArquivo(ContextoDados);
                    RepositorioDespesa = new RepositorioDespesaEmArquivo(ContextoDados);
                    RepositorioTarefa = new RepositorioTarefaEmArquivo(ContextoDados);
                    break;
                case TipoDeRepositorio.EmMemoria:
                    RepositorioCategoria = new RepositorioCategoriaEmMemoria();
                    RepositorioCompromisso = new RepositorioCompromissoEmMemoria();
                    RepositorioContato = new RepositorioContatoEmMemoria();
                    RepositorioDespesa = new RepositorioDespesaEmMemoria();
                    RepositorioTarefa = new RepositorioTarefaEmMemoria();
                    break;
            }
        }

        public void AtualizarToolStrip(string text)
        {
            statusLabelTelaPrincipal.Text = text;
        }
        private void categoriasMenuItem_Click(object sender, EventArgs e)
        {
            Controlador = new ControladorCategoria(RepositorioCategoria, RepositorioDespesa);

            ConfigurarTelaPrincipal(Controlador);
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
        private void despesasMenuItem_Click(object sender, EventArgs e)
        {
            Controlador = new ControladorDespesa(RepositorioDespesa, RepositorioCategoria);

            ConfigurarTelaPrincipal(Controlador);
        }
        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            Controlador = new ControladorTarefa(RepositorioTarefa);

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
            btnListarDespesas.ToolTipText = controlador.ToolTipListarDespesas;

            btnInserir.Enabled = controlador.ToolTipEnableInserir;
            btnEditar.Enabled = controlador.ToolTipEnableEditar;
            btnExcluir.Enabled = controlador.ToolTipEnableExcluir;
            btnFiltrar.Enabled = controlador.ToolTipEnableFiltrar;
            btnAdicionarItens.Enabled = controlador.ToolTipEnableAdicionarItens;
            btnConcluirItens.Enabled = controlador.ToolTipEnableConcluirItens;
            btnListarDespesas.Enabled = controlador.ToolTipEnableListarDespesas;
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

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            Controlador.AdicionarItens();
        }

        private void btnConcluirItens_Click(object sender, EventArgs e)
        {
            Controlador.ConcluirItens();
        }

        private void btnListarDespesas_Click(object sender, EventArgs e)
        {
            Controlador.ListarDespesas();
        }
    }
}