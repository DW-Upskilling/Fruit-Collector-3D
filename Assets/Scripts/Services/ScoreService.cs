using TMPro;

namespace FruitCollector3D.Services
{
    public class ScoreService
    {
        private TextMeshProUGUI _scoreUI;

        private float score;

        public ScoreService(TextMeshProUGUI _scoreUI)
        {
            this._scoreUI = _scoreUI;
            this.score = 0;
        }

        public void UpdateScore(float score)
        {
            this.score += score;
            _scoreUI.text = this.score.ToString();
        }
    }
}
