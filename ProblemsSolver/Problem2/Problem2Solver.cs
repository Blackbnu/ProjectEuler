namespace ProblemsSolver.Problem2
{
    public class Problem2Solver
    {
        private readonly ICanSolveProblem2 solver;

        public Problem2Solver(ICanSolveProblem2 solver)
        {
            this.solver = solver;
        }

        public int Solve()
        {
            return solver.Solve();
        }
    }
}