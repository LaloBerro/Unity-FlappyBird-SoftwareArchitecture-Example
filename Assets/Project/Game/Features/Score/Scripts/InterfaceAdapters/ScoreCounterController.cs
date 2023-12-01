using MVVM.Controllers;
using MVVM.EventBinding.InteraceAdapters;
using Score.Domain;

namespace Score.InterfaceAdapters.Controllers
{
    public class ScoreCounterController : Controller
    {
        private readonly ScoreCounter _scoreCounter;

        public ScoreCounterController(EventBindingViewModel eventBindingViewModel, ScoreCounter scoreCounter) : base(
            eventBindingViewModel)
        {
            _scoreCounter = scoreCounter;
        }

        public override void Execute()
        {
            _scoreCounter.AddScore();
        }
    }
}