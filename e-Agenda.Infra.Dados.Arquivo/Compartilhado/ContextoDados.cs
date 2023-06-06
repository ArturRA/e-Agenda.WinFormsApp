using System.Text.Json.Serialization;
using System.Text.Json;
using e_Agenda.Dominio.ModuloCategoriaEDespesa;
using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.Infra.Dados.Arquivo.Compartilhado
{
    public class ContextoDados
    {
        private const string PATH_NOME_ARQUIVO = "Compartilhado\\e-AgendaDados.json";
        private FileInfo fileInfo = new FileInfo(PATH_NOME_ARQUIVO);
        public List<EntidadeCategoria> Categorias { get; set; }
        public List<EntidadeCompromisso> Compromissos { get; set; }
        public List<EntidadeContato> Contatos { get; set; }
        public List<EntidadeDespesa> Despesa { get; set; }
        public List<EntidadeTarefa> Tarefas { get; set; }

        public ContextoDados()
        {
            Categorias = new List<EntidadeCategoria>();
            Compromissos = new List<EntidadeCompromisso>();
            Contatos = new List<EntidadeContato>();
            Despesa = new List<EntidadeDespesa>();
            Tarefas = new List<EntidadeTarefa>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            fileInfo.Directory!.Create(); // Se o diretorio já existe este metodo não vai fazer nada(não vai precisar)
            File.WriteAllText(fileInfo.FullName, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(fileInfo.FullName))
            {
                string registrosJson = File.ReadAllText(fileInfo.FullName);

                if (registrosJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                    this.Categorias = ctx.Categorias;
                    this.Compromissos = ctx.Compromissos;
                    this.Contatos = ctx.Contatos;
                    this.Despesa = ctx.Despesa;
                    this.Tarefas = ctx.Tarefas;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
