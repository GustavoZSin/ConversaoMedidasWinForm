namespace ProvaPOOII
{
    public interface IConversor
    {
        double ValorReferencia { get; set; }

        //Sistema Imperial
        double Polegada { get; set; }
        double Pe { get; set; }
        double Milha { get; set; }
        double Galao { get; set; }
        double Libra { get; set; }

        //Sistema decimal
        double Cm { get; set; }
        double Metro { get; set; }
        double Quilometro { get; set; }
        double Litro { get; set; }
        double Quilo { get; set; }

        void EfetuarConversoes();
    }
}