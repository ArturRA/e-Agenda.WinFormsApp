using e_Agenda.WinFormsApp.Properties;

namespace e_Agenda.WinFormsApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1=new MenuStrip();
            cadastrosMenuItem=new ToolStripMenuItem();
            compromissosMenuItem=new ToolStripMenuItem();
            contatosMenuItem=new ToolStripMenuItem();
            tarefasMenuItem=new ToolStripMenuItem();
            despesasToolStripMenuItem=new ToolStripMenuItem();
            despesasMenuItem=new ToolStripMenuItem();
            categoriasMenuItem=new ToolStripMenuItem();
            relatóriosToolStripMenuItem=new ToolStripMenuItem();
            statusStrip1=new StatusStrip();
            statusLabelTelaPrincipal=new ToolStripStatusLabel();
            toolStrip1=new ToolStrip();
            btnInserir=new ToolStripButton();
            btnEditar=new ToolStripButton();
            btnExcluir=new ToolStripButton();
            toolStripSeparator2=new ToolStripSeparator();
            btnFiltrar=new ToolStripButton();
            toolStripSeparator1=new ToolStripSeparator();
            btnAdicionarItens=new ToolStripButton();
            btnConcluirItens=new ToolStripButton();
            toolStripSeparator3=new ToolStripSeparator();
            labelTipoCadastro=new ToolStripLabel();
            panelRegistros=new Panel();
            btnListarDespesas=new ToolStripButton();
            toolStripSeparator4=new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(1098, 24);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { compromissosMenuItem, contatosMenuItem, tarefasMenuItem, despesasToolStripMenuItem });
            cadastrosMenuItem.Name="cadastrosMenuItem";
            cadastrosMenuItem.Size=new Size(71, 20);
            cadastrosMenuItem.Text="Cadastros";
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Name="compromissosMenuItem";
            compromissosMenuItem.Size=new Size(154, 22);
            compromissosMenuItem.Text="Compromissos";
            compromissosMenuItem.Click+=compromissosMenuItem_Click;
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name="contatosMenuItem";
            contatosMenuItem.Size=new Size(154, 22);
            contatosMenuItem.Text="Contatos";
            contatosMenuItem.Click+=contatosMenuItem_Click;
            // 
            // tarefasMenuItem
            // 
            tarefasMenuItem.Name="tarefasMenuItem";
            tarefasMenuItem.Size=new Size(154, 22);
            tarefasMenuItem.Text="Tarefas";
            tarefasMenuItem.Click+=tarefasMenuItem_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despesasMenuItem, categoriasMenuItem });
            despesasToolStripMenuItem.Name="despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size=new Size(154, 22);
            despesasToolStripMenuItem.Text="Despesas";
            // 
            // despesasMenuItem
            // 
            despesasMenuItem.Name="despesasMenuItem";
            despesasMenuItem.Size=new Size(130, 22);
            despesasMenuItem.Text="Despesas";
            despesasMenuItem.Click+=despesasMenuItem_Click;
            // 
            // categoriasMenuItem
            // 
            categoriasMenuItem.Name="categoriasMenuItem";
            categoriasMenuItem.Size=new Size(130, 22);
            categoriasMenuItem.Text="Categorias";
            categoriasMenuItem.Click+=categoriasMenuItem_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name="relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size=new Size(71, 20);
            relatóriosToolStripMenuItem.Text="Relatórios";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelTelaPrincipal });
            statusStrip1.Location=new Point(0, 539);
            statusStrip1.Name="statusStrip1";
            statusStrip1.Size=new Size(1098, 22);
            statusStrip1.TabIndex=1;
            statusStrip1.Text="statusStrip1";
            // 
            // statusLabelTelaPrincipal
            // 
            statusLabelTelaPrincipal.Name="statusLabelTelaPrincipal";
            statusLabelTelaPrincipal.Size=new Size(0, 17);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator2, btnFiltrar, toolStripSeparator1, btnAdicionarItens, btnConcluirItens, toolStripSeparator4, btnListarDespesas, toolStripSeparator3, labelTipoCadastro });
            toolStrip1.Location=new Point(0, 24);
            toolStrip1.Name="toolStrip1";
            toolStrip1.Size=new Size(1098, 45);
            toolStrip1.TabIndex=2;
            toolStrip1.Text="toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled=false;
            btnInserir.Image=Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btnInserir.ImageScaling=ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor=Color.Magenta;
            btnInserir.Name="btnInserir";
            btnInserir.Padding=new Padding(7);
            btnInserir.Size=new Size(42, 42);
            btnInserir.Click+=btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled=false;
            btnEditar.Image=Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEditar.ImageScaling=ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor=Color.Magenta;
            btnEditar.Name="btnEditar";
            btnEditar.Padding=new Padding(7);
            btnEditar.Size=new Size(42, 42);
            btnEditar.Click+=btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled=false;
            btnExcluir.Image=Resources.delete_FILL0_wght400_GRAD0_opsz24;
            btnExcluir.ImageScaling=ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor=Color.Magenta;
            btnExcluir.Name="btnExcluir";
            btnExcluir.Padding=new Padding(7);
            btnExcluir.Size=new Size(42, 42);
            btnExcluir.Click+=btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name="toolStripSeparator2";
            toolStripSeparator2.Size=new Size(6, 45);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnFiltrar.Enabled=false;
            btnFiltrar.Image=Resources.filter_list_FILL0_wght400_GRAD0_opsz24;
            btnFiltrar.ImageScaling=ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor=Color.Magenta;
            btnFiltrar.Name="btnFiltrar";
            btnFiltrar.Padding=new Padding(7);
            btnFiltrar.Size=new Size(42, 42);
            btnFiltrar.Click+=btnFiltrar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name="toolStripSeparator1";
            toolStripSeparator1.Size=new Size(6, 45);
            // 
            // btnAdicionarItens
            // 
            btnAdicionarItens.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnAdicionarItens.Enabled=false;
            btnAdicionarItens.Image=Resources.library_add_FILL0_wght400_GRAD0_opsz24;
            btnAdicionarItens.ImageScaling=ToolStripItemImageScaling.None;
            btnAdicionarItens.ImageTransparentColor=Color.Magenta;
            btnAdicionarItens.Name="btnAdicionarItens";
            btnAdicionarItens.Padding=new Padding(7);
            btnAdicionarItens.Size=new Size(42, 42);
            btnAdicionarItens.Click+=btnAdicionarItens_Click;
            // 
            // btnConcluirItens
            // 
            btnConcluirItens.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnConcluirItens.Enabled=false;
            btnConcluirItens.Image=Resources.check_box_FILL0_wght400_GRAD0_opsz24;
            btnConcluirItens.ImageScaling=ToolStripItemImageScaling.None;
            btnConcluirItens.ImageTransparentColor=Color.Magenta;
            btnConcluirItens.Name="btnConcluirItens";
            btnConcluirItens.Padding=new Padding(7);
            btnConcluirItens.Size=new Size(42, 42);
            btnConcluirItens.Click+=btnConcluirItens_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name="toolStripSeparator3";
            toolStripSeparator3.Size=new Size(6, 45);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Name="labelTipoCadastro";
            labelTipoCadastro.Size=new Size(75, 42);
            labelTipoCadastro.Text="tipoCadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle=BorderStyle.FixedSingle;
            panelRegistros.Dock=DockStyle.Fill;
            panelRegistros.Location=new Point(0, 69);
            panelRegistros.Name="panelRegistros";
            panelRegistros.Size=new Size(1098, 470);
            panelRegistros.TabIndex=3;
            // 
            // btnListarDespesas
            // 
            btnListarDespesas.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnListarDespesas.Enabled=false;
            btnListarDespesas.Image=Resources.list_FILL0_wght400_GRAD0_opsz24;
            btnListarDespesas.ImageScaling=ToolStripItemImageScaling.None;
            btnListarDespesas.ImageTransparentColor=Color.Magenta;
            btnListarDespesas.Name="btnListarDespesas";
            btnListarDespesas.Padding=new Padding(7);
            btnListarDespesas.Size=new Size(42, 42);
            btnListarDespesas.Click+=btnListarDespesas_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name="toolStripSeparator4";
            toolStripSeparator4.Size=new Size(6, 45);
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1098, 561);
            Controls.Add(panelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="TelaPrincipalForm";
            ShowIcon=false;
            StartPosition=FormStartPosition.CenterScreen;
            Text="e-Agenda 1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem despesasMenuItem;
        private ToolStripMenuItem categoriasMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelTelaPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel panelRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel labelTipoCadastro;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnAdicionarItens;
        private ToolStripButton btnConcluirItens;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton btnListarDespesas;
    }
}