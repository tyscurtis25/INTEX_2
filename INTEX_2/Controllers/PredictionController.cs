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

        [HttpPost]
        public ActionResult Score(CrashSeverity data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<float> score = result.First().AsTensor<float>();
            var prediction = new Prediction { PredictedValue = score.First() * 100000 };
            result.Dispose();
            return View(PredictionView, prediction);
        }

        private IActionResult PredictionView(float arg)
        {
            throw new NotImplementedException();
        }

        private ActionResult View(Func<float, IActionResult> predictionView, Prediction prediction)
        {
            throw new NotImplementedException();
        }
    }
}
