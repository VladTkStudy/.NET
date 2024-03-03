using ProgrammerCalculator;

namespace ExtendedMath
{
    public static class EMath
    {
        //Виконав: Ткаченко Владислав, група ПЗ-2204
        //Дата 03.03.2024, email:vladtk.fm@gmail.com

        public static float Factorial(float value)
        {
            int integer = (int)Math.Round(value);

            if (integer < 0)
                return 0;

            float result = 1;
            for (int i = 1; i <= integer; i++)
                result *= i;

            return result;
        }

        public static float Cotan(float value)
        {
            return MathF.Cos(value) / MathF.Sin(value);
        }

        public static float ConvertToRadian(float value)
        {
            return value * MathF.PI / 180;
        }

        public static string ConvertToBinary(string value, ByteRateType type)
        {
            try
            {
                return Convert.ToString(Convert.ToInt32(value, 2), (int)type);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"There wan an error while formatting value into binary format: (value = {value})\n" + exception.Message);
                return "Error";
            }
        }

        public static string ByteRateValuesAction(string first, string second, ByteRateType byteRateType, Func<int, int, int> action)
        {
            int result = action(Convert.ToInt32(first, (int)byteRateType), Convert.ToInt32(second, (int)byteRateType));
            return Convert.ToString(result, (int)byteRateType);
        }

        public static string ByteRateValueAction(string value, ByteRateType byteRateType, Func<int, int> action)
        {
            int result = action(Convert.ToInt32(value, (int)byteRateType));
            return Convert.ToString(result, (int)byteRateType);
        }
        /*
        public static string And(string first, string second, ByteRateType byteRateType)
        {
            string binaryFirst = ConvertToBinary(first, byteRateType);
            string binarySecond = ConvertToBinary(second, byteRateType);

            int result = Convert.ToInt32(binaryFirst, 2) & Convert.ToInt32(binarySecond, 2);
            return Convert.ToSingle(result).ToString();
        }

        public static string Or(string first, string second, ByteRateType byteRateType)
        {
            string binaryFirst = ConvertToBinary(first, byteRateType);
            string binarySecond = ConvertToBinary(second, byteRateType);

            int result = Convert.ToInt32(binaryFirst, 2) | Convert.ToInt32(binarySecond, 2);
            return Convert.ToSingle(result).ToString();
        }

        public static string Not(string first, ByteRateType byteRateType)
        {
            string binaryFirst = ConvertToBinary(first, byteRateType);

            int result = ~Convert.ToInt32(binaryFirst, 2);
            return Convert.ToSingle(result).ToString();
        }

        public static string Xor(string first, string second, ByteRateType byteRateType)
        {
            string binaryFirst = ConvertToBinary(first, byteRateType);
            string binarySecond = ConvertToBinary(second, byteRateType);

            int result = Convert.ToInt32(binaryFirst, 2) ^ Convert.ToInt32(binarySecond, 2);
            return Convert.ToSingle(result).ToString();
        }

        public static string Nor(string first, string second, ByteRateType byteRateType)
        {
            string binaryFirst = ConvertToBinary(first, byteRateType);
            string binarySecond = ConvertToBinary(second, byteRateType);

            int result = ~(Convert.ToInt32(binaryFirst, 2) | Convert.ToInt32(binarySecond, 2));
            return Convert.ToSingle(result).ToString();
        }

        public static string Nand(string first, string second, ByteRateType byteRateType)
        {
            string binaryFirst = ConvertToBinary(first, byteRateType);
            string binarySecond = ConvertToBinary(second, byteRateType);

            int result = ~(Convert.ToInt32(binaryFirst, 2) & Convert.ToInt32(binarySecond, 2));
            return Convert.ToSingle(result).ToString();
        }*/
    }
}
