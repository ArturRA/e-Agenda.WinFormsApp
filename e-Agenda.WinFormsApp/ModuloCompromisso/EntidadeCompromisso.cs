using e_Agenda.WinFormsApp.Compartilhado;
using e_Agenda.WinFormsApp.ModuloContato;

namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    public enum TipoDaLocalizacao
    {
        Invalido = -1,
        Presencial = 0,
        Remoto = 1
    }
    public class EntidadeCompromisso : Entidade<EntidadeCompromisso>
    {
        
        public string Assunto { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioFim { get; set;}
        public bool TemContato { get; set; }
        public EntidadeContato? Contato { get; set; }
        public TipoDaLocalizacao TipoDoLocal { get; set; }
        public string Locao { get; set; }

        public EntidadeCompromisso()
        {
        }

        public EntidadeCompromisso(string assunto, DateTime data, TimeSpan horarioInicio, TimeSpan horarioFim, bool temContato,
                                   EntidadeContato? contato, TipoDaLocalizacao tipoDoLocal, string locao)
        {
            Assunto=assunto;
            Data=data;
            HorarioInicio=horarioInicio;
            HorarioFim=horarioFim;
            TemContato=temContato;
            Contato=contato;
            TipoDoLocal=tipoDoLocal;
            Locao=locao;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Assunto))
                erros.Add("Digite um Assunto valido");
            if (TipoDoLocal == TipoDaLocalizacao.Invalido)
                erros.Add("Selecione um tipo de Localização");
            if (string.IsNullOrWhiteSpace(Locao))
                erros.Add("Digite um Local do Compromisso valido");

            return erros;
        }
    }
}
