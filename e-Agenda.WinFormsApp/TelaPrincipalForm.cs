using e_Agenda.WinFormsApp.Compartilhado;
using e_Agenda.WinFormsApp.ModuloContato;
using e_Agenda.WinFormsApp.ModuloTarefa;
using e_Agenda.WinFormsApp.ModuloCompromisso;
using e_Agenda.WinFormsApp.ModuloCategoriaEDespesa;

namespace e_Agenda.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; set; }

        private Controlador Controlador { get; set; }
        private RepositorioCategoria RepositorioCategoria { get; set; } = new RepositorioCategoria();
        private RepositorioContato RepositorioContato { get; set; } = new RepositorioContato();
        private RepositorioCompromisso RepositorioCompromisso { get; set; } = new RepositorioCompromisso();
        private RepositorioDespesa RepositorioDespesa { get; set; } = new RepositorioDespesa();
        private RepositorioTarefa RepositorioTarefa { get; set; } = new RepositorioTarefa();



        public TelaPrincipalForm()
        {
            InitializeComponent();
            PreencherEntidadesExemplo();
            Instancia=this;
        }

        private void PreencherEntidadesExemplo()
        {
            EntidadeContato ricardo = new EntidadeContato("Ricardo", "49 9 9999-9999", "temp@gmail.com", "Empregado", "Sadia");
            EntidadeContato bruno = new EntidadeContato("Bruno", "49 9 9999-9999", "temp@gmail.com", "Empregado", "Seara");
            EntidadeContato maria = new EntidadeContato("Maria", "49 9 9999-9999", "temp@gmail.com", "Empregado", "Perdigao");

            RepositorioContato.Inserir(ricardo);
            RepositorioContato.Inserir(bruno);
            RepositorioContato.Inserir(maria);

            RepositorioCompromisso.Inserir(new EntidadeCompromisso("Entrevista - Ricardo",
                                           new DateTime(2023, 5, 21),
                                           new TimeSpan(12, 0, 0),
                                           new TimeSpan(12, 30, 0),
                                           true,
                                           ricardo,
                                           TipoDaLocalizacao.Presencial,
                                           "Lages na uniplac"));
            RepositorioCompromisso.Inserir(new EntidadeCompromisso("Entrevista - bruno",
                                           new DateTime(2023, 5, 21),
                                           new TimeSpan(12, 30, 0),
                                           new TimeSpan(13, 0, 0),
                                           true,
                                           bruno,
                                           TipoDaLocalizacao.Presencial,
                                           "Lages na uniplac"));
            RepositorioCompromisso.Inserir(new EntidadeCompromisso("Entrevista - maria",
                                           new DateTime(2023, 5, 21),
                                           new TimeSpan(13, 0, 0),
                                           new TimeSpan(13, 30, 0),
                                           true,
                                           maria,
                                           TipoDaLocalizacao.Presencial,
                                           "Lages na uniplac"));


            EntidadeTarefa t1 = new EntidadeTarefa("Preparar Apresentação 1", PrioridadeTarefaEnum.Alta, DateTime.Now);
            t1.AdicionarItem(new ItemTarefa("a"));
            t1.AdicionarItem(new ItemTarefa("b"));
            t1.AdicionarItem(new ItemTarefa("c"));

            EntidadeTarefa t2 = new EntidadeTarefa("Preparar Apresentação 2 ", PrioridadeTarefaEnum.Alta, DateTime.Now);
            t2.AdicionarItem(new ItemTarefa("a"));
            t2.AdicionarItem(new ItemTarefa("b"));
            t2.AdicionarItem(new ItemTarefa("c"));


            EntidadeTarefa t3 = new EntidadeTarefa("Preparar Apresentação 3 ", PrioridadeTarefaEnum.Baixa, DateTime.Now);
            t3.AdicionarItem(new ItemTarefa("a"));
            t3.AdicionarItem(new ItemTarefa("b"));
            t3.AdicionarItem(new ItemTarefa("c"));

            EntidadeTarefa t4 = new EntidadeTarefa("Preparar Apresentação 4 ", PrioridadeTarefaEnum.Alta, DateTime.Now);
            t4.AdicionarItem(new ItemTarefa("a"));
            t4.AdicionarItem(new ItemTarefa("b"));
            t4.AdicionarItem(new ItemTarefa("c"));

            EntidadeTarefa t5 = new EntidadeTarefa("Preparar Apresentação 5", PrioridadeTarefaEnum.Normal, DateTime.Now);
            t5.AdicionarItem(new ItemTarefa("a"));
            t5.AdicionarItem(new ItemTarefa("b"));
            t5.AdicionarItem(new ItemTarefa("c"));

            EntidadeTarefa t6 = new EntidadeTarefa("Preparar Apresentação 6", PrioridadeTarefaEnum.Baixa, DateTime.Now);
            t6.AdicionarItem(new ItemTarefa("a"));
            t6.AdicionarItem(new ItemTarefa("b"));
            t6.AdicionarItem(new ItemTarefa("c"));

            RepositorioTarefa.Inserir(t1);
            RepositorioTarefa.Inserir(t2);
            RepositorioTarefa.Inserir(t3);
            RepositorioTarefa.Inserir(t4);
            RepositorioTarefa.Inserir(t5);
            RepositorioTarefa.Inserir(t6);
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