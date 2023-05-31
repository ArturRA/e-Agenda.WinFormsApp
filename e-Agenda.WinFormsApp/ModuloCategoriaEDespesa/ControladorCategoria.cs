using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public class ControladorCategoria : Controlador
    {
        private RepositorioCategoria RepositorioCategoria { get; set; }
        private TabelaCategoriaControl TabelaCategoria { get; set; }
        public override string TipoDoCadastro => "Categoria";

        public ControladorCategoria(RepositorioCategoria repositorioCategoria)
        {
            RepositorioCategoria=repositorioCategoria;
        }


        public override void Inserir()
        {
            DialogCategoria dialog = new DialogCategoria();

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeCategoria entidade = dialog.Categoria;

                RepositorioCategoria.Inserir(entidade);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            EntidadeCategoria? entidade = TabelaCategoria.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogCategoria dialog = new DialogCategoria();
            dialog.Categoria = entidade;

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioCategoria.Editar(dialog.Categoria);

                CarregarEntidades();
            }
        }

        public override void Excluir()
        {
            EntidadeCategoria? entidade = TabelaCategoria.ObterEntidadeSelecionada();

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
                RepositorioCategoria.Excluir(entidade);

                CarregarEntidades();
            }
        }

        private void CarregarEntidades()
        {
            List<EntidadeCategoria> entidades = RepositorioCategoria.SelecionarTodaALista();

            TabelaCategoria.AtualizarRegistros(entidades);
        }

        public override UserControl ObterListagem()
        {
            TabelaCategoria ??= new TabelaCategoriaControl(RepositorioCategoria.SelecionarTodaALista());

            CarregarEntidades();

            return TabelaCategoria;
        }
    }
}
