namespace e_Agenda.Dominio.ModuloCategoriaEDespesa
{
    public enum FormaDePagamento
    {
        Dinheiro,
        Debito,
        Credito
    }

    public class EntidadeDespesa : Entidade<EntidadeDespesa>
    {
        public string Descricao { get; set; }
        public int Valor { get; set; }
        public DateTime Data { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }
        public List<EntidadeCategoria> Categorias { get; set; }

        public EntidadeDespesa()
        {
        }

        public EntidadeDespesa(string descricao, int valor, DateTime data, FormaDePagamento formaDePagamento)
        {
            Descricao=descricao;
            Valor=valor;
            Data=data;
            FormaDePagamento=formaDePagamento;
            this.Categorias= new List<EntidadeCategoria>();
        }

        public void AdicionarCategoria(EntidadeCategoria entidade)
        {
            if (!Categorias.Any(e => e.Id == entidade.Id))
                Categorias.Add(entidade);
        }

        public void RemoverCategoria(EntidadeCategoria entidade)
        {
            if (Categorias.Any(e => e.Id == entidade.Id))
                Categorias.Remove(Categorias.Single(e => e.Id == entidade.Id));
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Descricao))
                erros.Add("Digite uma Descricao valido");
            if (string.IsNullOrWhiteSpace(Valor.ToString()))
                erros.Add("Digite um Valor valido");

            return erros;
        }
    }
}
