using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloContato
{
    public class ControladorContato : Controlador
    {
        private RepositorioContato RepositorioContato { get; set; }
        private TabelaContatoControl TabelaContatoControl { get; set; }
        public override string TipoDoCadastro => "Contato";

        public ControladorContato(RepositorioContato repositorioContato)
        {
            RepositorioContato=repositorioContato;
        }


        public override void Inserir()
        {
            DialogContato dialog = new DialogContato();
            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeContato entidade = dialog.Contato;

                RepositorioContato.Inserir(entidade);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            EntidadeContato? entidade = TabelaContatoControl.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogContato dialog = new DialogContato();
            dialog.Contato = entidade;

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioContato.Editar(dialog.Contato);

                CarregarEntidades();
            }
        }

        public override void Excluir()
        {            
            EntidadeContato entidade = TabelaContatoControl.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!", 
                                $"Exclusão de {TipoDoCadastro}s",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o {TipoDoCadastro} {entidade.Nome}?",
                                                          $"Exclusão de {TipoDoCadastro}s",
                                                          MessageBoxButtons.OKCancel,
                                                          MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioContato.Excluir(entidade);

                CarregarEntidades();
            }
        }

        private void CarregarEntidades()
        {
            List<EntidadeContato> contatos = RepositorioContato.SelecionarTodaALista();

            TabelaContatoControl.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            TabelaContatoControl ??= new TabelaContatoControl(RepositorioContato.SelecionarTodaALista());

            CarregarEntidades();

            return TabelaContatoControl;
        }
    }
}
