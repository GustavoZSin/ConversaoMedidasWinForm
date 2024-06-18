namespace ProvaPOOII
{
    public partial class ValorReferenciaFrm : Form
    {
        IConversor _conversor;
        public ValorReferenciaFrm(IConversor conversor)
        {
            _conversor = conversor;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double _valorConvertido;
            bool valorValido;

            do
            {
                valorValido = double.TryParse(txbValorReferencia.Text.Replace(".", ","), out _valorConvertido);
                if (!valorValido)
                {
                    MessageBox.Show("Valor inválido, digite um número válido.");
                    txbValorReferencia.Text = "";
                    return;
                }
            } while (!valorValido);

            _conversor.ValorReferencia = _valorConvertido;
            _conversor.EfetuarConversoes();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
