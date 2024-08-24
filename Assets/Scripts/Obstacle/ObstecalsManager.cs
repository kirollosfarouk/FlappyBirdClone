using UnityEngine;

namespace Obstacle
{
    public class ObstecalsManager : MonoBehaviour
    {
        [SerializeField] private GameObject obstacleGameobject;
        [SerializeField] private float interval;
        [SerializeField] private Vector3 initPosition;

        private float _timeSinceLastObstacle = 0;

        void Update()
        {
            if (_timeSinceLastObstacle > 0)
            {
                _timeSinceLastObstacle -= Time.deltaTime;
                return;
            }

            _timeSinceLastObstacle = interval;

            var obstacle = Instantiate(obstacleGameobject, initPosition, Quaternion.identity)
                .GetComponent<global::Obstacle.Obstacle>();

            obstacle.InitializeObstacle(5);
        }
    }
}