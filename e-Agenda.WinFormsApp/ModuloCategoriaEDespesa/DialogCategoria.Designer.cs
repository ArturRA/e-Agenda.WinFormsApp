namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    partial class DialogCategoria
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
            label2=new Label();
            txtDescricao=new TextBox();
            labelId=new Label();
            btnGravar=new Button();
            btnCancelar=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(50, 9);
            label1.Name="label1";
            label1.Size=new Size(20, 15);
            label1.TabIndex=0;
            label1.Text="Id:";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(12, 45);
            label2.Name="label2";
            label2.Size=new Size(58, 15);
            label2.TabIndex=2;
            label2.Text="Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location=new Point(76, 42);
            txtDescricao.Name="txtDescricao";
            txtDescricao.Size=new Size(241, 23);
            txtDescricao.TabIndex=3;
            // 
            // labelId
            // 
            labelId.AutoSize=true;
            labelId.Enabled=false;
            labelId.Location=new Point(76, 9);
            labelId.Name="labelId";
            labelId.Size=new Size(13, 15);
            labelId.TabIndex=4;
            labelId.Text="0";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult=DialogResult.OK;
            btnGravar.Location=new Point(161, 71);
            btnGravar.Name="btnGravar";
            btnGravar.Size=new Size(75, 41);
            btnGravar.TabIndex=5;
            btnGravar.Text="Gravar";
            btnGravar.UseVisualStyleBackColor=true;
            btnGravar.Click+=btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult=DialogResult.Cancel;
            btnCancelar.Location=new Point(242, 71);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(75, 41);
            btnCancelar.TabIndex=6;
            btnCancelar.Text="Cancelar";
            btnCancelar.UseVisualStyleBackColor=true;
            // 
            // DialogCategoria
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(333, 133);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(labelId);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="DialogCategoria";
            Text="DialogCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDescricao;
        private Label labelId;
        private Button btnGravar;
        private Button btnCancelar;
    }
}