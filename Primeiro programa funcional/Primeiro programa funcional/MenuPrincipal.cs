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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            carregarListView();
        }

            private void carregarListView()
            {
                OrdemServico os = new OrdemServico();
                List<OrdemServico.OrdemDeServico> lst = new List<OrdemServico.OrdemDeServico>();
                lst = os.VisualizarAbertos();
                Lst_OS.Items.Clear();
                foreach (var itemLista in lst)
                {
                    ListViewItem objListView = new ListViewItem();
                    objListView.Text = itemLista.codOs;
                    objListView.SubItems.Add(itemLista.prioridade);
                    objListView.SubItems.Add((itemLista.dataAbertura).ToString());
                    objListView.SubItems.Add(itemLista.descricao);
                    objListView.SubItems.Add(itemLista.manutentor);

                    Lst_OS.Items.Add(objListView);

                }
            }

    }
    }

