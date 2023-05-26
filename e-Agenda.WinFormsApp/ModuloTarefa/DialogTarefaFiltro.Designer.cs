namespace e_Agenda.WinFormsApp.ModuloTarefa
{
    partial class DialogTarefaFiltro
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
            btnFiltrar=new Button();
            btnCancelar=new Button();
            rdbTodos=new RadioButton();
            rdbPendentes=new RadioButton();
            rdbConcluidas=new RadioButton();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult=DialogResult.OK;
            btnFiltrar.Location=new Point(27, 87);
            btnFiltrar.Name="btnFiltrar";
            btnFiltrar.Size=new Size(75, 50);
            btnFiltrar.TabIndex=6;
            btnFiltrar.Text="Filtrar";
            btnFiltrar.UseVisualStyleBackColor=true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult=DialogResult.Cancel;
            btnCancelar.Location=new Point(108, 87);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(75, 50);
            btnCancelar.TabIndex=7;
            btnCancelar.Text="Cancelar";
            btnCancelar.UseVisualStyleBackColor=true;
            // 
            // rdbTodos
            // 
            rdbTodos.AutoSize=true;
            rdbTodos.Location=new Point(12, 12);
            rdbTodos.Name="rdbTodos";
            rdbTodos.Size=new Size(160, 19);
            rdbTodos.TabIndex=1;
            rdbTodos.TabStop=true;
            rdbTodos.Tag="0";
            rdbTodos.Text="Visualizar Todas as Tarefas";
            rdbTodos.UseVisualStyleBackColor=true;
            // 
            // rdbPendentes
            // 
            rdbPendentes.AutoSize=true;
            rdbPendentes.Location=new Point(12, 37);
            rdbPendentes.Name="rdbPendentes";
            rdbPendentes.Size=new Size(171, 19);
            rdbPendentes.TabIndex=2;
            rdbPendentes.TabStop=true;
            rdbPendentes.Tag="1";
            rdbPendentes.Text="Visualizar Tarefas Pendentes";
            rdbPendentes.UseVisualStyleBackColor=true;
            // 
            // rdbConcluidas
            // 
            rdbConcluidas.AutoSize=true;
            rdbConcluidas.Location=new Point(12, 62);
            rdbConcluidas.Name="rdbConcluidas";
            rdbConcluidas.Size=new Size(175, 19);
            rdbConcluidas.TabIndex=3;
            rdbConcluidas.TabStop=true;
            rdbConcluidas.Tag="2";
            rdbConcluidas.Text="Visualizar Tarefas Concluídas";
            rdbConcluidas.UseVisualStyleBackColor=true;
            // 
            // DialogTarefaFiltro
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            ClientSize=new Size(205, 156);
            Controls.Add(rdbConcluidas);
            Controls.Add(rdbTodos);
            Controls.Add(rdbPendentes);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="DialogTarefaFiltro";
            ShowIcon=false;
            ShowInTaskbar=false;
            StartPosition=FormStartPosition.CenterScreen;
            Text="Filtro de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
        private Button btnCancelar;
        private RadioButton rdbTodos;
        private RadioButton rdbPendentes;
        private RadioButton rdbConcluidas;
    }
}