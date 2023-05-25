namespace e_Agenda.WinFormsApp.ModuloCompromisso
{
    partial class DialogCompromisso
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
            components=new System.ComponentModel.Container();
            txtId=new TextBox();
            label1=new Label();
            label2=new Label();
            txtAssunto=new TextBox();
            label3=new Label();
            dtpData=new DateTimePicker();
            label4=new Label();
            dtpHorarioInicio=new DateTimePicker();
            label5=new Label();
            dtpHorarioFim=new DateTimePicker();
            checkBoxMarcarContato=new CheckBox();
            cbContatos=new ComboBox();
            entidadeContatoBindingSource=new BindingSource(components);
            label6=new Label();
            rdbRemoto=new RadioButton();
            rdbPresencial=new RadioButton();
            txtLocalizacao=new TextBox();
            panelLocalizacao=new Panel();
            btnGravar=new Button();
            btnCancelar=new Button();
            ((System.ComponentModel.ISupportInitialize)entidadeContatoBindingSource).BeginInit();
            panelLocalizacao.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location=new Point(71, 6);
            txtId.Name="txtId";
            txtId.ReadOnly=true;
            txtId.Size=new Size(100, 23);
            txtId.TabIndex=5;
            txtId.Text="0";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(45, 9);
            label1.Name="label1";
            label1.Size=new Size(20, 15);
            label1.TabIndex=4;
            label1.Text="Id:";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(12, 49);
            label2.Name="label2";
            label2.Size=new Size(53, 15);
            label2.TabIndex=6;
            label2.Text="Assunto:";
            // 
            // txtAssunto
            // 
            txtAssunto.Location=new Point(71, 46);
            txtAssunto.Name="txtAssunto";
            txtAssunto.Size=new Size(277, 23);
            txtAssunto.TabIndex=7;
            txtAssunto.TextChanged+=txtValidarCompromisso;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(31, 96);
            label3.Name="label3";
            label3.Size=new Size(34, 15);
            label3.TabIndex=8;
            label3.Text="Data:";
            // 
            // dtpData
            // 
            dtpData.CustomFormat="dd/MM/yyyy";
            dtpData.Format=DateTimePickerFormat.Custom;
            dtpData.Location=new Point(71, 90);
            dtpData.Name="dtpData";
            dtpData.Size=new Size(100, 23);
            dtpData.TabIndex=9;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(26, 146);
            label4.Name="label4";
            label4.Size=new Size(39, 15);
            label4.TabIndex=10;
            label4.Text="Início:";
            // 
            // dtpHorarioInicio
            // 
            dtpHorarioInicio.CustomFormat="HH:mm";
            dtpHorarioInicio.Format=DateTimePickerFormat.Custom;
            dtpHorarioInicio.Location=new Point(71, 140);
            dtpHorarioInicio.Name="dtpHorarioInicio";
            dtpHorarioInicio.ShowUpDown=true;
            dtpHorarioInicio.Size=new Size(100, 23);
            dtpHorarioInicio.TabIndex=11;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(192, 146);
            label5.Name="label5";
            label5.Size=new Size(30, 15);
            label5.TabIndex=12;
            label5.Text="Fim:";
            // 
            // dtpHorarioFim
            // 
            dtpHorarioFim.CustomFormat="HH:mm";
            dtpHorarioFim.Format=DateTimePickerFormat.Custom;
            dtpHorarioFim.Location=new Point(228, 138);
            dtpHorarioFim.Name="dtpHorarioFim";
            dtpHorarioFim.ShowUpDown=true;
            dtpHorarioFim.Size=new Size(100, 23);
            dtpHorarioFim.TabIndex=13;
            // 
            // checkBoxMarcarContato
            // 
            checkBoxMarcarContato.AutoSize=true;
            checkBoxMarcarContato.Location=new Point(71, 185);
            checkBoxMarcarContato.Name="checkBoxMarcarContato";
            checkBoxMarcarContato.Size=new Size(277, 19);
            checkBoxMarcarContato.TabIndex=14;
            checkBoxMarcarContato.Text="Deseja marcar um contato neste compromisso?";
            checkBoxMarcarContato.UseVisualStyleBackColor=true;
            // 
            // cbContatos
            // 
            cbContatos.DropDownStyle=ComboBoxStyle.DropDownList;
            cbContatos.FormattingEnabled=true;
            cbContatos.Location=new Point(71, 210);
            cbContatos.Name="cbContatos";
            cbContatos.Size=new Size(277, 23);
            cbContatos.TabIndex=15;
            // 
            // entidadeContatoBindingSource
            // 
            entidadeContatoBindingSource.DataSource=typeof(WinApp.ModuloContato.EntidadeContato);
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(71, 260);
            label6.Name="label6";
            label6.Size=new Size(68, 15);
            label6.TabIndex=16;
            label6.Text="Localização";
            // 
            // rdbRemoto
            // 
            rdbRemoto.AutoSize=true;
            rdbRemoto.Location=new Point(8, 78);
            rdbRemoto.Name="rdbRemoto";
            rdbRemoto.Size=new Size(70, 19);
            rdbRemoto.TabIndex=17;
            rdbRemoto.TabStop=true;
            rdbRemoto.Tag="1";
            rdbRemoto.Text="Remoto:";
            rdbRemoto.UseVisualStyleBackColor=true;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize=true;
            rdbPresencial.Location=new Point(8, 53);
            rdbPresencial.Name="rdbPresencial";
            rdbPresencial.Size=new Size(81, 19);
            rdbPresencial.TabIndex=18;
            rdbPresencial.TabStop=true;
            rdbPresencial.Tag="0";
            rdbPresencial.Text="Presencial:";
            rdbPresencial.UseVisualStyleBackColor=true;
            // 
            // txtLocalizacao
            // 
            txtLocalizacao.Location=new Point(158, 311);
            txtLocalizacao.Name="txtLocalizacao";
            txtLocalizacao.Size=new Size(187, 23);
            txtLocalizacao.TabIndex=19;
            txtLocalizacao.TextChanged+=txtValidarCompromisso;
            // 
            // panelLocalizacao
            // 
            panelLocalizacao.Controls.Add(rdbPresencial);
            panelLocalizacao.Controls.Add(rdbRemoto);
            panelLocalizacao.Location=new Point(61, 248);
            panelLocalizacao.Name="panelLocalizacao";
            panelLocalizacao.Size=new Size(287, 110);
            panelLocalizacao.TabIndex=20;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult=DialogResult.OK;
            btnGravar.Location=new Point(192, 364);
            btnGravar.Name="btnGravar";
            btnGravar.Size=new Size(75, 41);
            btnGravar.TabIndex=21;
            btnGravar.Text="Gravar";
            btnGravar.UseVisualStyleBackColor=true;
            btnGravar.Click+=btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult=DialogResult.Cancel;
            btnCancelar.Location=new Point(273, 364);
            btnCancelar.Name="btnCancelar";
            btnCancelar.Size=new Size(75, 41);
            btnCancelar.TabIndex=22;
            btnCancelar.Text="Cancelar";
            btnCancelar.UseVisualStyleBackColor=true;
            // 
            // DialogCompromisso
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(469, 479);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtLocalizacao);
            Controls.Add(label6);
            Controls.Add(cbContatos);
            Controls.Add(checkBoxMarcarContato);
            Controls.Add(dtpHorarioFim);
            Controls.Add(label5);
            Controls.Add(dtpHorarioInicio);
            Controls.Add(label4);
            Controls.Add(dtpData);
            Controls.Add(label3);
            Controls.Add(txtAssunto);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(panelLocalizacao);
            FormBorderStyle=FormBorderStyle.FixedDialog;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="DialogCompromisso";
            ShowIcon=false;
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cadastro de Compromissos";
            ((System.ComponentModel.ISupportInitialize)entidadeContatoBindingSource).EndInit();
            panelLocalizacao.ResumeLayout(false);
            panelLocalizacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox txtAssunto;
        private Label label3;
        private DateTimePicker dtpData;
        private Label label4;
        private DateTimePicker dtpHorarioInicio;
        private Label label5;
        private DateTimePicker dtpHorarioFim;
        private CheckBox checkBoxMarcarContato;
        private ComboBox cbContatos;
        private Label label6;
        private RadioButton rdbRemoto;
        private RadioButton rdbPresencial;
        private TextBox txtLocalizacao;
        private Panel panelLocalizacao;
        private Button btnGravar;
        private Button btnCancelar;
        private BindingSource entidadeContatoBindingSource;
    }
}