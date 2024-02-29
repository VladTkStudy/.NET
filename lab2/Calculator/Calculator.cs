namespace Calculator
{
    public partial class Calculator : Form
    {
        //Виконав: Ткаченко Владислав, група ПЗ-2204
        //Дата 26.02.2024, email:vladtk.fm@gmail.com

        private const float DefaultValue = float.MaxValue;
        private const bool IsDebugMode = false;
        private readonly Dictionary<char, Action> actionsDictionary = new();

        private Action? action;
        private string currentNumberString = string.Empty;

        private float firstNumber = DefaultValue;
        private float secondNumber = DefaultValue;
        private float result;

        public Calculator()
        {
            InitializeComponent();
            InitializeDictionary();
        }

        private void InitializeDictionary()
        {
            actionsDictionary.Add('+', () => { result = firstNumber + secondNumber; });
            actionsDictionary.Add('-', () => { result = firstNumber - secondNumber; });
            actionsDictionary.Add('x', () => { result = firstNumber * secondNumber; });
            actionsDictionary.Add(':', () => { result = firstNumber / secondNumber; });
            actionsDictionary.Add('%', () => { result = firstNumber / 100 * secondNumber; });
            actionsDictionary.Add('^', () => { result = MathF.Pow(firstNumber, secondNumber); });
            actionsDictionary.Add('√', () => { result = MathF.Pow(secondNumber, 1/firstNumber); });
        }

        #region OnClickEvents
        private void OnNumberClick(object sender, EventArgs e)
        {
            if(output.Text.Length != 0)
            {
                if(output.Text.First() == '0' && output.Text.Length == 1)
                {
                    ResetData();
                }
            }
            
            Button button = (Button)sender;
            ConcatNumber(button.Text.First());
            Debug();
        }

        private void OnActionClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var key = button.Text.First();

            if(action != null)
                ApplyResult();

            if (actionsDictionary.ContainsKey(key))
            {
                action = actionsDictionary[key];
                PutInputNumber(currentNumberString);
                ConcatSign(key);
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

            if(actionsDictionary.ContainsKey(output.Text.Last()))
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
        }

        private void ConcatNumber(char number)
        {
            if (char.IsNumber(number) == false)
                throw new Exception("Invalid number input");

            if (currentNumberString.StartsWith('0'))
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

        private void ConcatSign(char sign)
        {
            if(char.IsNumber(sign))
                throw new Exception("Invalid sign input");

            output.Text += sign;
        }

        private void PutInputNumber(string value)
        {
            currentNumberString = string.Empty;

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
            {
                ResetData();
                return;
            }

            action?.Invoke();
            action = null;
            output.Text = result.ToString();

            firstNumber = result;
            secondNumber = DefaultValue;
        }
    }
}