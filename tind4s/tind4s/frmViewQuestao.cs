using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tind4s
{
    public partial class frmViewQuestao : Form
    {
        public frmViewQuestao()
        {
            InitializeComponent();
            gridQuestao.AllowUserToAddRows = false;
            gridQuestao.AllowUserToDeleteRows = false;
            gridQuestao.ReadOnly = true;
        }

        private void CarregaGrid()
        {
            ClsQuestao mObjQuestao = new ClsQuestao();
            mObjQuestao.PreencheGrid();
            gridQuestao.DataSource = mObjQuestao.DSQuestao;
            gridQuestao.DataMember = mObjQuestao.DSQuestao.Tables[0].TableName;
            gridQuestao.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }


    }
}
