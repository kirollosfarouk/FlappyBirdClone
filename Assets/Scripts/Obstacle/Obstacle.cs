using UnityEngine;

namespace Obstacle
{
    public class Obstacle : MonoBehaviour
    {
        private float _speed;

        public void InitializeObstacle(float obstecalspeed)
        {
            _speed = obstecalspeed;
        }

        private void Update()
        {
            transform.Translate(Time.deltaTime * _speed * Vector3.left);

            if (transform.position.x < -5)
            {
                Destroy(gameObject);
            }
        }
    }
}