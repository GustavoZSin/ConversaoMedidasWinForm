namespace ProvaPOOII
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IConversor conversor = new Conversor();
            Application.Run(new ConversorFrm(conversor));
        }
    }
}