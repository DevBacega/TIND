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
        abstract public void Inserir();
        abstract public void Atualizar();
        abstract public void Selecionar();
        abstract public void Desativa();
        abstract public void PreencheGrid();


        
    }
}
