using e_Agenda.WinFormsApp.Compartilhado;
using System.Collections.ObjectModel;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
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
        private List<EntidadeCategoria> categorias { get; set; }
        public ReadOnlyCollection<EntidadeCategoria> Categorias
        {
            get
            {
                return categorias.AsReadOnly();
            }
        }

        public EntidadeDespesa(string descricao, int valor, DateTime data, FormaDePagamento formaDePagamento)
        {
            Descricao=descricao;
            Valor=valor;
            Data=data;
            FormaDePagamento=formaDePagamento;
            this.categorias= new List<EntidadeCategoria>();
        }

        //public void AdicionarItem(ItemTarefa item)
        //{
        //    if (!itens.Contains(item))
        //        itens.Add(item);
        //}

        //public void ConcluirItem(ItemTarefa item)
        //{
        //    item.Concluir();

        //    CalcularPercentualConcluido();
        //}

        //public void RecomecarProgresso(ItemTarefa item)
        //{
        //    item.RecomecarProgresso();

        //    CalcularPercentualConcluido();
        //}

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
