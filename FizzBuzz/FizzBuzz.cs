namespace FizzBuzz
{
    public class FizzBuzzKata
    {
        public string Answer(int i)
        {
            if ((i % 5 == 0) && (i % 3 == 0))
                return "fizzbuzz";

            if (i % 5 == 0)
                return "buzz";

            if (i % 3 == 0)
                return "fizz";

            return i.ToString();
        }
    }
}
