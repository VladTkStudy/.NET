namespace Calculator
{
    internal static class Program
    {
        //Виконав: Ткаченко Владислав, група ПЗ-2204
        //Дата 26.02.2024, email:vladtk.fm@gmail.com

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Calculator());
        }
    }
}