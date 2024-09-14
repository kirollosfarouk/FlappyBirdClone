using Messages;
using Services;
using Services.MessageHub;
using TMPro;
using UnityEngine;

namespace UI
{
    public class GamePlayScreen : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;

        private void Start()
        {
            var hub = Global.Locator.Get<IMessageHub>();
            hub.Subscribe<ScoreMessage>(OnScoreUpdated);
        }

        private void OnScoreUpdated(ScoreMessage obj)
        {
           scoreText.text = obj.Score.ToString();
        }
    }
}