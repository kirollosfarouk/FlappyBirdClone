using Messages;
using Services;
using Services.MessageHub;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        private int _score;
        private IMessageHub _hub;

        private void Awake()
        {
            Global.BindServices();
            _hub = Global.Locator.Get<IMessageHub>();
            _hub.Subscribe<GameOverMessage>(OnGameOver);
            _hub.Subscribe<PassThroughObstacle>(OnPassThroughObstacle);
        }

        private void OnPassThroughObstacle(PassThroughObstacle obj)
        {
            _score++;
            _hub.Trigger(new ScoreMessage(_score));
        }

        private void OnGameOver(GameOverMessage obj)
        {
            Debug.Log("GAME OVER");
        }
    }
}