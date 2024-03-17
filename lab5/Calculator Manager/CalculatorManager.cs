using CalculatorManager;
using System.Diagnostics;

namespace ProgrammerCalculator
{
    public partial class CalculatorManager : Form
    {
        //Виконав: Ткаченко Владислав, група ПЗ-2204
        //Дата 03.03.2024, email:vladtk.fm@gmail.com

        private readonly string[] CalculatorExePaths =
        {
            "C:\\Users\\nagib\\Documents\\VSCode\\C#\\.NET\\lab2\\Calculator\\bin\\Debug\\net8.0-windows\\Calculator.exe",
            "C:\\Users\\nagib\\Documents\\VSCode\\C#\\.NET\\lab3\\Engineer Calculator\\bin\\Debug\\net8.0-windows\\EngineerCalculator.exe",
            "C:\\Users\\nagib\\Documents\\VSCode\\C#\\.NET\\lab4\\Programmer Calculator\\bin\\Debug\\net8.0-windows\\ProgrammerCalculator.exe"
        };

        private RadioButton? currentButton;
        private OptionsManager optionsManager = new OptionsManager();

        public CalculatorManager()
        {
            InitializeComponent();
        }

        private void StartCalculator(CalculatorType type)
        {
            var path = CalculatorExePaths[(int)type];
            if (File.Exists(path))
                Process.Start(path);
            else
                throw new Exception($"There is no such file: {path}");
        }

        private void StartClick(object sender, EventArgs e)
        {
            if (currentButton == null)
                return;

            switch (currentButton.Text)
            {
                case "Default":
                    StartCalculator(CalculatorType.DefaultCalculator);
                    break;
                case "Engineer":
                    StartCalculator(CalculatorType.EngineerCalculator);
                    break;
                case "Programmer":
                    StartCalculator(CalculatorType.ProgrammerCalculator);
                    break;
                default: return;
            }

            if(optionsManager.Data.CloseOnStart)
            {
                optionsManager?.Close();
                Close();
            }
        }

        private void RadioButtonChecked(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            currentButton = radioButton;
        }

        private void OptionsClick(object sender, EventArgs e)
        {
            if(optionsManager == null || optionsManager.IsDisposed)
            {
                optionsManager = new OptionsManager();
                optionsManager.OnApplied += ApplySettings;
            }
            optionsManager.Show();
        }

        private void ApplySettings(object? sender, EventArgs e)
        {
            ApplySettings();
        }

        private void ApplySettings()
        {
            optionsManager.Data.SaveData();
        }
    }
}