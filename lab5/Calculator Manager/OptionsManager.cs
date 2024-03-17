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
            ApplyLoadedData();
        }

        private void ApplyLoadedData()
        {
            dark.Checked = data.ColorThemeName == "dark";
            white.Checked = data.ColorThemeName == "white";

            foreach (var item in fontStyle.Items)
                if (item.ToString()?.ToLower() == data.FontNameString)
                {
                    fontStyle.SelectedItem = item;
                    break;
                }

            foreach (var item in fontSize.Items)
            {
                if (item.ToString()?.ToLower() == null)
                    break;

                if (data.fontSizesDictionary[item.ToString()?.ToLower()] == data.FontSize)
                {
                    fontSize.SelectedItem = item;
                    break;
                }
            }

            switch (data.FontSize)
            {
                case 9:
                    fontSize.Select(0, 0);
                    break;
                case 12:
                    fontSize.Select(1, 0);
                    break;
                case 15:
                    fontSize.Select(2, 0);
                    break;
                default: break;
            }

            showHints.Checked = data.ShowHints;
            hideOnStart.Checked = data.CloseOnStart;

            var themeId = data.ColorThemeName == "dark" ? 0 : 1;
            BackColor = OptionsApplier.themeBackgroundColors[themeId];
            dark.ForeColor = OptionsApplier.themeFontColors[themeId];
            dark.Font = data.GetFont();
            white.ForeColor = OptionsApplier.themeFontColors[themeId];
            white.Font = data.GetFont();
            fontStyle.BackColor = OptionsApplier.themeBackgroundColors[themeId];
            fontStyle.ForeColor = OptionsApplier.themeFontColors[themeId];
            fontStyle.Font = data.GetFont();
            fontSize.BackColor = OptionsApplier.themeBackgroundColors[themeId];
            fontSize.ForeColor = OptionsApplier.themeFontColors[themeId];
            fontSize.Font = data.GetFont();
            showHints.ForeColor = OptionsApplier.themeFontColors[themeId];
            showHints.Font = data.GetFont();
            hideOnStart.ForeColor = OptionsApplier.themeFontColors[themeId];
            hideOnStart.Font = data.GetFont();
            colorLabel.Font = new Font(data.GetFont().Name, data.GetFont().Size + 5);
            fontLabel.Font = new Font(data.GetFont().Name, data.GetFont().Size + 5);
            otherLabel.Font = new Font(data.GetFont().Name, data.GetFont().Size + 5);
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
            ApplyLoadedData();
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
                if (Enum.GetName((ColorTheme)i)?.ToLower() == radioButton.Text.ToLower())
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
