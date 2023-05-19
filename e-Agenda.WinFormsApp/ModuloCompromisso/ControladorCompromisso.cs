using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using static e_Agenda.WinFormsApp.ModuloCompromisso.DialogCompromissoFiltro;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    internal class ControladorCompromisso : Controlador
    {
        private RepositorioCompromisso RepositorioCompromisso { get; set; }
        private ListagemCompromissoControl ListagemCompromissoControl { get; set; }
        public override string TipoDoCadastro { get { return "Compromisso"; } }

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso)
        {
            RepositorioCompromisso=repositorioCompromisso;
        }
        
        public override void Inserir()
        {
            DialogCompromisso dialog = new DialogCompromisso();

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

            DialogCompromisso dialog = new DialogCompromisso();
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

        public void Filtrar()
        {
            DialogCompromissoFiltro dialog = new DialogCompromissoFiltro();

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                TipoDoFiltro TipoFiltro = dialog.TipoDeFiltroSelecionado();

                List<EntidadeCompromisso> entidades = RepositorioCompromisso.SelecionarTodaALista();

                ListagemCompromissoControl.AtualizarRegistros(entidades);

                switch (TipoFiltro)
                {
                    case TipoDoFiltro.Todos:
                        ListagemCompromissoControl.AtualizarRegistros(entidades);
                        break;
                    case TipoDoFiltro.Passados:
                        ListagemCompromissoControl.AtualizarRegistrosPassados(entidades);
                        break;
                    case TipoDoFiltro.Futuros:
                        ListagemCompromissoControl.AtualizarRegistrosRange(entidades, dialog.DataInicial(), dialog.DataFinal());
                        break;
                }

                CarregarContatos();
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
