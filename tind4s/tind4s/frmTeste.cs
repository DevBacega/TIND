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
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Header = "<body style='font-family: sans-serif;'" +
                            "<div id = 'Header' style = 'padding: 5px;'>" +
                                "<h2> Instituto Federal de São Paulo -Campus Capivari - [DATA ATUAL] </h2>" +
                                "<h3> Professor - [NOME DO PROFESSOR] </h3>" +
                                "<h3> Prova - [TITULO DA PROVA] </h3>" +
                                "<p style = 'font-weight: bold;'> Nome:________________________________________________ Prontuario:___________ Nota:______ </p>" +
                            "</div>" +
                            "<div id='Body' style='border: 1px solid black; margin-top: 10px; padding:10px'>";


            var Questao = "<div id='questao' style=''>" +
                                "<div id='Enunciado'>[0] - [DESCRIÇÃO PERGUNTA] </div>" +
                                "<div id='Respostas' style='margin-top: 5px;'>" +
                                    "A - [RESPOSTA] <br>" +
                                    "B - [RESPOSTA] <br>" +
                                    "C - [RESPOSTA] <br>" +
                                    "D - [RESPOSTA] <br>" +
                                    "E - [RESPOSTA] <br>" +
                                "</div>" +
                            "</div>" +
                            "<div id='Divider' style='width: auto; height: 5px; border-top:1px dashed black; margin:5px 0 5px 0;'></div>";

            var Footer = "</div>" +
                        "</body>";

            var Body = "";
            for(int i =0; i < 100; i++)
            {
                 Body += Questao;
            }

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

            var PDF = Rendere.RenderHtmlAsPdf(Header+Body+Footer);
            var OutputPath = "HtmlTestePDF.pdf";
            PDF.SaveAs(OutputPath);

            System.Diagnostics.Process.Start(OutputPath);
        }
    }
}
