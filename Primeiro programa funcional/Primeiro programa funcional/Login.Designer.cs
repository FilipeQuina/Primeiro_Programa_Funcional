namespace Primeiro_programa_funcional
{
    partial class LogSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogSistema));
            this.LoginTBox = new System.Windows.Forms.TextBox();
            this.SenhaTBox = new System.Windows.Forms.TextBox();
            this.VerificarLoginBotao = new System.Windows.Forms.Button();
            this.LoginTx = new System.Windows.Forms.Label();
            this.SenhaTx = new System.Windows.Forms.Label();
            this.Cadeado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cadeado)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTBox
            // 
            this.LoginTBox.Location = new System.Drawing.Point(70, 12);
            this.LoginTBox.Name = "LoginTBox";
            this.LoginTBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTBox.TabIndex = 0;
            // 
            // SenhaTBox
            // 
            this.SenhaTBox.Location = new System.Drawing.Point(70, 38);
            this.SenhaTBox.Name = "SenhaTBox";
            this.SenhaTBox.Size = new System.Drawing.Size(100, 20);
            this.SenhaTBox.TabIndex = 1;
            // 
            // VerificarLoginBotao
            // 
            this.VerificarLoginBotao.Location = new System.Drawing.Point(70, 76);
            this.VerificarLoginBotao.Name = "VerificarLoginBotao";
            this.VerificarLoginBotao.Size = new System.Drawing.Size(75, 23);
            this.VerificarLoginBotao.TabIndex = 2;
            this.VerificarLoginBotao.Text = "Entrar";
            this.VerificarLoginBotao.UseVisualStyleBackColor = true;
            this.VerificarLoginBotao.Click += new System.EventHandler(this.VerificarLoginBotao_Click);
            // 
            // LoginTx
            // 
            this.LoginTx.AutoSize = true;
            this.LoginTx.Location = new System.Drawing.Point(28, 15);
            this.LoginTx.Name = "LoginTx";
            this.LoginTx.Size = new System.Drawing.Size(36, 13);
            this.LoginTx.TabIndex = 3;
            this.LoginTx.Text = "Login:";
            // 
            // SenhaTx
            // 
            this.SenhaTx.AutoSize = true;
            this.SenhaTx.Location = new System.Drawing.Point(28, 41);
            this.SenhaTx.Name = "SenhaTx";
            this.SenhaTx.Size = new System.Drawing.Size(41, 13);
            this.SenhaTx.TabIndex = 4;
            this.SenhaTx.Text = "Senha:";
            // 
            // Cadeado
            // 
            this.Cadeado.Image = ((System.Drawing.Image)(resources.GetObject("Cadeado.Image")));
            this.Cadeado.InitialImage = null;
            this.Cadeado.Location = new System.Drawing.Point(176, 12);
            this.Cadeado.Name = "Cadeado";
            this.Cadeado.Size = new System.Drawing.Size(100, 98);
            this.Cadeado.TabIndex = 5;
            this.Cadeado.TabStop = false;
            // 
            // LogSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.Cadeado);
            this.Controls.Add(this.SenhaTx);
            this.Controls.Add(this.LoginTx);
            this.Controls.Add(this.VerificarLoginBotao);
            this.Controls.Add(this.SenhaTBox);
            this.Controls.Add(this.LoginTBox);
            this.Name = "LogSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificação";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cadeado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTBox;
        private System.Windows.Forms.TextBox SenhaTBox;
        private System.Windows.Forms.Button VerificarLoginBotao;
        private System.Windows.Forms.Label LoginTx;
        private System.Windows.Forms.Label SenhaTx;
        private System.Windows.Forms.PictureBox Cadeado;
    }
}

