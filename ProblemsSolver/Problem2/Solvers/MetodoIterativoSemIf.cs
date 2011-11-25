namespace ProblemsSolver.Problem2.Solvers
{
    public class MetodoIterativoSemIf : ICanSolveProblem2
    {
        public int Solve()
        {
            int a1 = 1;
            int a2 = 2;
            int result = 0;
            while (a2 < 4000000)
            {
                result += a2;
                Next(ref a1, ref a2);
                Next(ref a1, ref a2);
                Next(ref a1, ref a2);
            }
            return result;
        }

        private static void Next(ref int a1, ref int a2)
        {
            int aux = a1;
            a1 = a2;
            a2 = a1 + aux;
        }
    }
}