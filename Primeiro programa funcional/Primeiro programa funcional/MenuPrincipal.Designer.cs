namespace Primeiro_programa_funcional
{
    partial class MenuPrincipal
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lst_OS = new System.Windows.Forms.ListView();
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prioridade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_Abertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manutentor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.iniciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordemDeServiçoToolStripMenuItem});
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de serviço";
            // 
            // Lst_OS
            // 
            this.Lst_OS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Código,
            this.Prioridade,
            this.Data_Abertura,
            this.Descrição,
            this.Manutentor});
            this.Lst_OS.GridLines = true;
            this.Lst_OS.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.Lst_OS.LabelEdit = true;
            this.Lst_OS.Location = new System.Drawing.Point(18, 27);
            this.Lst_OS.Name = "Lst_OS";
            this.Lst_OS.Size = new System.Drawing.Size(698, 502);
            this.Lst_OS.TabIndex = 3;
            this.Lst_OS.UseCompatibleStateImageBehavior = false;
            this.Lst_OS.View = System.Windows.Forms.View.Details;
            // 
            // Código
            // 
            this.Código.Text = "Código";
            this.Código.Width = 104;
            // 
            // Prioridade
            // 
            this.Prioridade.Text = "Prioridade";
            this.Prioridade.Width = 99;
            // 
            // Data_Abertura
            // 
            this.Data_Abertura.Text = "Data Abertura";
            this.Data_Abertura.Width = 101;
            // 
            // Descrição
            // 
            this.Descrição.Text = "Descrição";
            this.Descrição.Width = 310;
            // 
            // Manutentor
            // 
            this.Manutentor.Text = "Manutentor";
            this.Manutentor.Width = 80;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(739, 742);
            this.Controls.Add(this.Lst_OS);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ListView Lst_OS;
        private System.Windows.Forms.ColumnHeader Código;
        private System.Windows.Forms.ColumnHeader Prioridade;
        private System.Windows.Forms.ColumnHeader Data_Abertura;
        private System.Windows.Forms.ColumnHeader Descrição;
        private System.Windows.Forms.ColumnHeader Manutentor;
    }
}