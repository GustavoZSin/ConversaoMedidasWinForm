namespace ProvaPOOII
{
    public class Conversor : IConversor
    {
        public double ValorReferencia { get; set; }

        //Sistema imperial
        public double Polegada { get; set; }
        public double Pe { get; set; }
        public double Milha { get; set; }
        public double Galao { get; set; }
        public double Libra { get; set; }

        //Sistema decimal
        public double Cm { get; set; }
        public double Metro { get; set; }
        public double Quilometro { get; set; }
        public double Litro { get; set; }
        public double Quilo { get; set; }

        public void EfetuarConversoes()
        {
            try
            {
                Polegada = Math.Round(2.54 * ValorReferencia, 3);
                Pe = Math.Round(0.3048 * ValorReferencia, 3);
                Milha = Math.Round(1.60934 * ValorReferencia, 3);
                Galao = Math.Round(3.7854 * ValorReferencia, 3);
                Libra = Math.Round(0.4536 * ValorReferencia, 3);

                Cm = Math.Round(0.3937 * ValorReferencia, 3);
                Metro = Math.Round(3.2808 * ValorReferencia, 3);
                Quilometro = Math.Round(0.6214 * ValorReferencia, 3);
                Litro = Math.Round(0.2642 * ValorReferencia, 3);
                Quilo = Math.Round(2.2046 * ValorReferencia, 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao efetuar a conversão. {ex.Message}");
            }
        }
    }
}