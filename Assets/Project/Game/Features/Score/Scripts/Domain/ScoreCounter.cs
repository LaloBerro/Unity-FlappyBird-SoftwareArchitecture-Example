namespace Score.Domain
{
    public class ScoreCounter
    {
        private readonly IScoreCounterPresenter _scoreCounterPresenter;

        private int _score = 0;

        public ScoreCounter(IScoreCounterPresenter scoreCounterPresenter)
        {
            _scoreCounterPresenter = scoreCounterPresenter;
        }

        public void AddScore()
        {
            _score++;

            _scoreCounterPresenter.SetScore(_score);
        }
    }
}