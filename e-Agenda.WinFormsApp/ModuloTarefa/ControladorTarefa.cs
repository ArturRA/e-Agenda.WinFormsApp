using e_Agenda.WinFormsApp.Compartilhado;
using static e_Agenda.WinFormsApp.ModuloTarefa.DialogTarefaFiltro;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public class ControladorTarefa : Controlador
    {
        private RepositorioTarefa RepositorioTarefa { get; set; }
        private TabelaTarefaControl TabelaTarefas { get; set; }
        public override string TipoDoCadastro => "Tarefa";
        public override string ToolTipFiltrar => $"Filtrar {TipoDoCadastro} existente";
        public override string ToolTipAdicionarItens => $"Adicionar Itens a {TipoDoCadastro}";
        public override string ToolTipConcluirItens => $"Concluir Itens da {TipoDoCadastro}";
        public override bool ToolTipEnableFiltrar => true;
        public override bool ToolTipEnableAdicionarItens => true;
        public override bool ToolTipEnableConcluirItens => true;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
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

                CarregarTarefas();
            }
        }

        public override void Editar()
        {
            EntidadeTarefa entidade = TabelaTarefas.ObterTarefaSelecionada();

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

                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            EntidadeTarefa entidade = TabelaTarefas.ObterTarefaSelecionada();

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

                CarregarTarefas();
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

                CarregarTarefas(entidades!);

                TelaPrincipalForm.Instancia.AtualizarToolStrip($"Visualizando {entidades!.Count} compromissos");
            }
        }

        public override void AdicionarItens()
        {
            EntidadeTarefa entidade = TabelaTarefas.ObterTarefaSelecionada();

            if (entidade == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Adição de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogTarefaCadastroItens telaCadastroItensTarefa = new DialogTarefaCadastroItens(entidade);

            DialogResult opcaoEscolhida = telaCadastroItensTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> listaDeItensAtualizados = telaCadastroItensTarefa.ObterItensCadastrados();
                entidade.Itens = listaDeItensAtualizados;
                CarregarTarefas();
            }
        }

        public override void ConcluirItens()
        {
            EntidadeTarefa entidade = TabelaTarefas.ObterTarefaSelecionada();

            if (entidade == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro", "Atualização de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogTarefaAtualizcaoItens telaAtualizacaoItensTarefa = new DialogTarefaAtualizcaoItens(entidade);

            DialogResult opcaoEscolhida = telaAtualizacaoItensTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                List<ItemTarefa> itensMarcados = telaAtualizacaoItensTarefa.ObterItensMarcados();
                itensMarcados.ForEach(i => entidade.ConcluirItem(i));
                List<ItemTarefa> itensPendentes = telaAtualizacaoItensTarefa.ObterItensPendentes();
                itensPendentes.ForEach(i => entidade.RecomecarProgresso(i));

                CarregarTarefas();
            }
        }

        private void CarregarTarefas()
        {
            List<EntidadeTarefa> entidades = RepositorioTarefa.SelecionarTodosOrdenadosPorPrioridade();

            TabelaTarefas.AtualizarRegistros(entidades);
        }

        private void CarregarTarefas(List<EntidadeTarefa> entidades)
        {
            TabelaTarefas.AtualizarRegistros(entidades);
        }

        public override UserControl ObterListagem()
        {
            TabelaTarefas ??= new TabelaTarefaControl(RepositorioTarefa.SelecionarTodaALista());

            CarregarTarefas();

            return TabelaTarefas;
        }
    }
}
