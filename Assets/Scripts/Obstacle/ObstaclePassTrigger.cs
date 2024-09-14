using Messages;
using Services;
using Services.MessageHub;
using UnityEngine;

namespace Obstacle
{
    public class ObstaclePassTrigger : MonoBehaviour
    {
        private void OnTriggerExit2D(Collider2D collision)
        {
            Global.Locator.Get<IMessageHub>().Trigger(new PassThroughObstacle());
        }
    }
}