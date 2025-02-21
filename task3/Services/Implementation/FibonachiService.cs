using task3.Services.Abstract;

namespace task3.Services.Implementation
{
    public class FibonachiService : ICalculationService
    {
        private readonly Dictionary<int, long> _cache = new();
        public int Calculate(int index)
        {
            if (index == 0) return 0;
            if (index == 1) return 1;
            int a = 0;
            int res = 1;

            for (int i = 2; i <= index; i++)
            {
                int temp = a + res;
                a = res;
                res = temp;
            }
            return res;
        }
    }
}
