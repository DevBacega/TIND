using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace tind4s
{
    public abstract class ClsManutencao
    {
        public DataSet Ds;

        abstract public string InserirProfessor();
        abstract public string UpdateProfessor();
        abstract public string VizualizarProfessor(int Id);
        abstract public string AfastarProfessor();
        abstract public bool verificacao(string Usuario, string Senha);
    }
}
