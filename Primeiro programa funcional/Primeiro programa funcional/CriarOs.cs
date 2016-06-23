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
    public partial class CriarOs : Form 
    {
        public CriarOs()
        {
            InitializeComponent();
        }
        private void CriarOs_Load(object sender, EventArgs e)
        {
            CriarCod.Text = "";
            CriarPrioridade.Text = "";
            CriarDescricao.Text = "";
            CriarManutentor.Text = "";

        }

        OrdemServico os = new OrdemServico();
      
       
        private void CriarBtn_Click(object sender, EventArgs e)
        {
            os.CriarOs(CriarCod.Text, CriarPrioridade.Text, CriarDescricao.Text, CriarManutentor.Text); 
            this.Close();
        }

 
    }
}
