using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstecalsManager : MonoBehaviour
{
    [SerializeField] private GameObject obstecalGameobject;
    [SerializeField] private float interval;
    [SerializeField] private Vector3 initPosition;

    private float timeSinceLastObstecal = 0;

    void Update()
    {
        if (timeSinceLastObstecal > 0)
        {
            timeSinceLastObstecal -= Time.deltaTime;
            return;
        }

        timeSinceLastObstecal = interval;

        var obstecal = GameObject.Instantiate(obstecalGameobject, initPosition, Quaternion.identity).GetComponent<Obstecal>();
        obstecal.InitializeObstecal(5);
    }

  
}
