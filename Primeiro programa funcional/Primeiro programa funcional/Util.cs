using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_programa_funcional
{
    public class Util
    {
        string bd_conexao= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Filipe\Desktop\ProjetosGit\Primeiro_Programa_Funcional\Primeiro programa funcional\Primeiro programa funcional\ppf_bd.mdf"";Integrated Security = True";

        //*Get e Set*//
        public string Bd_conexao
        {
            get
            {
                return bd_conexao;
            }

            set
            {
                bd_conexao = value;
            }
        }
        //*Get e Set*//
    }
}
