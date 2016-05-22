using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_programa_funcional
{
    public partial class LogSistema : Form
    {
        public LogSistema()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void VerificarLoginBotao_Click(object sender, EventArgs e)
        {
            Cadeado.ImageLocation = "C:\\Users\\Filipe\\Desktop\\ProjetosGit\\Primeiro programa funcional\\Primeiro programa funcional\\img\\Cad_aberto.png";
        }
    }
}