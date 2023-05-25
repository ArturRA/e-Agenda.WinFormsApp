using e_Agenda.WinFormsApp.Compartilhado;

namespace e_Agenda.WinFormsApp.ModuloTarefa
{
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
        public enum PrioridadeTarefaEnum
        {
            Baixa,
            Normal,
            Alta
        }

        public string Titulo { get; set; }
        public PrioridadeTarefaEnum Prioridade { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<ItemTarefa> Items { get; set; }
        public decimal PercentualConcluido { get; set; }

        public EntidadeTarefa(string titulo, PrioridadeTarefaEnum prioridade, DateTime dataCriacao, List<ItemTarefa> items, decimal percentualConcluido)
        {
            Titulo=titulo;
            Prioridade=prioridade;
            DataCriacao=dataCriacao;
            Items=items;
            PercentualConcluido=percentualConcluido;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", " + Titulo + ", Prioridade: " + Prioridade;
        }

        public void AdicionarItem(ItemTarefa item)
        {
            Items.Add(item);
        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa? itemSelecionado = Items.FirstOrDefault(x => x.Equals(item));

            itemSelecionado!.Concluir();

            CalcularPercentualConcluido();
        }

        public void DesmarcarItem(ItemTarefa item)
        {
            ItemTarefa? itemSelecionado = Items.FirstOrDefault(x => x.Equals(item));

            itemSelecionado!.RecomecarProgresso();

            CalcularPercentualConcluido();
        }

        private void CalcularPercentualConcluido()
        {
            decimal qtdItens = Items.Count;

            if (qtdItens == 0)
                return;

            decimal qtdConcluidos = Items.Count(x => x.Concluido == true);

            decimal resultado = (qtdConcluidos / qtdItens) * 100;

            PercentualConcluido = Math.Round(resultado, 2);
        }
    }
}
