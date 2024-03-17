using ExtendedMath;

namespace EngineerCalculator
{
    public partial class EngineerCalculator : Form
    {
        //Виконав: Ткаченко Владислав, група ПЗ-2204
        //Дата 29.02.2024, email:vladtk.fm@gmail.com

        private const float DefaultValue = float.MaxValue;
        private const bool IsDebugMode = false;
        private readonly Dictionary<char, Action> actionsDictionary = new();

        private Action? action;
        private string currentNumberString = string.Empty;
        private OptionsData data = new OptionsData();

        private float firstNumber = DefaultValue;
        private float secondNumber = DefaultValue;
        private float result;
        private bool usedDot = false;

        public EngineerCalculator()
        {
            InitializeComponent();
            InitializeDictionary();
            ApplyLoadedData();
        }

        private void ApplyLoadedData()
        {
            BackColor = OptionsApplier.themeBackgroundColors[data.ColorThemeName == "dark" ? 0 : 1];
            ApplyButtonDesign(one);
            ApplyButtonDesign(two);
            ApplyButtonDesign(three);
            ApplyButtonDesign(four);
            ApplyButtonDesign(five);
            ApplyButtonDesign(six);
            ApplyButtonDesign(seven);
            ApplyButtonDesign(eight);
            ApplyButtonDesign(nine);
            ApplyButtonDesign(percent);
            ApplyButtonDesign(divide);
            ApplyButtonDesign(plus);
            ApplyButtonDesign(minus);
            ApplyButtonDesign(sqrt);
            ApplyButtonDesign(multiply);
            ApplyButtonDesign(power);
            ApplyButtonDesign(zero);
            ApplyButtonDesign(factorial);
            ApplyButtonDesign(logarifm);
            ApplyButtonDesign(nlogarifn);
            ApplyButtonDesign(mod);
            ApplyButtonDesign(radian);
            ApplyButtonDesign(exponent);
            ApplyButtonDesign(pi);
            ApplyButtonDesign(sin);
            ApplyButtonDesign(cos);
            ApplyButtonDesign(tan);
            ApplyButtonDesign(cotan);
            ApplyButtonDesign(dot);
            output.Font = new Font(data.GetFont().Name, 35);
            Equals.Font = data.GetFont();
            remove.Font = data.GetFont();
            clear.Font = data.GetFont();
        }

        private void ApplyButtonDesign(Button button)
        {
            var themeId = data.ColorThemeName == "dark" ? 0 : 1;
            button.ForeColor = OptionsApplier.themeFontColors[themeId];
            button.BackColor = OptionsApplier.themeBackgroundColors[themeId];
            button.Font = data.GetFont();
        }

        private void InitializeDictionary()
        {
            actionsDictionary.Add('+', () => { result = firstNumber + secondNumber; });
            actionsDictionary.Add('-', () => { result = firstNumber - secondNumber; });
            actionsDictionary.Add('x', () => { result = firstNumber * secondNumber; });
            actionsDictionary.Add(':', () => { result = firstNumber / secondNumber; });
            actionsDictionary.Add('%', () => { result = firstNumber / 100 * secondNumber; });
            actionsDictionary.Add('^', () => { result = MathF.Pow(firstNumber, secondNumber); });
            actionsDictionary.Add('√', () => { result = MathF.Pow(secondNumber, 1 / firstNumber); });
            actionsDictionary.Add('l', () => { result = MathF.Log(firstNumber, secondNumber); });
            actionsDictionary.Add('n', () => { result = MathF.Log(MathF.E, secondNumber); });
            actionsDictionary.Add('s', () => { result = MathF.Sin(EMath.ConvertToRadian(firstNumber)); });
            actionsDictionary.Add('c', () => { result = MathF.Cos(EMath.ConvertToRadian(firstNumber)); });
            actionsDictionary.Add('t', () => { result = MathF.Tan(EMath.ConvertToRadian(firstNumber)); });
            actionsDictionary.Add('o', () => { result = EMath.Cotan(EMath.ConvertToRadian(firstNumber)); });
            actionsDictionary.Add('!', () => { result = EMath.Factorial(firstNumber); });
            actionsDictionary.Add('r', () => { result = EMath.ConvertToRadian(firstNumber); });
            actionsDictionary.Add('m', () => { result = MathF.Pow(MathF.E, firstNumber); });
        }

        #region OnClickEvents
        private void OnNumberClick(object sender, EventArgs e)
        {
            if (output.Text.Length != 0)
                if (output.Text.First() == '0' && output.Text.Length == 1)
                    ResetData();

            Button button = (Button)sender;
            ConcatNumber(button.Text.First());
            Debug();
        }

        private void OnActionClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var key = button.Text.First();

            if (key == 'l')
                key = button.Text == logarifm.Text ? 'l' : 'n';

            if (key == 'c')
                key = button.Text == cos.Text ? 'c' : 'o';


            if (action != null)
                ApplyResult();

            if (actionsDictionary.ContainsKey(key))
            {
                action = actionsDictionary[key];
                PutInputNumber(currentNumberString);
                ConcatOutput(button.Text);
            }
            else
                throw new Exception($"Actions dictionary doesn't contain key \'{key}\'");
            Debug();
        }

        private void OnRemoveClick(object sender, EventArgs e)
        {
            if (output.Text.Length != 0)
            {
                output.Text = output.Text.Remove(output.Text.Length - 1);
                if (currentNumberString.Length != 0)
                    currentNumberString = currentNumberString.Remove(currentNumberString.Length - 1);
                else
                {
                    currentNumberString = output.Text;
                    firstNumber = DefaultValue;
                    action = null;
                }
            }

            if (output.Text.Length == 0)
            {
                ResetData();
                return;
            }

            if (actionsDictionary.ContainsKey(output.Text.Last()))
                secondNumber = DefaultValue;
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            ResetData();
        }

        private void OnEqualsClick(object sender, EventArgs e)
        {
            ApplyResult();
        }
        #endregion

        private void Debug()
        {
            if (IsDebugMode == false)
                return;

            MessageBox.Show($"current number string: \'{currentNumberString}\',\n" +
                            $"first number: {firstNumber},\n" +
                            $"second number: {secondNumber},\n" +
                            $"result: {result},\n" +
                            $"action exists: {action != null}");
        }

        private void ResetData()
        {
            output.Text = "0";
            currentNumberString = output.Text;

            firstNumber = DefaultValue;
            secondNumber = DefaultValue;
            usedDot = false;
        }

        private void ConcatNumber(char number)
        {
            if (char.IsNumber(number) == false)
            {
                if(number == '.')
                {
                    if (usedDot)
                        return;

                    currentNumberString += number;
                    output.Text += number;
                    usedDot = true;
                    return;
                }

                string constant;
                switch (number)
                {
                    case 'e': constant = MathF.E.ToString().Remove(8); break;
                    case 'π': constant = MathF.PI.ToString().Remove(8); break;
                    default: throw new Exception("Unrecognized constant char");
                }
                currentNumberString = constant;
                if (action != null)
                {
                    output.Text = output.Text.Remove(firstNumber.ToString().Length + 1);
                    output.Text += constant;
                }
                else
                    output.Text = constant;

                usedDot = true;
                return;
            }

            if (currentNumberString.StartsWith('0') && usedDot == false)
            {
                if (number != '0')
                {
                    currentNumberString = string.Empty;
                    output.Text = output.Text.Remove(output.Text.Length - 1);
                }
                else
                    return;
            }

            currentNumberString += number;
            output.Text += number;
        }

        private void ConcatOutput(string text)
        {
            if (text.Length == 0)
                throw new Exception("Invalid text input");

            if(text.Length == 1)
                output.Text += text;
            else
                output.Text = $"{text}({output.Text})";
        }

        private void PutInputNumber(string value)
        {
            currentNumberString = string.Empty;
            usedDot = false;

            Debug();
            float number = new float();
            if (float.TryParse(value, out number) == false)
                return;

            if (firstNumber == DefaultValue)
                firstNumber = number;
            else if (secondNumber == DefaultValue)
                secondNumber = number;
        }

        private void ApplyResult()
        {
            PutInputNumber(currentNumberString);
            if(secondNumber == DefaultValue)
                secondNumber = 0;

            action?.Invoke();
            action = null;
            output.Text = result.ToString();

            firstNumber = result;
            secondNumber = DefaultValue;
        }
    }
}