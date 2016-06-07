namespace Primeiro_programa_funcional
{
    partial class CriarOs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CriarCod = new System.Windows.Forms.TextBox();
            this.CriarDescricao = new System.Windows.Forms.TextBox();
            this.CriarManutentor = new System.Windows.Forms.TextBox();
            this.CriarPrioridade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CriarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código da OS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manutentor:";
            // 
            // CriarCod
            // 
            this.CriarCod.Location = new System.Drawing.Point(97, 28);
            this.CriarCod.Name = "CriarCod";
            this.CriarCod.Size = new System.Drawing.Size(121, 20);
            this.CriarCod.TabIndex = 3;
            // 
            // CriarDescricao
            // 
            this.CriarDescricao.Location = new System.Drawing.Point(97, 101);
            this.CriarDescricao.Name = "CriarDescricao";
            this.CriarDescricao.Size = new System.Drawing.Size(121, 20);
            this.CriarDescricao.TabIndex = 4;
            // 
            // CriarManutentor
            // 
            this.CriarManutentor.Location = new System.Drawing.Point(97, 137);
            this.CriarManutentor.Name = "CriarManutentor";
            this.CriarManutentor.Size = new System.Drawing.Size(121, 20);
            this.CriarManutentor.TabIndex = 5;
            // 
            // CriarPrioridade
            // 
            this.CriarPrioridade.FormattingEnabled = true;
            this.CriarPrioridade.Items.AddRange(new object[] {
            "",
            "1-Normal",
            "2-Urgente",
            "3-Muito Urgente"});
            this.CriarPrioridade.Location = new System.Drawing.Point(97, 64);
            this.CriarPrioridade.Name = "CriarPrioridade";
            this.CriarPrioridade.Size = new System.Drawing.Size(121, 21);
            this.CriarPrioridade.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prioridade:";
            // 
            // CriarBtn
            // 
            this.CriarBtn.Location = new System.Drawing.Point(97, 179);
            this.CriarBtn.Name = "CriarBtn";
            this.CriarBtn.Size = new System.Drawing.Size(75, 23);
            this.CriarBtn.TabIndex = 8;
            this.CriarBtn.Text = "Criar";
            this.CriarBtn.UseVisualStyleBackColor = true;
            this.CriarBtn.Click += new System.EventHandler(this.CriarBtn_Click);
            // 
            // CriarOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 262);
            this.Controls.Add(this.CriarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CriarPrioridade);
            this.Controls.Add(this.CriarManutentor);
            this.Controls.Add(this.CriarDescricao);
            this.Controls.Add(this.CriarCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CriarOs";
            this.Text = "Iniciar Chamado";
            this.Load += new System.EventHandler(this.CriarOs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CriarCod;
        private System.Windows.Forms.TextBox CriarDescricao;
        private System.Windows.Forms.TextBox CriarManutentor;
        private System.Windows.Forms.ComboBox CriarPrioridade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CriarBtn;
    }
}