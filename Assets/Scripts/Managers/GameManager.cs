using Messages;
using Services;
using Services.MessageHub;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        private void Start()
        {
            Global.BindServices();
            
            Global.Locator.Get<IMessageHub>().Subscribe<GameOverMessage>(OnGameOver);
        }

        private void OnGameOver(GameOverMessage obj)
        {
            Debug.Log("GAME OVER");
        }
    }
}