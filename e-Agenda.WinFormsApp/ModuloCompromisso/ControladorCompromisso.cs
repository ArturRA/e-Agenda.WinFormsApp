using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using static e_Agenda.WinFormsApp.ModuloCompromisso.DialogCompromissoFiltro;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    internal class ControladorCompromisso : Controlador
    {
        private RepositorioCompromisso RepositorioCompromisso { get; set; }
        private RepositorioContato RepositorioContato { get; set; }
        private ListagemCompromissoControl ListagemCompromissoControl { get; set; }
        public override string TipoDoCadastro => "Compromisso";
        public override bool ToolTipEnableInserir => true;
        public override bool ToolTipEnableEditar => true;
        public override bool ToolTipEnableExcluir => true;
        public override bool ToolTipEnableFiltrar => true;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            RepositorioCompromisso=repositorioCompromisso;
            RepositorioContato=repositorioContato;
        }
        
        public override void Inserir()
        {
            DialogCompromisso dialog = new DialogCompromisso(RepositorioContato.SelecionarTodaALista());
            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeCompromisso entidade = dialog.Compromisso;

                RepositorioCompromisso.Inserir(entidade);

                CarregarContatos();
            }
        }

        public override void Editar()
        {
            EntidadeCompromisso entidade = ListagemCompromissoControl.ObterContatoSelecionado();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogCompromisso dialog = new DialogCompromisso(RepositorioContato.SelecionarTodaALista());
            dialog.Compromisso = entidade;

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioCompromisso.Editar(dialog.Compromisso);

                CarregarContatos();
            }
        }

        public override void Excluir()
        {
            EntidadeCompromisso entidade = ListagemCompromissoControl.ObterContatoSelecionado();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Exclusão de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {entidade.Assunto}?",
                                                          $"Exclusão de {TipoDoCadastro}s",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioCompromisso.Excluir(entidade);

                CarregarContatos();
            }
        }

        public override void Filtrar()
        {
            DialogCompromissoFiltro dialog = new DialogCompromissoFiltro();

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                TipoDoFiltro TipoFiltro = dialog.TipoDeFiltroSelecionado();

                List<EntidadeCompromisso> entidades = RepositorioCompromisso.SelecionarTodaALista();

                ListagemCompromissoControl.AtualizarRegistrosComFiltro(entidades, TipoFiltro, dialog.DataInicial.Date, dialog.DataFinal.Date);
            }
        }

        private void CarregarContatos()
        {
            List<EntidadeCompromisso> entidades = RepositorioCompromisso.SelecionarTodaALista();

            ListagemCompromissoControl.AtualizarRegistros(entidades);
        }

        public override UserControl ObterListagem()
        {
            ListagemCompromissoControl ??= new ListagemCompromissoControl();

            CarregarContatos();

            return ListagemCompromissoControl;
        }
    }
}
