using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public class EntidadeCompromisso : Entidade<EntidadeCompromisso>
    {
        public enum TipoDaLocalizacao{
            Presencial = 0,
            Remoto = 1
        }
        public string Assunto { get; set; }
        public DateTime DataCompromisso { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFim { get; set;}
        public EntidadeContato ContatoDoCompromisso { get; set; }
        public TipoDaLocalizacao TipoDoLocao { get; set; }
        public string LocaoDoCompromisso { get; set; }

        public EntidadeCompromisso(string assunto, DateTime dataCompromisso, DateTime horarioInicio, DateTime horarioFim,
                                   EntidadeContato contatoDoCompromisso, TipoDaLocalizacao tipoDoLocao, string locaoDoCompromisso)
        {
            Assunto=assunto;
            DataCompromisso=dataCompromisso;
            HorarioInicio=horarioInicio;
            HorarioFim=horarioFim;
            ContatoDoCompromisso=contatoDoCompromisso;
            TipoDoLocao=tipoDoLocao;
            LocaoDoCompromisso=locaoDoCompromisso;
        }

        public override string ToString()
        {
            return $"Assunto: {Assunto}...";
        }
    }
}
