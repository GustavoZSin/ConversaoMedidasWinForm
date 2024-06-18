namespace ProvaPOOII
{
    public partial class ConversorFrm : Form
    {
        private IConversor _conversor;
        public ConversorFrm(IConversor conversor)
        {
            _conversor = conversor;
            InitializeComponent();
        }

        private void btnValorReferencia_Click(object sender, EventArgs e)
        {
            ValorReferenciaFrm valorReferenciaFrm = new ValorReferenciaFrm(_conversor);
            valorReferenciaFrm.ShowDialog();

            AtualizaCampos();
        }
        private void AtualizaCampos()
        {
            txbValorReferencia.Text = _conversor.ValorReferencia.ToString();
            txbPolegada.Text = _conversor.Polegada.ToString();
            txbPe.Text = _conversor.Pe.ToString();
            txbMilha.Text = _conversor.Milha.ToString();
            txbGalao.Text = _conversor.Galao.ToString();
            txbLibra.Text = _conversor.Libra.ToString();
            txbCm.Text = _conversor.Cm.ToString();
            txbMetro.Text = _conversor.Metro.ToString();
            txbQuilometro.Text = _conversor.Quilometro.ToString();
            txbLitro.Text = _conversor.Litro.ToString();
            txbQuilo.Text = _conversor.Quilo.ToString();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
