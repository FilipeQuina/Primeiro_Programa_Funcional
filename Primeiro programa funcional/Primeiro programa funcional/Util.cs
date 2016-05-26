using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_programa_funcional
{
    public class Util
    {
            string mp = Environment.CurrentDirectory;

        public  string Mp
        {
            get
            {
                return mp;
            }

            set
            {
                mp = value;
            }
        }
    }
}
