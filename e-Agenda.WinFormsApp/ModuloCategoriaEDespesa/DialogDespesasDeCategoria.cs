using e_Agenda.WinFormsApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    public partial class DialogDespesasDeCategoria : Form
    {
        public DialogDespesasDeCategoria(string Descricao, List<EntidadeDespesa> entidades)
        {
            InitializeComponent();

            labelCategoria.Text = Descricao;

            TabelaDespesaControl TabelaDespesa = new TabelaDespesaControl(entidades);
            panelDespesas.Controls.Add(TabelaDespesa);

            TabelaDespesa.AtualizarRegistros(entidades);
        }
    }
}
