using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPdf;

namespace tind4s
{
    public partial class frmProva : Form
    {
        public frmProva()
        {
            InitializeComponent();
            CarregaGrid();
        }


        private void CarregaGrid()
        {
            ClsProva mObjProva = new ClsProva();
            mObjProva.PreencheGrid();
            dgvProva.DataSource = mObjProva.DSProva;
            dgvProva.DataMember = mObjProva.DSProva.Tables[0].TableName;
            dgvProva.Refresh();
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            frmProvaCadastro frm = new frmProvaCadastro();
            frm.ShowDialog();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            ClsProva mObjProva = new ClsProva()
            {
                Id_Prova = Convert.ToInt32(dgvProva.CurrentRow.Cells[0].Value)
            };

            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja excluir essa Prova?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    mObjProva.Desativa();
                    CarregaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                    CarregaGrid();
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirProva(Convert.ToInt32(dgvProva.CurrentRow.Cells[0].Value));
        }

        public void ImprimirProva(int IdProva)
        {
            ClsProva mObjProva = new ClsProva
            {
                Id_Prova = IdProva
            };

            mObjProva.Selecionar();

            var Header = "<body style='font-family: sans-serif;'" +
                            "<div id = 'Header' style = 'padding: 5px;'>" +
                                "<h2> Instituto Federal de São Paulo - Campus Capivari - "+DateTime.Now.ToShortDateString()+"</h2>" +
                                "<h3> Professor - "+mObjProva.Id_Prontuario.ToString()+"</h3>" +
                                "<h3> Prova - "+mObjProva.Nm_Prova+"</h3>" +
                                "<p style = 'font-weight: bold;'> Nome:________________________________________________ Prontuario:___________ Nota:______ </p>" +
                            "</div>" +
                            "<div id='Body' style='border: 1px solid black; margin-top: 10px; padding:10px'>";
            mObjProva.ImprimiQuestaoProva();
            DataSet Ds = mObjProva.DSProva;


            ClsQuestao mObjQuestao = new ClsQuestao();
            ClsAlternativa mObjAlternativa = new ClsAlternativa();

            var Body = "";
            int contador = 0;
            foreach(DataRow Questao in Ds.Tables[0].Rows)
            {
                contador++;
                mObjQuestao.Id_Questao = Convert.ToInt32(Questao[1]);
                mObjQuestao.Selecionar();
                mObjAlternativa.Id_Questao = Convert.ToInt32(Questao[1]);
                mObjAlternativa.Selecionar();
                DataSet DsAlternativa = mObjAlternativa.DSAlternariva;


                var QuestaoPDF = "<div id='questao' style=''>" +
                                    "<div id='Enunciado'>"+contador.ToString()+" - "+mObjQuestao.Ds_Pergunta+" </div>" +
                                    "<div id='Respostas' style='margin-top: 5px;'>" +
                                        "A - " + DsAlternativa.Tables[0].Rows[0][1].ToString() + " <br>" +
                                        "B - " + DsAlternativa.Tables[0].Rows[1][1].ToString() + " <br>" +
                                        "C - " + DsAlternativa.Tables[0].Rows[2][1].ToString() + " <br>" +
                                        "D - " + DsAlternativa.Tables[0].Rows[3][1].ToString() + " <br>" +
                                        "E - " + DsAlternativa.Tables[0].Rows[4][1].ToString() + " <br>" +
                                    "</div>" +
                                "</div>" +
                                "<div id='Divider' style='width: auto; height: 5px; border-top:1px dashed black; margin:5px 0 5px 0;'></div>";
                Body += QuestaoPDF;

            }

            var Footer = "</div>" +
                        "</body>";

            var Rendere = new IronPdf.HtmlToPdf();

            Rendere.PrintOptions.Title = "Prova [NOME PROVA]";
            Rendere.PrintOptions.MarginTop = 10;
            Rendere.PrintOptions.MarginLeft = 10;
            Rendere.PrintOptions.MarginRight = 10;
            Rendere.PrintOptions.MarginBottom = 10;

            Rendere.PrintOptions.Footer.DrawDividerLine = true;
            Rendere.PrintOptions.Footer.FontFamily = "Arial";
            Rendere.PrintOptions.Footer.FontSize = 10;
            Rendere.PrintOptions.Footer.LeftText = "{date} {time}";
            Rendere.PrintOptions.Footer.RightText = "{page} of {total-pages}";

            var PDF = Rendere.RenderHtmlAsPdf(Header + Body + Footer);
            var OutputPath = "HtmlTestePDF.pdf";
            PDF.SaveAs(OutputPath);

            System.Diagnostics.Process.Start(OutputPath);

        }
    }
}
