using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovements : MonoBehaviour
{
    [SerializeField] private Rigidbody2D birdRigidbody;
    [SerializeField] private float force;


    void Update()
    {
        if (birdRigidbody != null && Input.GetMouseButtonUp(0))
        {
            birdRigidbody.AddForce(Vector2.up * force);
        }
    }
}
