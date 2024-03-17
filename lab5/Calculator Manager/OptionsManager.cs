namespace CalculatorManager
{
    public partial class OptionsManager : Form
    {
        public event EventHandler? OnApplied;
        public OptionsData Data => data;

        private OptionsData data = new OptionsData();

        public OptionsManager()
        {
            InitializeComponent();
            InitializeFontDropbox();
            InitializeFontSizeDropbox();
        }

        private void InitializeFontDropbox()
        {
            foreach (string font in Enum.GetNames(typeof(FontName)))
                fontStyle.Items.Add(font);
        }

        private void InitializeFontSizeDropbox()
        {
            foreach (string size in data.FontSizes)
                fontSize.Items.Add(size);
        }

        private void ApplyClick(object sender, EventArgs e)
        {
            OnApplied?.Invoke(this, EventArgs.Empty);
            Hide();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Hide();
        }

        private void FontStyleSelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            data.SetFontName((FontName)comboBox.SelectedIndex);
        }

        private void FontSizeSelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.Text != string.Empty)
                data.SetFontSize(comboBox.Text);
        }

        private void ColorThemeCheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            for (int i = 0; i < Enum.GetNames(typeof(ColorTheme)).Length; i++)
                if (Enum.GetName((ColorTheme)i) == radioButton.Text.ToLower())
                {
                    data.SetColorTheme((ColorTheme)i);
                    break;
                }
        }

        private void ShowHintsCheckedChanged(object sender, EventArgs e)
        {
            data.ShowHints = showHints.Checked;
        }

        private void HideOnStartCheckedChanged(object sender, EventArgs e)
        {
            data.CloseOnStart = hideOnStart.Checked;
        }
    }
}
