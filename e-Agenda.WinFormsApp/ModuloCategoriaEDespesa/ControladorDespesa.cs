using e_Agenda.WinFormsApp.Compartilhado;
using e_Agenda.WinFormsApp.ModuloTarefa;

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
            DialogDespesa dialog = new DialogDespesa(RepositorioCategoria.SelecionarTodaALista());
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

            DialogDespesa dialog = new DialogDespesa(RepositorioCategoria.SelecionarTodaALista());
            dialog.Despesa = entidade;

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                entidade = dialog.Despesa;
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
                RepositorioDespesa.Excluir(entidade);

                CarregarEntidades();
            }
        }

        private void CarregarEntidades()
        {
            List<EntidadeDespesa> entidades = RepositorioDespesa.SelecionarTodaALista();

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
