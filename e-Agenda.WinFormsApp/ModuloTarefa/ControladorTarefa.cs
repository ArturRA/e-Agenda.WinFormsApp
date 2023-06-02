using e_Agenda.WinFormsApp.Compartilhado;
using static e_Agenda.WinFormsApp.ModuloTarefa.DialogTarefaFiltro;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public class ControladorTarefa : Controlador
    {
        private IRepositorioTarefa RepositorioTarefa { get; set; }
        private TabelaTarefaControl TabelaTarefa { get; set; }
        public override string TipoDoCadastro => "Tarefa";
        public override string ToolTipFiltrar => $"Filtrar {TipoDoCadastro} existente";
        public override string ToolTipAdicionarItens => $"Adicionar Itens a {TipoDoCadastro}";
        public override string ToolTipConcluirItens => $"Concluir Itens da {TipoDoCadastro}";
        public override bool ToolTipEnableFiltrar => true;
        public override bool ToolTipEnableAdicionarItens => true;
        public override bool ToolTipEnableConcluirItens => true;

        public ControladorTarefa(IRepositorioTarefa repositorioTarefa)
        {
            RepositorioTarefa=repositorioTarefa;
        }

        public override void Inserir()
        {
            DialogTarefa dialog = new DialogTarefa(false);
            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeTarefa entidade = dialog.Tarefa;

                RepositorioTarefa.Inserir(entidade);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            EntidadeTarefa? entidade = TabelaTarefa.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogTarefa dialog = new DialogTarefa(true);
            dialog.Tarefa = entidade;

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioTarefa.Editar(dialog.Tarefa);

                CarregarEntidades();
            }
        }

        public override void Excluir()
        {
            EntidadeTarefa? entidade = TabelaTarefa.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Exclusão de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {entidade.Titulo}?",
                                                          $"Exclusão de {TipoDoCadastro}s",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioTarefa.Excluir(entidade);

                CarregarEntidades();
            }
        }

        public override void Filtrar()
        {
            DialogTarefaFiltro dialog = new DialogTarefaFiltro();

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                TipoDoFiltroTarefa TipoFiltro = dialog.TipoFiltroTarefa;
                List<EntidadeTarefa>? entidades = null;

                switch (TipoFiltro)
                {
                    case TipoDoFiltroTarefa.Pendentes:
                        entidades = RepositorioTarefa.SelecionarPendentes();
                        break;
                    case TipoDoFiltroTarefa.Concluidas:
                        entidades = RepositorioTarefa.SelecionarConcluidas();
                        break;
                    default:
                        entidades = RepositorioTarefa.SelecionarTodosOrdenadosPorPrioridade();
                        break;
                }

                CarregarEntidades(entidades!);

                TelaPrincipalForm.Instancia.AtualizarToolStrip($"Visualizando {entidades!.Count} compromissos");
            }
        }

        public override void AdicionarItens()
        {
            EntidadeTarefa? entidade = TabelaTarefa.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Adição de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogTarefaCadastroItens dialog = new DialogTarefaCadastroItens(entidade);

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> listaDeItensAtualizados = dialog.ObterItensCadastrados();
                listaDeItensAtualizados.ForEach(i => entidade.AdicionarItem(i));
                CarregarEntidades();
            }
        }

        public override void ConcluirItens()
        {
            EntidadeTarefa? entidade = TabelaTarefa.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Atualização de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogTarefaAtualizcaoItens dialog = new DialogTarefaAtualizcaoItens(entidade);

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensChecked = dialog.ObterItensChecked();
                itensChecked.ForEach(i => entidade.CheckItem(i));
                List<ItemTarefa> itensUnChecked = dialog.ObterItensUnChecked();
                itensUnChecked.ForEach(i => entidade.UnCheckItem(i));

                CarregarEntidades();
            }
        }

        private void CarregarEntidades()
        {
            List<EntidadeTarefa> entidades = RepositorioTarefa.SelecionarTodosOrdenadosPorPrioridade();

            TabelaTarefa.AtualizarRegistros(entidades);
        }

        private void CarregarEntidades(List<EntidadeTarefa> entidades)
        {
            TabelaTarefa.AtualizarRegistros(entidades);
        }

        public override UserControl ObterListagem()
        {
            TabelaTarefa ??= new TabelaTarefaControl(RepositorioTarefa.SelecionarTodos());

            CarregarEntidades();

            return TabelaTarefa;
        }
    }
}
