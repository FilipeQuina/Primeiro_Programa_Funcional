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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public void MenuPrincipal_Load(object sender, EventArgs e)
        {
            carregarListView();
        }

        OrdemServico os = new OrdemServico();
        CriarOs Cos = new CriarOs();

        private void exibirRegistros()
        {
            String prioridade="";
            String descricao="";
            String manutentor="";

            prioridade = Lst_OS.SelectedItems[0].SubItems[1].Text;
            descricao = Lst_OS.SelectedItems[0].SubItems[3].Text;
            manutentor = Lst_OS.SelectedItems[0].SubItems[4].Text;

            prioridadeTxt.Text = prioridade;
            descricaoTxt.Text =descricao;
            manutentorTxt.Text = manutentor;
            Button button = new Button();
        }
        
        public void carregarListView()
        {
            List<OrdemServico.OrdemDeServico> lst = new List<OrdemServico.OrdemDeServico>();
             
             lst = os.VisualizarAbertos();
             Lst_OS.Items.Clear();
            
            foreach (var itemLista in lst)
             {
                 ListViewItem objListView = new ListViewItem();
                 objListView.Text = itemLista.codOs;
                 objListView.SubItems.Add(itemLista.prioridade);
                 objListView.SubItems.Add((itemLista.dataAbertura).ToShortDateString());
                 objListView.SubItems.Add(itemLista.descricao);
                 objListView.SubItems.Add(itemLista.manutentor);

                 Lst_OS.Items.Add(objListView);
             }
         }

        private void Lst_OS_Click(object sender, EventArgs e)
        {
            exibirRegistros();
        }
      
        private void AlterarBtn_Click(object sender, EventArgs e)
        {
            descricaoTxt.ReadOnly = false;
            manutentorTxt.ReadOnly = false;
            SalvarBtn.Visible = true;
            AlterarBtn.Visible = false;
            dataFechamentoTxt.ReadOnly = false;
        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                os.AlterarOS(Lst_OS.SelectedItems[0].Text, prioridadeTxt.Text, descricaoTxt.Text, manutentorTxt.Text, dataFechamentoTxt.Text);
                carregarListView();

                descricaoTxt.ReadOnly = true;
                manutentorTxt.ReadOnly = true;
                dataFechamentoTxt.ReadOnly = true;
                SalvarBtn.Visible = false;
                AlterarBtn.Visible = true;
                dataFechamentoTxt.Text = "";
            }
            catch (Exception )
            {
                MessageBox.Show("Selecione uma Ordem de Serviço", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //throw;
            }
   
        }
       
        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cos.Show();
        }

        private void AtualizarBtn_Click(object sender, EventArgs e)
        {
            carregarListView();
        }

        private void editar_Enter(object sender, EventArgs e)
        {

        }
    }
}

