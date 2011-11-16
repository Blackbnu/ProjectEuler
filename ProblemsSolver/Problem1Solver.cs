namespace ProblemsSolver
{
    public class Problem1Solver
    {
        public int Solve()
        {
            int result = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                    result += i;
            }
            return result;
        }
    }
}