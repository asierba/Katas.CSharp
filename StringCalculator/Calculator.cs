namespace CalculatorKata
{
    public class Calculator
    {
        private const string Delimiter = ",";

        public static int Add(string numbers)
        {
            if(IsEmptyString(numbers))
                return 0;

            if (HasDelimiter(numbers))
            {
                return HandleMultiple(numbers);
            }

            return HandleOneNumber(numbers);
        }

        private static bool IsEmptyString(string numbers)
        {
            return numbers.Length == 0;
        }

        private static bool HasDelimiter(string numbers)
        {
            return numbers.IndexOf(Delimiter) > 0;
        }

        private static int HandleMultiple(string numbers)
        {
            string[] nums = numbers.Split(Delimiter.ToCharArray());

            int total = 0;
            foreach (var num in nums)
            {
                total += HandleOneNumber(num);
            }

            return total;
        }

        private static int HandleOneNumber(string numbers)
        {
            return int.Parse(numbers);
        }

    }
}
