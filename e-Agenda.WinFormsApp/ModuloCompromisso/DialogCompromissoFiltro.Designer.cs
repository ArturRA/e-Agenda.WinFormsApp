namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    partial class DialogCompromissoFiltro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4=new Label();
            label5=new Label();
            rdbPassados=new RadioButton();
            rdbTodos=new RadioButton();
            panelLocalizacao=new Panel();
            dtpDataInicial=new DateTimePicker();
            dtpDataFinal=new DateTimePicker();
            btnFiltrar=new Button();
            btnCancelar=new Button();
            rdbFuturos=new RadioButton();
            label1=new Label();
            panelLocalizacao.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(3, 24);
            label4.Name="label4";
            label4.Size=new Size(68, 15);
            label4.TabIndex=10;
            label4.Text="Data inicial:";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(185, 24);
            label5.Name="label5";
            label5.Size=new Size(60, 15);
            label5.TabIndex=12;
            label5.Text="Data final:";
            // 
            // rdbPassados
            // 
            rdbPassados.AutoSize=true;
            rdbPassados.Location=new Point(10, 37);
            rdbPassados.Name="rdbPassados";
            rdbPassados.Size=new Size(257, 19);
            rdbPassados.TabIndex=2;
            rdbPassados.TabStop=true;
            rdbPassados.Tag="1";
            rdbPassados.Text="Visualizar somente Compromissos passados";
            rdbPassados.UseVisualStyleBackColor=true;
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize=true;
            rdbTodos.Location=new Point(12, 12);
            rdbTodos.Name="rdbTodos";
            rdbTodos.Size=new Size(205, 19);
            rdbTodos.TabIndex=1;
            rdbTodos.TabStop=true;
            rdbTodos.Tag="0";
            rdbTodos.Text="Visualizar todos os Compromissos";
            rdbTodos.UseVisualStyleBackColor=true;
            // 
            // panelLocalizacao
            // 
            panelLocalizacao.Controls.Add(label4);
            panelLocalizacao.Controls.Add(dtpDataInicial);
            panelLocalizacao.Controls.Add(dtpDataFinal);
            panelLocalizacao.Controls.Add(label5);
            panelLocalizacao.Location=new Point(12, 127);
            panelLocalizacao.Name="panelLocalizacao";
            panelLocalizacao.Size=new Size(361, 62);
            panelLocalizacao.TabIndex=20;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.CustomFormat="dd/MM/yyyy";
            dtpDataInicial.Format=DateTimePickerFormat.Custom;
            dtpDataInicial.Location=new Point(77, 18);
            dtpDataInicial.Name="dtpDataInicial";
            dtpDataInicial.Size=new Size(100, 23);
            dtpDataInicial.TabIndex=9;
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.CustomFormat="dd/MM/yyyy";
            dtpDataFinal.Format=DateTimePickerFormat.Custom;
            dtpDataFinal.Location=new Point(251, 18);
            dtpDataFinal.Name="dtpDataFinal";
            dtpDataFinal.Size=new Size(100, 23);
            dtpDataFinal.TabIndex=23;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult=DialogResult.OK;
            btnFiltrar.Location=new Point(217, 195);
            btnFiltrar.Name="btnFiltrar";
            btnFiltrar.Size=new Size(75, 41);
            btnFiltrar.TabIndex=21;
            btnFiltrar.Text="Filtrar";
            btnFiltrar.UseVisualStyleBackColor=true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult=DialogResult.Cancel;
            btnCancelar.Location=new Point(298, 195);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(75, 41);
            btnCancelar.TabIndex=22;
            btnCancelar.Text="Cancelar";
            btnCancelar.UseVisualStyleBackColor=true;
            // 
            // rdbFuturos
            // 
            rdbFuturos.AutoSize=true;
            rdbFuturos.Location=new Point(10, 62);
            rdbFuturos.Name="rdbFuturos";
            rdbFuturos.Size=new Size(247, 19);
            rdbFuturos.TabIndex=3;
            rdbFuturos.TabStop=true;
            rdbFuturos.Tag="2";
            rdbFuturos.Text="Visualizar somente Compromissos futuros";
            rdbFuturos.UseVisualStyleBackColor=true;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 109);
            label1.Name="label1";
            label1.Size=new Size(184, 15);
            label1.TabIndex=25;
            label1.Text="Filtro para Compromissos futuros";
            // 
            // DialogCompromissoFiltro
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(383, 248);
            Controls.Add(label1);
            Controls.Add(rdbFuturos);
            Controls.Add(rdbPassados);
            Controls.Add(rdbTodos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Controls.Add(panelLocalizacao);
            FormBorderStyle=FormBorderStyle.FixedDialog;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="DialogCompromissoFiltro";
            ShowIcon=false;
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cadastro de Compromissos";
            panelLocalizacao.ResumeLayout(false);
            panelLocalizacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private RadioButton rdbPassados;
        private RadioButton rdbTodos;
        private Panel panelLocalizacao;
        private Button btnFiltrar;
        private Button btnCancelar;
        private DateTimePicker dtpDataInicial;
        private DateTimePicker dtpDataFinal;
        private RadioButton rdbFuturos;
        private Label label1;
    }
}