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

        private void Login_Load(object sender, EventArgs e){}

        private void VerificarLoginBotao_Click(object sender, EventArgs e)
        { 
            MenuPrincipal m = new MenuPrincipal();
            Util ul = new Util();
            m.Show();
            Cadeado.ImageLocation = ul.mp() + "\\Content\\img\\Cad_aberto.png";
            this.Hide();
        }
    }
}