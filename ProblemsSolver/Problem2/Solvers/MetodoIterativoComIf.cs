namespace ProblemsSolver.Problem2.Solvers
{
    public class MetodoIterativoComIf : ICanSolveProblem2
    {
        public int Solve()
        {
            int a1 = 1;
            int a2 = 2;
            int result = 2;
            while (a2 < 4000000)
            {
                int aux = a1;
                a1 = a2;
                a2 = a1 + aux;
                if (a2 % 2 == 0)
                    result += a2;
            }
            return result;
        }
    }
}