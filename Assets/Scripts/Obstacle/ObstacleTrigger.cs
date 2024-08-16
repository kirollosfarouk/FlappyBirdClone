using UnityEngine;

namespace Obstacle
{
    public class ObstacleTrigger : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("GAME OVER");
        }
    }
}
