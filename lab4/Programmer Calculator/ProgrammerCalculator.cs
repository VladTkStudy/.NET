using ExtendedMath;

namespace Calculator
{
    public partial class ProgrammerCalculator : Form
    {
        //Виконав: Ткаченко Владислав, група ПЗ-2204
        //Дата 01.03.2024, email:vladtk.fm@gmail.com

        private const float DefaultValue = float.MaxValue;
        private const bool IsDebugMode = false;
        private readonly Dictionary<char, Action> actionsDictionary = new();

        private Action? action;
        private string currentNumberString = string.Empty;

        private float firstNumber = DefaultValue;
        private float secondNumber = DefaultValue;
        private float result;
        private bool usedDot = false;

        private Button[]? digitButtons;

        public ProgrammerCalculator()
        {
            InitializeComponent();
            InitializeDictionary();
            InitializeDigitButtonsArray();
        }

        private void InitializeDictionary()
        {
            actionsDictionary.Add('+', () => { result = firstNumber + secondNumber; });
            actionsDictionary.Add('-', () => { result = firstNumber - secondNumber; });
            actionsDictionary.Add('X', () => { result = firstNumber * secondNumber; });
            actionsDictionary.Add(':', () => { result = firstNumber / secondNumber; });
            actionsDictionary.Add('%', () => { result = firstNumber / 100 * secondNumber; });
            actionsDictionary.Add('^', () => { result = MathF.Pow(firstNumber, secondNumber); });
            actionsDictionary.Add('√', () => { result = MathF.Pow(secondNumber, 1 / firstNumber); });
            actionsDictionary.Add('a', () => { result = EMath.And(firstNumber, secondNumber); });
            actionsDictionary.Add('o', () => { result = EMath.Or(firstNumber, secondNumber); });
            actionsDictionary.Add('n', () => { result = EMath.Not(firstNumber, secondNumber); });
            actionsDictionary.Add('x', () => { result = EMath.Xor(firstNumber, secondNumber); });
            actionsDictionary.Add('p', () => { result = EMath.Nor(firstNumber, secondNumber); });
            actionsDictionary.Add('l', () => { result = EMath.Nand(firstNumber, secondNumber); });
        }

        private void InitializeDigitButtonsArray()
        {
            digitButtons = [zero, one, two, three, four, five, six, seven, eight, nine, a, b, c, d, e, f];
        }

        #region OnClickEvents
        private void OnSignClick(object sender, EventArgs e)
        {
            if (output.Text.Length != 0)
                if (output.Text.First() == '0' && output.Text.Length == 1)
                    ResetData();

            Button button = (Button)sender;
            ConcatSign(button.Text.First());
            Debug();
        }

        private void OnActionClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var key = button.Text.First();

            if (key == 'n')
                key = button.Text == not.Text ? 'n' : button.Text == nor.Text ? 'p' : 'l';

            if (key == 'x')
                key = button.Text == multiply.Text ? 'X' : 'x';

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

        private void OnSwitchBitRateClick(object sender, EventArgs e)
        {
            Button button = new Button();
            button = (Button)sender;

            if (digitButtons == null)
                return;

            int number = new int();
            if (int.TryParse(button.Text, out number))
            {
                foreach (var item in digitButtons)
                    item.Enabled = false;

                for (byte i = 0; i < number; i++)
                    digitButtons[i].Enabled = true;
            }
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

        private void ConcatSign(char number)
        {
            if (number == '.')
            {
                if (usedDot)
                    return;

                usedDot = true;
            }

            if (currentNumberString.StartsWith('0') && usedDot == false)
            {
                if (number == '0')
                    return;

                currentNumberString = string.Empty;
                output.Text = output.Text.Remove(output.Text.Length - 1);
            }

            currentNumberString += number;
            output.Text += number;
        }

        private void ConcatOutput(string text)
        {
            if (text.Length == 0)
                throw new Exception("Invalid text input");

            if (text.Length == 1)
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
            if (secondNumber == DefaultValue)
                secondNumber = 0;

            action?.Invoke();
            action = null;
            output.Text = result.ToString();

            firstNumber = result;
            secondNumber = DefaultValue;
        }
    }
}