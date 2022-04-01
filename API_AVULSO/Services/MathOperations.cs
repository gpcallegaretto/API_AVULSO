using API_AVULSO.Model;

namespace API_AVULSO.Services
{
    public class MathOperations : IMathOperations
    {
        public decimal Sum(decimal v1, decimal v2)
        {
            var sum = v1 + v2;
            return sum;
        }
    }
}
