using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public class ControladorDespesa : Controlador
    {
        private IRepositorioDespesa RepositorioDespesa { get; set; }
        private IRepositorioCategoria RepositorioCategoria { get; set; }
        private TabelaDespesaControl TabelaDespesas { get; set; }
        public override string TipoDoCadastro => "Despesa";

        public ControladorDespesa(IRepositorioDespesa repositorioDespesa, IRepositorioCategoria repositorioCategoria)
        {
            RepositorioDespesa=repositorioDespesa;
            RepositorioCategoria=repositorioCategoria;
        }

        public override void Inserir()
        {
            DialogDespesa dialog = new DialogDespesa(RepositorioCategoria.SelecionarTodos());
            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeDespesa entidade = dialog.Despesa;
                List<EntidadeCategoria> itensChecked = dialog.ObterItensMarcados();
                itensChecked.ForEach(i =>
                {
                    i.AdicionarDespesa(entidade);
                    entidade.AdicionarCategoria(i);
                });
                List<EntidadeCategoria> itensUnChecked = dialog.ObterItensPendentes();
                itensUnChecked.ForEach(i =>
                {
                    i.RemoverDespesa(entidade);
                    entidade.RemoverCategoria(i);
                });
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

            DialogDespesa dialog = new DialogDespesa(RepositorioCategoria.SelecionarTodos());
            dialog.Despesa = entidade;

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                entidade = dialog.Despesa;
                List<EntidadeCategoria> itensChecked = dialog.ObterItensMarcados();
                itensChecked.ForEach(categoria =>
                {
                    categoria.AdicionarDespesa(entidade);
                    entidade.AdicionarCategoria(categoria);
                });
                List<EntidadeCategoria> itensUnChecked = dialog.ObterItensPendentes();
                itensUnChecked.ForEach(categoria =>
                {
                    categoria.RemoverDespesa(entidade);
                    entidade.RemoverCategoria(categoria);
                });

                RepositorioDespesa.Editar(entidade);

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
                entidade.Categorias.ForEach(c => c.RemoverDespesa(entidade));

                RepositorioDespesa.Excluir(entidade);

                CarregarEntidades();
            }
        }

        private void CarregarEntidades()
        {
            List<EntidadeDespesa> entidades = RepositorioDespesa.SelecionarTodos();

            TabelaDespesas.AtualizarRegistros(entidades);
        }

        public override UserControl ObterListagem()
        {
            TabelaDespesas ??= new TabelaDespesaControl(RepositorioDespesa.SelecionarTodos());

            CarregarEntidades();

            return TabelaDespesas;
        }
    }
}
