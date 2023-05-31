namespace e_Agenda.WinFormsApp.ModuloCategoriaEDespesa
{
    partial class DialogDespesa
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
            label3=new Label();
            txtDescricao=new TextBox();
            label4=new Label();
            txtValor=new TextBox();
            label5=new Label();
            dtpData=new DateTimePicker();
            label6=new Label();
            cmbFormaDePagamento=new ComboBox();
            groupBox1=new GroupBox();
            clbCategorias=new CheckedListBox();
            btnGravar=new Button();
            btnCancelar=new Button();
            labelId=new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(113, 9);
            label1.Name="label1";
            label1.Size=new Size(20, 15);
            label1.TabIndex=0;
            label1.Text="Id:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(75, 41);
            label3.Name="label3";
            label3.Size=new Size(58, 15);
            label3.TabIndex=2;
            label3.Text="Descricao";
            // 
            // txtDescricao
            // 
            txtDescricao.Location=new Point(139, 38);
            txtDescricao.Name="txtDescricao";
            txtDescricao.Size=new Size(100, 23);
            txtDescricao.TabIndex=3;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(97, 91);
            label4.Name="label4";
            label4.Size=new Size(36, 15);
            label4.TabIndex=4;
            label4.Text="Valor:";
            // 
            // txtValor
            // 
            txtValor.Location=new Point(139, 83);
            txtValor.Name="txtValor";
            txtValor.Size=new Size(100, 23);
            txtValor.TabIndex=5;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(102, 140);
            label5.Name="label5";
            label5.Size=new Size(31, 15);
            label5.TabIndex=6;
            label5.Text="Data";
            // 
            // dtpData
            // 
            dtpData.Format=DateTimePickerFormat.Short;
            dtpData.Location=new Point(139, 134);
            dtpData.Name="dtpData";
            dtpData.Size=new Size(96, 23);
            dtpData.TabIndex=7;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(12, 184);
            label6.Name="label6";
            label6.Size=new Size(121, 15);
            label6.TabIndex=8;
            label6.Text="Forma de pagamento";
            // 
            // cmbFormaDePagamento
            // 
            cmbFormaDePagamento.DropDownStyle=ComboBoxStyle.DropDownList;
            cmbFormaDePagamento.FormattingEnabled=true;
            cmbFormaDePagamento.Location=new Point(139, 176);
            cmbFormaDePagamento.Name="cmbFormaDePagamento";
            cmbFormaDePagamento.Size=new Size(121, 23);
            cmbFormaDePagamento.TabIndex=9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clbCategorias);
            groupBox1.Location=new Point(12, 205);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(274, 154);
            groupBox1.TabIndex=10;
            groupBox1.TabStop=false;
            groupBox1.Text="Categorias";
            // 
            // clbCategorias
            // 
            clbCategorias.Dock=DockStyle.Fill;
            clbCategorias.FormattingEnabled=true;
            clbCategorias.Location=new Point(3, 19);
            clbCategorias.Name="clbCategorias";
            clbCategorias.Size=new Size(268, 132);
            clbCategorias.TabIndex=0;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult=DialogResult.OK;
            btnGravar.Location=new Point(130, 365);
            btnGravar.Name="btnGravar";
            btnGravar.Size=new Size(75, 41);
            btnGravar.TabIndex=11;
            btnGravar.Text="Gravar";
            btnGravar.UseVisualStyleBackColor=true;
            btnGravar.Click+=btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult=DialogResult.Cancel;
            btnCancelar.Location=new Point(211, 365);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(75, 41);
            btnCancelar.TabIndex=12;
            btnCancelar.Text="Cancelar";
            btnCancelar.UseVisualStyleBackColor=true;
            // 
            // labelId
            // 
            labelId.AutoSize=true;
            labelId.Location=new Point(139, 9);
            labelId.Name="labelId";
            labelId.Size=new Size(13, 15);
            labelId.TabIndex=13;
            labelId.Text="0";
            // 
            // DialogDespesa
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(311, 431);
            Controls.Add(labelId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(cmbFormaDePagamento);
            Controls.Add(label6);
            Controls.Add(dtpData);
            Controls.Add(label5);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(txtDescricao);
            Controls.Add(label3);
            Controls.Add(label1);
            Name="DialogDespesa";
            Text="DialogDespesa";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtDescricao;
        private Label label4;
        private TextBox txtValor;
        private Label label5;
        private DateTimePicker dtpData;
        private Label label6;
        private ComboBox cmbFormaDePagamento;
        private GroupBox groupBox1;
        private CheckedListBox clbCategorias;
        private Button btnGravar;
        private Button btnCancelar;
        private Label labelId;
    }
}