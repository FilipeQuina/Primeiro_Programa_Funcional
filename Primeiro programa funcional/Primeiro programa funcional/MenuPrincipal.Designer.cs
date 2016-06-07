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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Lst_OS = new System.Windows.Forms.ListView();
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prioridade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_Abertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Manutentor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editar = new System.Windows.Forms.GroupBox();
            this.SalvarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AlterarBtn = new System.Windows.Forms.Button();
            this.prioridadeTxt = new System.Windows.Forms.ComboBox();
            this.manutentorTxt = new System.Windows.Forms.TextBox();
            this.descricaoTxt = new System.Windows.Forms.TextBox();
            this.AtualizarBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.editar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.iniciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
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
            this.ordemDeServiçoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem});
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de serviço";
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.criarToolStripMenuItem.Text = "Criar";
            this.criarToolStripMenuItem.Click += new System.EventHandler(this.criarToolStripMenuItem_Click);
            // 
            // Lst_OS
            // 
            this.Lst_OS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Código,
            this.Prioridade,
            this.Data_Abertura,
            this.Descrição,
            this.Manutentor});
            this.Lst_OS.FullRowSelect = true;
            this.Lst_OS.GridLines = true;
            this.Lst_OS.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.Lst_OS.LabelEdit = true;
            this.Lst_OS.Location = new System.Drawing.Point(12, 27);
            this.Lst_OS.MultiSelect = false;
            this.Lst_OS.Name = "Lst_OS";
            this.Lst_OS.Size = new System.Drawing.Size(631, 502);
            this.Lst_OS.TabIndex = 3;
            this.Lst_OS.UseCompatibleStateImageBehavior = false;
            this.Lst_OS.View = System.Windows.Forms.View.Details;
            this.Lst_OS.Click += new System.EventHandler(this.Lst_OS_Click);
            // 
            // Código
            // 
            this.Código.Text = "Código";
            this.Código.Width = 61;
            // 
            // Prioridade
            // 
            this.Prioridade.Text = "Prioridade";
            this.Prioridade.Width = 93;
            // 
            // Data_Abertura
            // 
            this.Data_Abertura.Text = "Data Abertura";
            this.Data_Abertura.Width = 83;
            // 
            // Descrição
            // 
            this.Descrição.Text = "Descrição";
            this.Descrição.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Descrição.Width = 309;
            // 
            // Manutentor
            // 
            this.Manutentor.Text = "Manutentor";
            this.Manutentor.Width = 80;
            // 
            // editar
            // 
            this.editar.Controls.Add(this.SalvarBtn);
            this.editar.Controls.Add(this.label3);
            this.editar.Controls.Add(this.label2);
            this.editar.Controls.Add(this.label1);
            this.editar.Controls.Add(this.AlterarBtn);
            this.editar.Controls.Add(this.prioridadeTxt);
            this.editar.Controls.Add(this.manutentorTxt);
            this.editar.Controls.Add(this.descricaoTxt);
            this.editar.Location = new System.Drawing.Point(649, 27);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(391, 132);
            this.editar.TabIndex = 4;
            this.editar.TabStop = false;
            this.editar.Text = "Editar Dados";
            // 
            // SalvarBtn
            // 
            this.SalvarBtn.Location = new System.Drawing.Point(277, 71);
            this.SalvarBtn.Name = "SalvarBtn";
            this.SalvarBtn.Size = new System.Drawing.Size(108, 47);
            this.SalvarBtn.TabIndex = 8;
            this.SalvarBtn.Text = "Salvar";
            this.SalvarBtn.UseVisualStyleBackColor = true;
            this.SalvarBtn.Visible = false;
            this.SalvarBtn.Click += new System.EventHandler(this.SalvarBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Manutentor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prioridade";
            // 
            // AlterarBtn
            // 
            this.AlterarBtn.Location = new System.Drawing.Point(277, 19);
            this.AlterarBtn.Name = "AlterarBtn";
            this.AlterarBtn.Size = new System.Drawing.Size(108, 47);
            this.AlterarBtn.TabIndex = 4;
            this.AlterarBtn.Text = "Alterar";
            this.AlterarBtn.UseVisualStyleBackColor = true;
            this.AlterarBtn.Click += new System.EventHandler(this.AlterarBtn_Click);
            // 
            // prioridadeTxt
            // 
            this.prioridadeTxt.FormattingEnabled = true;
            this.prioridadeTxt.Items.AddRange(new object[] {
            "",
            "1-Normal",
            "2-Urgente",
            "3-Muito Urgente"});
            this.prioridadeTxt.Location = new System.Drawing.Point(17, 46);
            this.prioridadeTxt.Name = "prioridadeTxt";
            this.prioridadeTxt.Size = new System.Drawing.Size(121, 21);
            this.prioridadeTxt.TabIndex = 3;
            // 
            // manutentorTxt
            // 
            this.manutentorTxt.Location = new System.Drawing.Point(147, 46);
            this.manutentorTxt.Name = "manutentorTxt";
            this.manutentorTxt.ReadOnly = true;
            this.manutentorTxt.Size = new System.Drawing.Size(108, 20);
            this.manutentorTxt.TabIndex = 2;
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.Location = new System.Drawing.Point(17, 92);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.ReadOnly = true;
            this.descricaoTxt.Size = new System.Drawing.Size(238, 20);
            this.descricaoTxt.TabIndex = 1;
            // 
            // AtualizarBtn
            // 
            this.AtualizarBtn.Location = new System.Drawing.Point(649, 165);
            this.AtualizarBtn.Name = "AtualizarBtn";
            this.AtualizarBtn.Size = new System.Drawing.Size(95, 46);
            this.AtualizarBtn.TabIndex = 5;
            this.AtualizarBtn.Text = "Atualizar";
            this.AtualizarBtn.UseVisualStyleBackColor = true;
            this.AtualizarBtn.Click += new System.EventHandler(this.AtualizarBtn_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1052, 541);
            this.Controls.Add(this.AtualizarBtn);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.Lst_OS);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.editar.ResumeLayout(false);
            this.editar.PerformLayout();
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
        private System.Windows.Forms.GroupBox editar;
        private System.Windows.Forms.ComboBox prioridadeTxt;
        private System.Windows.Forms.TextBox manutentorTxt;
        private System.Windows.Forms.TextBox descricaoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AlterarBtn;
        private System.Windows.Forms.Button SalvarBtn;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.Button AtualizarBtn;
    }
}