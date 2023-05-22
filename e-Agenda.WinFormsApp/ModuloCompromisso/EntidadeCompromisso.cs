using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Text.RegularExpressions;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public class EntidadeCompromisso : Entidade<EntidadeCompromisso>
    {
        public enum TipoDaLocalizacao{
            Invalido = -1,
            Presencial = 0,
            Remoto = 1
        }
        public string Assunto { get; set; }
        public DateTime DataCompromisso { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFim { get; set;}
        public bool TemContatoCompromisso { get; set; }
        public EntidadeContato? ContatoDoCompromisso { get; set; }
        public TipoDaLocalizacao TipoDoLocal { get; set; }
        public string LocaoDoCompromisso { get; set; }

        public EntidadeCompromisso(string assunto, DateTime dataCompromisso, DateTime horarioInicio, DateTime horarioFim, bool temContatoCompromisso,
                                   EntidadeContato? contatoDoCompromisso, TipoDaLocalizacao tipoDoLocal, string locaoDoCompromisso)
        {
            Assunto=assunto;
            DataCompromisso=dataCompromisso;
            HorarioInicio=horarioInicio;
            HorarioFim=horarioFim;
            TemContatoCompromisso=temContatoCompromisso;
            ContatoDoCompromisso=contatoDoCompromisso;
            TipoDoLocal=tipoDoLocal;
            LocaoDoCompromisso=locaoDoCompromisso;
        }

        public override string ToString()
        {
            string nomeContato = ContatoDoCompromisso != null ? ContatoDoCompromisso.Nome : "";
            return $"Assunto: {Assunto}, Contato: {nomeContato}, Data Compromisso: {DataCompromisso.Date}, Horario inínio: {HorarioInicio:HH:mm}, " +
                   $"Horario final: {HorarioFim:HH:mm}";
        }

        public List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Assunto))
                erros.Add("Digite um Assunto valido");
            if (TipoDoLocal == TipoDaLocalizacao.Invalido)
                erros.Add("Selecione um tipo de Localização");
            if (string.IsNullOrWhiteSpace(LocaoDoCompromisso))
                erros.Add("Digite um Local do Compromisso valido");

            return erros;
        }
    }
}
