namespace ProblemsSolver
{
    public class Problem2Solver
    {
        public int Solve(TipoSolucao tipoSolucao)
        {
            const int a1 = 1;
            const int a2 = 2;
            int result;
            switch (tipoSolucao)
            {
                case TipoSolucao.IterativaSemIf:
                    result = IterativoSemIf(a1, a2);
                    break;
                case TipoSolucao.IterativaComIf:
                    result = IterativoComIf(a1, a2);
                    break;
                default:
                    return 0;
            }

            return result;
        }

        private int IterativoComIf(int a1, int a2)
        {
            int result = 2;
            while (a2 < 4000000)
            {
                int aux = a1;
                a1 = a2;
                a2 = a1 + aux;
                if (a2%2 == 0)
                    result += a2;
            }
            return result;
        }

        private static int IterativoSemIf(int a1, int a2)
        {
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

    public enum TipoSolucao
    {
        IterativaComIf,
        IterativaSemIf
    }
}