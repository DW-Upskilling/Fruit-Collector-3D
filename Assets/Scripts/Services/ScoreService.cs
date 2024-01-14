using TMPro;
using UnityEngine;

namespace FruitCollector3D.Services
{
    public class ScoreService
    {
        private TextMeshProUGUI _scoreUI;

        private float score;

        public ScoreService(TextMeshProUGUI _scoreUI)
        {
            this._scoreUI = _scoreUI;
            this.score = PlayerPrefs.GetFloat("Score", 0);

            UpdateScore(0);
        }

        public void UpdateScore(float score)
        {
            this.score = Mathf.RoundToInt(this.score + score);
            _scoreUI.text = this.score.ToString();

            PlayerPrefs.SetFloat("Score", this.score);
        }
    }
}
