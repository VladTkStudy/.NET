namespace ProgrammerCalculator
{
    internal static class Program
    {
        //Виконав: Ткаченко Владислав, група ПЗ-2204
        //Дата 01.03.2024, email:vladtk.fm@gmail.com

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new CalculatorManager());
        }
    }
}