namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    partial class DialogDespesasDeCategoria
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
            label1=new Label();
            labelCategoria=new Label();
            label3=new Label();
            panelDespesas=new Panel();
            btnCancelar=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(61, 15);
            label1.TabIndex=0;
            label1.Text="Categoria:";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize=true;
            labelCategoria.Location=new Point(79, 9);
            labelCategoria.Name="labelCategoria";
            labelCategoria.Size=new Size(100, 15);
            labelCategoria.TabIndex=1;
            labelCategoria.Text="dummyCategoria";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(18, 37);
            label3.Name="label3";
            label3.Size=new Size(55, 15);
            label3.TabIndex=2;
            label3.Text="Despesas";
            // 
            // panelDespesas
            // 
            panelDespesas.Location=new Point(12, 55);
            panelDespesas.Name="panelDespesas";
            panelDespesas.Size=new Size(776, 305);
            panelDespesas.TabIndex=3;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            btnCancelar.DialogResult=DialogResult.Cancel;
            btnCancelar.Location=new Point(713, 366);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(75, 41);
            btnCancelar.TabIndex=16;
            btnCancelar.Text="Fechar";
            btnCancelar.UseVisualStyleBackColor=true;
            // 
            // DialogDespesasDeCategoria
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 419);
            Controls.Add(btnCancelar);
            Controls.Add(panelDespesas);
            Controls.Add(label3);
            Controls.Add(labelCategoria);
            Controls.Add(label1);
            Name="DialogDespesasDeCategoria";
            Text="DialogDespesasDeCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelCategoria;
        private Label label3;
        private Panel panelDespesas;
        private Button btnCancelar;
    }
}