namespace e_Agenda.WinApp.ModuloContato
{
    partial class ListagemContatoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxEntidades=new ListBox();
            SuspendLayout();
            // 
            // listBoxEntidades
            // 
            listBoxEntidades.Dock=DockStyle.Fill;
            listBoxEntidades.FormattingEnabled=true;
            listBoxEntidades.ItemHeight=15;
            listBoxEntidades.Location=new Point(0, 0);
            listBoxEntidades.Name="listBoxEntidades";
            listBoxEntidades.Size=new Size(714, 427);
            listBoxEntidades.TabIndex=0;
            // 
            // ListagemContatoControl
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            Controls.Add(listBoxEntidades);
            Name="ListagemContatoControl";
            Size=new Size(714, 427);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxEntidades;
    }
}
