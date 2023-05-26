using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    public enum PrioridadeTarefaEnum
    {
        Baixa,
        Normal,
        Alta
    }

    public class ItemTarefa
    {
        public string Titulo { get; set; }
        public bool Concluido { get; set; }

        public ItemTarefa(string titulo)
        {
            Titulo=titulo;
        }

        public override string ToString()
        {
            return Titulo;
        }

        public void Concluir()
        {
            Concluido=true;
        }

        public void RecomecarProgresso()
        {
            Concluido=false;
        }
    }

    public class EntidadeTarefa : Entidade<EntidadeTarefa>
    {
        public string Titulo { get; set; }
        public PrioridadeTarefaEnum Prioridade { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<ItemTarefa> Itens { get; set; }
        public decimal PercentualConcluido { get; set; }

        public EntidadeTarefa(string titulo, PrioridadeTarefaEnum prioridade, DateTime dataCriacao)
        {
            Titulo=titulo;
            Prioridade=prioridade;
            DataCriacao=dataCriacao;
            Itens = new List<ItemTarefa>();
        }

        public override string ToString()
        {
            return "Id: " + Id + ", " + Titulo + ", Prioridade: " + Prioridade;
        }

        public void AdicionarItem(ItemTarefa item)
        {
            Itens.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            //ItemTarefa? itemSelecionado = Itens.FirstOrDefault(x => x.Equals(item));

            //itemSelecionado!.Concluir();

            item!.Concluir();

            CalcularPercentualConcluido();
        }

        public void RecomecarProgresso(ItemTarefa item)
        {
            //ItemTarefa? itemSelecionado = Itens.FirstOrDefault(x => x.Equals(item));

            //itemSelecionado!.RecomecarProgresso();

            item!.RecomecarProgresso();

            CalcularPercentualConcluido();
        }

        private void CalcularPercentualConcluido()
        {
            decimal qtdItens = Itens.Count;

            if (qtdItens == 0)
                return;

            decimal qtdConcluidos = Itens.Count(x => x.Concluido == true);

            decimal resultado = (qtdConcluidos / qtdItens) * 100;

            PercentualConcluido = Math.Round(resultado, 2);
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrWhiteSpace(Titulo))
                erros.Add("Digite um Titulo valido");

            return erros;
        }
    }
}
