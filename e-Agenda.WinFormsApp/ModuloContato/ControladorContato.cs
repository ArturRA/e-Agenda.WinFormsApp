using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloContato
{
    public class ControladorContato : Controlador
    {
        private RepositorioContato RepositorioContato { get; set; }
        private ListagemContatoControl ListagemContatoControl { get; set; }
        public override string TipoDoCadastro => "Contato";

        public ControladorContato(RepositorioContato repositorioContato)
        {
            RepositorioContato=repositorioContato;
        }


        public override void Inserir()
        {
            DialogContato telaContato = new DialogContato();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeContato contato = telaContato.Contato;

                RepositorioContato.Inserir(contato);

                CarregarContatos();
            }
        }

        public override void Editar()
        {
            EntidadeContato contato = ListagemContatoControl.ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogContato telaContato = new DialogContato();
            telaContato.Contato = contato;

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioContato.Editar(telaContato.Contato);

                CarregarContatos();
            }
        }

        public override void Excluir()
        {            
            EntidadeContato entidade = ListagemContatoControl.ObterContatoSelecionado();

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

                CarregarContatos();
            }
        }

        private void CarregarContatos()
        {
            List<EntidadeContato> contatos = RepositorioContato.SelecionarTodaALista();

            ListagemContatoControl.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            ListagemContatoControl ??= new ListagemContatoControl();

            CarregarContatos();

            return ListagemContatoControl;
        }
    }
}
