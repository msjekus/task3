using task3.Services.Abstract;

namespace task3.Services.Implementation
{
    public class FactorialService : ICalculationService
    {
        public int Calculate(int index)
        {
            int res = 1;
            for (int i = 1; i < index; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
