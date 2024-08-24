using Messages;
using Services;
using Services.MessageHub;
using UnityEngine;

namespace Obstacle
{
    public class ObstacleTrigger : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Global.Locator.Get<IMessageHub>().Trigger(new GameOverMessage());
        }
    }
}