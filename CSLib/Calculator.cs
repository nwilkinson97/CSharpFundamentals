namespace CSLib
{
    public class Calculator
    {
        /// <summary>
        /// A simple Adding function that accepts an integer array
        /// </summary>
        /// <param name="numbers">Can Pass values as parameters or as an integer array</param>
        /// <returns></returns>
        public int Add(params int[] numbers)
        {
            var sum = 0;

            foreach (var i in numbers)
            {
                sum += i;
            }

            return sum;
        }
    }
}
