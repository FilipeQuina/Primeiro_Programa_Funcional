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
            //*Instanciações*//
            MenuPrincipal m = new MenuPrincipal();
            Util ul = new Util();
            Usuarios us = new Usuarios();
            //*Instanciações*//

            string l = LoginTBox.Text;
            string s = SenhaTBox.Text;
            if (us.VerificarLogin(l, s))
            {
                m.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("Login ou senha inválidos","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}