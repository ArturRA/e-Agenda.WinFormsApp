using e_Agenda.WinApp.ModuloContato;
using static e_Agenda.WinFormsApp.ModuloCompromisso.EntidadeCompromisso;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public partial class DialogCompromisso : Form
    {
        private EntidadeCompromisso entidadeCompromisso;
        TipoDaLocalizacao TipoDoLocao { get; set; }

        public DialogCompromisso()
        {
            InitializeComponent();
            rdbPresencial.CheckedChanged += rdbLocalizacaoChanged;
            rdbRemoto.CheckedChanged += rdbLocalizacaoChanged;
        }

        private void rdbLocalizacaoChanged(object? sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            TipoDoLocao = (TipoDaLocalizacao)Convert.ToInt32(rdb.Tag);
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
                // Contato drop down picker = Compromisso.ContatoDoCompromisso;
                switch (entidadeCompromisso.TipoDoLocao)
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
            EntidadeContato ContatoDoCompromisso = null; // TODO
            string LocaoDoCompromisso = txtLocalizacao.Text;
            entidadeCompromisso = new EntidadeCompromisso(Assunto, DataCompromisso, HorarioInicio, HorarioFim, ContatoDoCompromisso, TipoDoLocao, LocaoDoCompromisso);

            if (txtId.Text != "0")
                entidadeCompromisso.Id = Convert.ToInt32(txtId.Text);
        }
    }
}
