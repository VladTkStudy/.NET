namespace EngineerCalculator
{
    public enum ColorTheme
    {
        Dark,
        White
    }

    public enum FontName
    {
        Consolas,
        TimesNewRoman,
        Impact,
        Roboto
    }

    public class OptionsData
    {
        public readonly string OptionsSavePath = "C:\\Users\\nagib\\Documents\\VSCode\\c#\\.net\\lab5\\Calculator Manager\\config.txt";
        public readonly string[] FontSizes =
        {
            "small",
            "medium",
            "huge"
        };

        public Dictionary<string, Font> fontsDictionary = new Dictionary<string, Font>();
        public Dictionary<string, byte> fontSizesDictionary = new Dictionary<string, byte>();

        #region properties
        public string ColorThemeName => colorThemeName == null ? "null" : colorThemeName;
        public void SetColorTheme(ColorTheme colorTheme)
        {
            colorThemeName = Enum.GetName(typeof(ColorTheme), colorTheme)?.ToLower();
            OnOptionsChanged?.Invoke();
        }
        public string FontNameString => fontName == null ? string.Empty : fontName;
        public Font GetFont()
        {
            if (fontName == null)
                throw new Exception($"\'fontName\' variable is null");

            if (fontsDictionary.ContainsKey(fontName))
                return fontsDictionary[fontName];
            else
                throw new Exception($"Unable to find font with name: {fontName}");
        }
        public void SetFontName(FontName font)
        {
            fontName = Enum.GetName(typeof(FontName), font)?.ToLower();
            fontsDictionary.Clear();
            InitializeFontsDictionary();
            OnOptionsChanged?.Invoke();
        }
        public byte FontSize => fontSize;
        public void SetFontSize(string size)
        {
            if (fontSizesDictionary.ContainsKey(size))
            {
                fontSize = fontSizesDictionary[size];
                fontsDictionary.Clear();
                InitializeFontsDictionary();
                OnOptionsChanged?.Invoke();
            }
        }
        public bool ShowHints
        {
            set 
            { 
                showHints = value; 
                OnOptionsChanged?.Invoke();
            }
            get { return showHints; }
        }
        public bool CloseOnStart
        {
            set 
            { 
                closeOnStart = value; 
                OnOptionsChanged?.Invoke();
            }
            get { return closeOnStart; }
        }
        #endregion

        private string? colorThemeName;
        private string? fontName;
        private byte fontSize;
        private bool showHints;
        private bool closeOnStart;

        public Action? OnOptionsChanged { get; set; }

        public OptionsData()
        {
            TryLoadData();
            InitializeFontsDictionary();
            InitializeFontSizesDisctionary();
        }

        private void InitializeFontsDictionary()
        {
            fontsDictionary.Add("consolas", new Font("Consolas", fontSize == 0 ? 12 : fontSize));
            fontsDictionary.Add("timesnewroman", new Font("Times New Roman", fontSize == 0 ? 12 : fontSize));
            fontsDictionary.Add("impact", new Font("Impact", fontSize == 0 ? 12 : fontSize));
            fontsDictionary.Add("roboto", new Font("Roboto", fontSize == 0 ? 12 : fontSize));
        }

        private void InitializeFontSizesDisctionary()
        {
            fontSizesDictionary.Add(FontSizes[0], 9);
            fontSizesDictionary.Add(FontSizes[1], 12);
            fontSizesDictionary.Add(FontSizes[2], 15);
        }

        public void SetDefaultValues()
        {
            SetColorTheme(ColorTheme.Dark);
            SetFontName(FontName.Consolas);
            SetFontSize(FontSizes[0]);
            ShowHints = true;
            CloseOnStart = true;
        }

        /// <summary>
        /// Tries to parse data using 'OptionsSavePath' variable.
        /// If read lines length is not equal to 5, throws an error.
        /// If some lines couldn't be applied, skips them.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void TryLoadData()
        {
            string[] data;
            if (File.Exists(OptionsSavePath))
                data = File.ReadAllLines(OptionsSavePath);
            else
            {
                SetDefaultValues();
                return;
            }

            if (data.Length != 5)
                throw new Exception($"Incorrect data items length: {data.Length}");

            foreach (string name in Enum.GetNames(typeof(ColorTheme)))
                if (data[0] == name.ToLower())
                    colorThemeName = name.ToLower();

            foreach (string font in Enum.GetNames(typeof(FontName)))
                if (data[1] == font.ToLower())
                    fontName = font.ToLower();

            byte.TryParse(data[2], out fontSize);
            bool.TryParse(data[3], out showHints);
            bool.TryParse(data[4], out closeOnStart);
        }

        /// <summary>
        /// Saves all the data values to the file using initialized readoly path.
        /// </summary>
        public void SaveData()
        {
            string[] data =
            {
                colorThemeName == null ? "null" : colorThemeName,
                fontName == null ? "null" : fontName,
                fontSize.ToString(),
                showHints.ToString(),
                closeOnStart.ToString()
            };
            File.WriteAllLines(OptionsSavePath, data);
        }
    }
}
