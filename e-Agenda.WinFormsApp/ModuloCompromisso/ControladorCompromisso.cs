﻿using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;
using static e_Agenda.WinFormsApp.ModuloCompromisso.DialogCompromissoFiltro;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public class ControladorCompromisso : Controlador
    {
        private IRepositorioCompromisso RepositorioCompromisso { get; set; }
        private IRepositorioContato RepositorioContato { get; set; }
        private TabelaCompromissoControl TabelaCompromissoControl { get; set; }
        public override string TipoDoCadastro => "Compromisso";
        public override string ToolTipFiltrar => $"Filtrar {TipoDoCadastro} existente";
        public override bool ToolTipEnableFiltrar => true;

        public ControladorCompromisso(IRepositorioCompromisso repositorioCompromisso, IRepositorioContato repositorioContato)
        {
            RepositorioCompromisso=repositorioCompromisso;
            RepositorioContato=repositorioContato;
        }
        
        public override void Inserir()
        {
            DialogCompromisso dialog = new DialogCompromisso(RepositorioContato.SelecionarTodos());
            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                EntidadeCompromisso entidade = dialog.Compromisso;

                RepositorioCompromisso.Inserir(entidade);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            EntidadeCompromisso? entidade = TabelaCompromissoControl.ObterEntidadeSelecionada();

            if (entidade == null)
            {
                MessageBox.Show($"Selecione um {TipoDoCadastro} primeiro!",
                                $"Edição de {TipoDoCadastro}s",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

                return;
            }

            DialogCompromisso dialog = new DialogCompromisso(RepositorioContato.SelecionarTodos());
            dialog.Compromisso = entidade;

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                RepositorioCompromisso.Editar(dialog.Compromisso);

                CarregarEntidades();
            }
        }

        public override void Excluir()
        {
            EntidadeCompromisso? entidade = TabelaCompromissoControl.ObterEntidadeSelecionada();

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

                CarregarEntidades();
            }
        }

        public override void Filtrar()
        {
            DialogCompromissoFiltro dialog = new DialogCompromissoFiltro();

            DialogResult opcaoEscolhida = dialog.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                TipoDoFiltro TipoFiltro = dialog.TipoFiltro;
                List<EntidadeCompromisso>? entidades = null;

                switch (TipoFiltro)
                {
                    case TipoDoFiltro.Todos:
                        entidades = RepositorioCompromisso.SelecionarTodos();
                        break;
                    case TipoDoFiltro.Passados:
                        entidades = RepositorioCompromisso.SelecionarCompromissosPassados();
                        break;
                    case TipoDoFiltro.Futuros:
                        entidades = RepositorioCompromisso.SelecionarCompromissosFuturos(dialog.DataInicial, dialog.DataFinal);
                        break;
                }

                CarregarCompromissos(entidades!);

                TelaPrincipalForm.Instancia.AtualizarToolStrip($"Visualizando {entidades!.Count} compromissos");
            }
        }

        private void CarregarEntidades()
        {
            List<EntidadeCompromisso> entidades = RepositorioCompromisso.SelecionarTodos();

            TabelaCompromissoControl.AtualizarRegistros(entidades);
        }

        private void CarregarCompromissos(List<EntidadeCompromisso> entidades)
        {
            TabelaCompromissoControl.AtualizarRegistros(entidades);
        }

        public override UserControl ObterListagem()
        {
            TabelaCompromissoControl ??= new TabelaCompromissoControl(RepositorioCompromisso.SelecionarTodos());

            CarregarEntidades();

            return TabelaCompromissoControl;
        }
    }
}
