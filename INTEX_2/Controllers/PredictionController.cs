using INTEX_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX_2.Controllers
{
    public class PredictionController : Controller
    {

        private InferenceSession _session;

        public PredictionController(InferenceSession session)
        {
            _session = session;
        }

        [HttpGet]
        public IActionResult LookingAhead()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Score(CrashSeverity data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<long> score = result.First().AsTensor<long>();
            var prediction = new Prediction { PredictedValue = score.Last() };
            result.Dispose();
            return View("Score", prediction);
        }

 
    }
}
