using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public class ControladorDespesa : Controlador
    {
        private RepositorioDespesa RepositorioDespesa { get; set; }
        private RepositorioCategoria RepositorioCategoria { get; set; }
        private TabelaDespesaControl TabelaDespesas { get; set; }
        public override string TipoDoCadastro => "Despesa";

        public ControladorDespesa(RepositorioDespesa repositorioDespesa, RepositorioCategoria repositorioCategoria)
        {
            RepositorioDespesa=repositorioDespesa;
            RepositorioCategoria=repositorioCategoria;
        }

        public override void Inserir()
        {
            DialogDespesa dialog = new DialogDespesa();
            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeDespesa entidade = dialog.Despesa;

                RepositorioDespesa.Inserir(entidade);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            EntidadeDespesa? entidade = TabelaDespesas.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogDespesa dialog = new DialogDespesa();
            dialog.Despesa = entidade;

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioDespesa.Editar(dialog.Despesa);

                CarregarEntidades();
            }
        }

        public override void Excluir()
        {
            EntidadeDespesa? entidade = TabelaDespesas.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Exclusão de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {entidade.Descricao}?",
                                                          $"Exclusão de {TipoDoCadastro}s",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioDespesa.Excluir(entidade);

                CarregarEntidades();
            }
        }

        //public override void Filtrar()
        //{
        //    DialogTarefaFiltro dialog = new DialogTarefaFiltro();

        //    DialogResult opcaoEscolhida = dialog.ShowDialog();

        //    if (opcaoEscolhida == DialogResult.OK)
        //    {
        //        TipoDoFiltroTarefa TipoFiltro = dialog.TipoFiltroTarefa;
        //        List<EntidadeDespesa>? entidades = null;

        //        switch (TipoFiltro)
        //        {
        //            case TipoDoFiltroTarefa.Pendentes:
        //                entidades = RepositorioTarefa.SelecionarPendentes();
        //                break;
        //            case TipoDoFiltroTarefa.Concluidas:
        //                entidades = RepositorioTarefa.SelecionarConcluidas();
        //                break;
        //            default:
        //                entidades = RepositorioTarefa.SelecionarTodosOrdenadosPorPrioridade();
        //                break;
        //        }

        //        CarregarTarefas(entidades!);

        //        TelaPrincipalForm.Instancia.AtualizarToolStrip($"Visualizando {entidades!.Count} compromissos");
        //    }
        //}

        //public override void AdicionarItens()
        //{
        //    EntidadeDespesa entidade = TabelaTarefas.ObterTarefaSelecionada();

        //    if (entidade == null)
        //    {
        //        MessageBox.Show("Selecione uma tarefa primeiro", "Adição de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //        return;
        //    }

        //    DialogTarefaCadastroItens telaCadastroItensTarefa = new DialogTarefaCadastroItens(entidade);

        //    DialogResult opcaoEscolhida = telaCadastroItensTarefa.ShowDialog();

        //    if (opcaoEscolhida == DialogResult.OK)
        //    {
        //        List<ItemTarefa> listaDeItensAtualizados = telaCadastroItensTarefa.ObterItensCadastrados();
        //        listaDeItensAtualizados.ForEach(i => entidade.AdicionarItem(i));
        //        CarregarTarefas();
        //    }
        //}

        //public override void ConcluirItens()
        //{
        //    EntidadeDespesa entidade = TabelaTarefas.ObterTarefaSelecionada();

        //    if (entidade == null)
        //    {
        //        MessageBox.Show("Selecione uma tarefa primeiro", "Atualização de Itens da Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //        return;
        //    }

        //    DialogTarefaAtualizcaoItens telaAtualizacaoItensTarefa = new DialogTarefaAtualizcaoItens(entidade);

        //    DialogResult opcaoEscolhida = telaAtualizacaoItensTarefa.ShowDialog();

        //    if (opcaoEscolhida == DialogResult.OK)
        //    {
        //        List<ItemTarefa> itensMarcados = telaAtualizacaoItensTarefa.ObterItensMarcados();
        //        itensMarcados.ForEach(i => entidade.ConcluirItem(i));
        //        List<ItemTarefa> itensPendentes = telaAtualizacaoItensTarefa.ObterItensPendentes();
        //        itensPendentes.ForEach(i => entidade.RecomecarProgresso(i));

        //        CarregarTarefas();
        //    }
        //}

        private void CarregarEntidades()
        {
            List<EntidadeDespesa> entidades = RepositorioDespesa.SelecionarTodaALista();

            TabelaDespesas.AtualizarRegistros(entidades);
        }

        private void CarregarEntidades(List<EntidadeDespesa> entidades)
        {
            TabelaDespesas.AtualizarRegistros(entidades);
        }

        public override UserControl ObterListagem()
        {
            TabelaDespesas ??= new TabelaDespesaControl(RepositorioDespesa.SelecionarTodaALista());

            CarregarEntidades();

            return TabelaDespesas;
        }
    }
}
