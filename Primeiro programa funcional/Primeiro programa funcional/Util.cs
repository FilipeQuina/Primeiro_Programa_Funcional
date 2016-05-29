using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_programa_funcional
{
    public class Util
    {
        string bd_conexao= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Filipe\Documents\ppf_bd.mdf;Integrated Security = True; Connect Timeout = 30";
        

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
