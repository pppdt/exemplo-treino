using ReaLTaiizor.Forms;

namespace exemplo_treino
{
    public partial class FormRelatorioAluno : MaterialForm
    {
        public FormRelatorioAluno()
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

    }
}
