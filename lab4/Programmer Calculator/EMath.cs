using ProgrammerCalculator;

namespace ExtendedMath
{
    public static class EMath
    {
        //Виконав: Ткаченко Владислав, група ПЗ-2204
        //Дата 01.03.2024, email:vladtk.fm@gmail.com

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

        public static int ConvertToBinary(string value, ByteRateType type)
        {
            return 0;
        }

        public static float And(float first, float second)
        {
            return 0;
        }

        public static float Or(float first, float second)
        {
            return 0;
        }

        public static float Not(float first, float second)
        {
            return 0;
        }

        public static float Xor(float first, float second)
        {
            return 0;
        }

        public static float Nor(float first, float second)
        {
            return 0;
        }

        public static float Nand(float first, float second)
        {
            return 0;
        }
    }
}
