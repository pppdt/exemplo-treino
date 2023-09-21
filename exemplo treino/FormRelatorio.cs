using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System.Diagnostics;

namespace exemplo_treino
{
    public partial class FormRelatorio : MaterialForm
    {
        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pwd=;" +
                    "database=academico";
        private PdfDocument doc;

        public FormRelatorio()
        {
            InitializeComponent();
            CarregaImpressora();
        }

        private void CarregaImpressora()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Items.Add(printer);
            }
        }

        private void MontaRelatorio()
        {
            //consulta ao banco de dados
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno WHERE 1=1";
            if (cboEstado.Text != "")
                sql += " and estado = @estado";
            if (txtcidade.Text !="")
                sql += " and cidade = @cidade";

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            if (cboEstado.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@estado", cboEstado.Text);
            if (txtcidade.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@cidade", txtcidade.Text);


            doc = new PdfDocument();

            var dt = new DataTable();
            sqlAd.Fill(dt);//resultado da consulta em memoria
            con.Close();


            //Inicio geração pdf
            //PdfDocument doc= new PdfDocument(); tirar linha
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            float y = 20;
            PdfBrush brush1 = PdfBrushes.Black ; //são comandos para colocar cor
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold)); //fonte letra
            PdfStringFormat format1= new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatorio de Alunos", font1, brush1, page.Canvas.ClientSize.Width/2, y, format1);

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
          //  table.Style.HeaderRowCount= 1;
            table.Style.ShowHeader= true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue; // colocando cor no cabeçalho
            table.DataSource = dt;
            foreach(PdfColumn col in table.Columns)
            {
                col.StringFormat= new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            table.Draw(page, new PointF(0, y+20));

            doc.SaveToFile("RelatorioAlunos.pdf");

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            doc.LoadFromFile("RelatorioAlunos.pdf");
            doc.PrintSettings.PrinterName = cboImpressora.Text;
            doc.Print();



            //enviar para impressora
          
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
    
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioAlunos.pdf")
            {
                UseShellExecute = true
            };
            p.Start();

        }
    }
}
