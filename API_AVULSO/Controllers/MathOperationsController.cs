using API_AVULSO.Model;
using API_AVULSO.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace API_AVULSO.Controllers
{
    public class MathOperationsController : BaseController
    {
        private IMathOperations _mathOperations;
        public MathOperationsController(IMathOperations mathOperations)
        {
            _mathOperations = mathOperations;
        }

        [HttpPost(nameof(Sum))]
        public decimal Sum(decimal v1, decimal v2)
        {
            var result = _mathOperations.Sum(v1, v2);
            return result;
        }
    }
}
