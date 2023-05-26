using e_Agenda.WinFormsApp.ModuloContato;
using static e_Agenda.WinFormsApp.ModuloCompromisso.EntidadeCompromisso;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public partial class DialogCompromisso : Form
    {
        private EntidadeCompromisso entidadeCompromisso;
        TipoDaLocalizacao TipoDoLocao { get; set; } = TipoDaLocalizacao.Invalido;

        public DialogCompromisso(List<EntidadeContato> listaDeContatos)
        {
            InitializeComponent();
            rdbPresencial.CheckedChanged += rdbLocalizacaoChanged;
            rdbRemoto.CheckedChanged += rdbLocalizacaoChanged;

            cbContatos.DisplayMember = "Nome";
            cbContatos.ValueMember = "Id";
            cbContatos.DataSource = listaDeContatos;
        }

        private void rdbLocalizacaoChanged(object? sender, EventArgs e)
        {
            RadioButton? rdb = sender as RadioButton;
            TipoDoLocao = (TipoDaLocalizacao)Convert.ToInt32(rdb!.Tag);
        }

        public EntidadeCompromisso Compromisso
        {
            set
            {
                entidadeCompromisso = value;
                txtId.Text = entidadeCompromisso.Id.ToString();
                txtAssunto.Text = entidadeCompromisso.Assunto;
                dtpData.Value = entidadeCompromisso.DataCompromisso.Date;
                dtpHorarioInicio.Text = entidadeCompromisso.HorarioInicio.ToString("HH:mm");
                dtpHorarioFim.Text = entidadeCompromisso.HorarioFim.ToString("HH:mm");

                checkBoxMarcarContato.Checked = entidadeCompromisso.TemContatoCompromisso;
                if (checkBoxMarcarContato.Checked)
                    cbContatos.SelectedItem = entidadeCompromisso.ContatoDoCompromisso;

                switch (entidadeCompromisso.TipoDoLocal)
                {
                    case TipoDaLocalizacao.Presencial:
                        rdbPresencial.Checked = true;
                        break;
                    case TipoDaLocalizacao.Remoto:
                        rdbRemoto.Checked = true;
                        break;
                }
                txtLocalizacao.Text = entidadeCompromisso.LocaoDoCompromisso;
            }
            get
            {
                return entidadeCompromisso;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string Assunto = txtAssunto.Text;
            DateTime DataCompromisso = dtpData.Value;
            DateTime HorarioInicio = dtpHorarioInicio.Value;
            DateTime HorarioFim = dtpHorarioFim.Value;
            EntidadeContato? ContatoDoCompromisso = null;
            if (checkBoxMarcarContato.Checked)
                ContatoDoCompromisso = cbContatos.SelectedItem as EntidadeContato;

            string LocaoDoCompromisso = txtLocalizacao.Text;
            entidadeCompromisso = new EntidadeCompromisso(Assunto, DataCompromisso, HorarioInicio, HorarioFim, checkBoxMarcarContato.Checked,
                                                          ContatoDoCompromisso, TipoDoLocao, LocaoDoCompromisso);

            List<string> resultado = entidadeCompromisso.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
                DialogResult = DialogResult.None;
            }
            else
            {
                if (txtId.Text != "0")
                    entidadeCompromisso.Id = Convert.ToInt32(txtId.Text);
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }

        private void txtValidarCompromisso(object sender, EventArgs e)
        {
            string Assunto = txtAssunto.Text;
            DateTime DataCompromisso = dtpData.Value;
            DateTime HorarioInicio = dtpHorarioInicio.Value;
            DateTime HorarioFim = dtpHorarioFim.Value;
            EntidadeContato? ContatoDoCompromisso = null;
            if (checkBoxMarcarContato.Checked)
                ContatoDoCompromisso = cbContatos.SelectedItem as EntidadeContato;

            string LocaoDoCompromisso = txtLocalizacao.Text;
            EntidadeCompromisso testValidar = new EntidadeCompromisso(Assunto, DataCompromisso, HorarioInicio, HorarioFim, checkBoxMarcarContato.Checked,
                                                          ContatoDoCompromisso, TipoDoLocao, LocaoDoCompromisso);

            List<string> resultado = testValidar.Validar();
            if (resultado.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip(resultado[0]);
            }
            else
            {
                TelaPrincipalForm.Instancia.AtualizarToolStrip("");
            }
        }
    }
}
