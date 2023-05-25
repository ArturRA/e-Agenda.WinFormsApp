namespace e_Agenda.WinFormsApp.Compartilhado
{
    public abstract class Entidade<TipoEntidade> where TipoEntidade : Entidade<TipoEntidade>
    {
        public int Id { get; set; }

        public void Editar(TipoEntidade entidadeComValoresAtualizados)
        {
            // Pega o tipo e para cada propriedade, que não seja o id, atualiza o valor
            typeof(TipoEntidade).GetProperties().ToList().ForEach(p =>
            {
                if (!p.Name.Equals("Id"))
                    p.SetValue(this, p.GetValue(entidadeComValoresAtualizados));
            });
        }
    }
}
