using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_treino
{
    public partial class FormRelatorioCurso : MaterialForm
    {
        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pwd=;" +
                    "database=academico";
     
         private PdfDocument doc;
        public FormRelatorioCurso()
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
            var sql = "SELECT * FROM curso WHERE 1=1";
            if (cboTipo.Text != "")
                sql += " and tipo = @tipo";
            if (txtAno.Text != "")
                sql += " and ano_criacao = @ano_criacao";

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            if (cboTipo.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@tipo", cboTipo.Text);
            if (txtAno.Text != "")
                sqlAd.SelectCommand.Parameters.AddWithValue("@ano_criacao", txtAno.Text);

            doc = new PdfDocument();

        var dt = new DataTable();
            sqlAd.Fill(dt);//resultado da consulta em memoria
            con.Close();

            //Inicio geração pdf
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            float y = 20;
            PdfBrush brush1 = PdfBrushes.Black; //são comandos para colocar cor
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold)); //fonte letra
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatorio de Cursos", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            //  table.Style.HeaderRowCount= 1;
            table.Style.ShowHeader = true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue; // colocando cor no cabeçalho
            table.DataSource = dt;
            foreach (PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            table.Draw(page, new PointF(0, y + 20));

            doc.SaveToFile("RelatorioCurso.pdf");

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            doc.LoadFromFile("RelatorioCurso.pdf");
            doc.PrintSettings.PrinterName = cboImpressora.Text;
            doc.Print();

            //enviar para impressora
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioCurso.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
