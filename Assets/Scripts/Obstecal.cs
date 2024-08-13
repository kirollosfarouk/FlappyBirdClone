using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstecal : MonoBehaviour
{
    private float speed;
    public void InitializeObstecal(float obstecalspeed)
    {
        speed = obstecalspeed;
    }
    private void Start()
    {

    }

    private void Update()
    {
        transform.Translate(Time.deltaTime * speed * Vector3.left);

        if (transform.position.x < -5)
        {
            Destroy(gameObject);
        }
    }

}
